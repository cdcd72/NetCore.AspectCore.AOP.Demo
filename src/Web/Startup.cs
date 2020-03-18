using AspectCore.Configuration;
using AspectCore.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Web.Attributes;
using Web.Services.Implement;
using Web.Services.Interface;

namespace Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // 此方法 Runtime 時被觸發，使用此方法加入相關服務至容器
        public void ConfigureServices(IServiceCollection services)
        {
            // 注入所需 Services
            services.AddTransient<ICustomService, CustomService>();
            services.AddTransient<IOtherService, OtherService>();

            services.AddControllers();

            // 設定動態代理
            // https://github.com/dotnetcore/AspectCore-Framework
            services.ConfigureDynamicProxy(config => { config.Interceptors.AddTyped<ServiceAopAttribute>(Predicates.ForMethod("Execute*")); });
        }

        // 此方法 Runtime 時被觸發，使用此方法設置 HTTP 要求管道(HTTP request pipeline)
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
