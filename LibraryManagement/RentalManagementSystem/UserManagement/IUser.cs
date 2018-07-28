using RentalManagementSystem.RoleManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalManagementSystem.UserManagement
{
    public interface IUser
    {
        string UserName { get; set; }
        string Name { get; set; }
        IRole UserRole { get; set; }
        IUserAccount Account { get; set; }
    }
}
