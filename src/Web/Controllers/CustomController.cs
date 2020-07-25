using Microsoft.AspNetCore.Mvc;
using Web.Services.Interface;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class CustomController : ControllerBase
    {
        private readonly ICustomService _customService;

        public CustomController(ICustomService customService)
        {
            _customService = customService;
        }

        [HttpGet("~/customexecute")]
        public string Execute()
        {
            return _customService.Execute();
        }

        [HttpGet("~/customexecutexxxx")]
        public string ExecuteXXXX()
        {
            return _customService.ExecuteXXXX();
        }

        [HttpGet("~/customgetxxxx")]
        public string GetXXXX()
        {
            return _customService.GetXXXX();
        }
    }
}
