using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Catalogo.Client.Auth
{
    public interface IAuthorizeService
    {
        Task Login(string token);
        Task Logout();

    }
}
