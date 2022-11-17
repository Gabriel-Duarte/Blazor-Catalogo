using Blazor_Admin.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor_Admin.Data.Services
{
    public interface IUserService
    {
        Task<List<User>> GetUsers();
        Task<User> GetUser(Guid id);
        Task<bool> DeleteUser(Guid id);
        Task<bool>UpdateUserRole(Guid id, User user);

    }
}
