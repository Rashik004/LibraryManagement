using RentalManagementSystem.RoleManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalManagementSystem.UserManagement
{
    public class User : IUser
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public IRole UserRole { get; set; }
        public virtual IUserAccount Account { get; set; }

    }
}
