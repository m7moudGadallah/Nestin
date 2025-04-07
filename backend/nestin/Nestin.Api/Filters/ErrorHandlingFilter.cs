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
            // Handle validation errors before controller logic
            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(context.ModelState.ExtractErrorList());
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // If result is a non-success HTTP code (e.g., 4xx or 5xx)
            if (context.Result is ObjectResult objectResult)
            {
                var statusCode = objectResult.StatusCode ?? 200;

                if (statusCode >= 400)
                {
                    // If not already a list of string, wrap into one
                    if (objectResult.Value is not List<string>)
                    {
                        var errorList = new List<string>();

                        switch (objectResult.Value)
                        {
                            case string str:
                                errorList.Add(str);
                                break;

                            case IEnumerable<string> strList:
                                errorList.AddRange(strList);
                                break;

                            default:
                                errorList.Add("An unexpected error occurred.");
                                break;
                        }

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

            // Detailed error depends on environment
            if (_env.IsProduction())
            {
                errorMessages.Add(context.Exception.Message);
            }
            else
            {
                errorMessages.Add(context.Exception.ToString());
            }

            context.Result = new ObjectResult(errorMessages)
            {
                StatusCode = 500
            };
        }
    }
}
