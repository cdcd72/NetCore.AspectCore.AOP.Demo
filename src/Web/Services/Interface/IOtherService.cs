using AspectCore.DynamicProxy;

namespace Web.Services.Interface
{
    public interface IOtherService
    {
        string Execute();

        [NonAspect]
        string ExecuteXXXX();

        string GetXXXX();
    }
}
