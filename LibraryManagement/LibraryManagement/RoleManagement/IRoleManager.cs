using RentalManagementSystem.RoleManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.RoleManagement
{
    public interface IRoleManager
    {
        void LoadRoles();
        void AddRole(IRole newRole);
        IRole GetRole(string name);
        List<IRole> GetAllRoles();
    }
}
