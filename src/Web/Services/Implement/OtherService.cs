using System;
using Web.Services.Interface;

namespace Web.Services.Implement
{
    public class OtherService : IOtherService
    {
        public string Execute()
        {
            throw new NotImplementedException();
        }

        public string ExecuteXXXX()
        {
            return "OtherService.ExecuteXXXX method executed.";
        }

        public string GetXXXX()
        {
            return "OtherService.GetXXXX method executed.";
        }
    }
}
