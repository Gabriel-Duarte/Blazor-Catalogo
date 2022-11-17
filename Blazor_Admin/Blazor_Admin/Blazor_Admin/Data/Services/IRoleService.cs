using Blazor_Admin.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Blazor_Admin.Data.Services
{
    public interface IRoleService
    {
        Task<List<Role>> GetRoles();
        Task<List<Role>> GetRolesUser(Guid id);
        Task<bool> CreateRole(Role role);
        Task<Role> GetRole(Guid id);
        Task<bool> EditRole(Guid id, Role role);
        Task<bool> DeleteRole(Guid id);
    }
}
