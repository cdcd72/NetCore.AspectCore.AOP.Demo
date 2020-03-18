using Web.Services.Interface;

namespace Web.Services.Implement
{
    public class CustomService : ICustomService
    {
        public string Execute()
        {
            return "CustomService.Execute method executed.";
        }

        public string ExecuteXXXX()
        {
            return "CustomService.ExecuteXXXX method executed.";
        }

        public string GetXXXX()
        {
            return "CustomService.GetXXXX method executed.";
        }
    }
}
