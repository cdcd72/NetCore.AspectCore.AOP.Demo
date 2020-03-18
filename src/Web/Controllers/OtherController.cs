using Microsoft.AspNetCore.Mvc;
using Web.Services.Interface;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class OtherController : Controller
    {
        private readonly IOtherService _otherService;

        public OtherController(IOtherService otherService)
        {
            _otherService = otherService;
        }

        [HttpGet("~/otherexecute")]
        public string Execute()
        {
            return _otherService.Execute();
        }

        [HttpGet("~/otherexecutexxxx")]
        public string ExecuteXXXX()
        {
            return _otherService.ExecuteXXXX();
        }

        [HttpGet("~/othergetxxxx")]
        public string GetXXXX()
        {
            return _otherService.GetXXXX();
        }
    }
}
