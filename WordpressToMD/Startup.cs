using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using WordpressToMD.Services;
using WordpressToMD.ViewModels;

namespace WordpressToMD
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<MainViewModel, MainViewModel>();
            services.AddTransient<IConvertWpToMdService, ConvertWpToMdService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
