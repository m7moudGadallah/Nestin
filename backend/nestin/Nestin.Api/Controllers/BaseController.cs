using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Interfaces;

namespace Nestin.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected readonly IUnitOfWork _unitOfWork;

        public BaseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        protected virtual NotFoundObjectResult NotFoundResponse(string? message = null)
        {
            return new NotFoundObjectResult(new List<string>
            {
                message ?? "Resource not found!"
            });
        }
    }
}
