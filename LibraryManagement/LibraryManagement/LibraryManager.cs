using LibraryManagement.RoleManagement;
using LibraryManagement.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class LibraryManager
    {
        IRoleManager _roleManager;
        UserManager _userManager;

        public LibraryManager()
        {
            _roleManager = new RoleManager();
            _userManager = new UserManager(_roleManager);
        }

        public void Start()
        {

        }


        public void SetUp()
        {
            _roleManager.LoadRoles();
            _userManager.LoadUsers();
        }
    }
}
