﻿using BlazorPrettyCode;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Sample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddBlazorPrettyCode(defaults =>
            {
                defaults.DefaultTheme = "SolarizedDark";
                defaults.ShowLineNumbers = true;
            });
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
