using AspectCore.DependencyInjection;
using AspectCore.DynamicProxy;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Web.Attributes
{
    public class ServiceAopAttribute : AbstractInterceptorAttribute
    {
        [FromServiceContext]
        public ILogger<ServiceAopAttribute> Logger { get; set; }

        public async override Task Invoke(AspectContext context, AspectDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.ToString());
                throw;
            }
        }
    }
}
