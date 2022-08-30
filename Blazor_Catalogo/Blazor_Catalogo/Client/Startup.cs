using Blazor_Catalogo.Client.Auth;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Blazor_Catalogo.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthorizationCore();

            services.AddScoped<TokenAuthenticationProvider>();

            services.AddScoped<IAuthorizeService, TokenAuthenticationProvider>(
                provider => provider.GetRequiredService<TokenAuthenticationProvider>()
                );

            services.AddScoped<AuthenticationStateProvider, TokenAuthenticationProvider>(
              provider => provider.GetRequiredService<TokenAuthenticationProvider>());
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
