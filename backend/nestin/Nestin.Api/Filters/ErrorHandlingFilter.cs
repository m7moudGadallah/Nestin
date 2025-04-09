using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Nestin.Api.Utils;

namespace Nestin.Api.Filters
{
    public class ErrorHandlingFilter : IActionFilter, IExceptionFilter
    {
        private readonly IWebHostEnvironment _env;

        public ErrorHandlingFilter(IWebHostEnvironment env)
        {
            _env = env;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            // Handle model validation errors early
            if (!context.ModelState.IsValid)
            {
                var errors = context.ModelState.ExtractErrorList();
                context.Result = new BadRequestObjectResult(errors);
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Skip if there was an exception — handled in OnException
            if (context.Exception != null) return;

            // Check for ObjectResult with error status code
            if (context.Result is ObjectResult objectResult)
            {
                var statusCode = objectResult.StatusCode ?? 200;

                if (statusCode >= 400)
                {
                    // Prevent re-wrapping if already List<string>
                    if (objectResult.Value is not List<string>)
                    {
                        var errorList = objectResult.Value switch
                        {
                            string str => new List<string> { str },
                            IEnumerable<string> strList => strList.ToList(),
                            _ => new List<string> { "An unexpected error occurred." }
                        };

                        context.Result = new ObjectResult(errorList)
                        {
                            StatusCode = statusCode
                        };
                    }
                }
            }
        }

        public void OnException(ExceptionContext context)
        {
            context.ExceptionHandled = true;

            var errorMessages = new List<string>
            {
                "An error occurred while processing your request."
            };

            // In development, include full exception details
            if (!_env.IsProduction())
            {
                errorMessages.Add(context.Exception.ToString());
            }
            else
            {
                errorMessages.Add(context.Exception.Message);
            }

            context.Result = new ObjectResult(errorMessages)
            {
                StatusCode = 500
            };
        }
    }
}
