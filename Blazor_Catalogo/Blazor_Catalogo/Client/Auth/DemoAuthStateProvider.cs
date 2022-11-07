using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Blazor_Catalogo.Client.Auth
{
    public class DemoAuthStateProvider : AuthenticationStateProvider

    {
        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            await Task.Delay(4000);
            //indicando se o usuario esta autenticado e tamebem os seus claims 
            var usuario = new ClaimsIdentity(new List<Claim>(){
            new Claim("Chave", "Valor"),
            new Claim(ClaimTypes.Name, "Gabriel Duarte"),
            new Claim(ClaimTypes.Role, "Admin")
            }, "demo");

            return await Task.FromResult(new AuthenticationState(
                new ClaimsPrincipal(usuario)));      
        }
    }
}
