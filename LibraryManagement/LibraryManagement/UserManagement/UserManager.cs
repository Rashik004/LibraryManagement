using LibraryManagement.RoleManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.UserManagement
{
    public class UserManager
    {
        IRoleManager _roleManager;
        List<LibraryUser> _users;

        public UserManager(IRoleManager roleManager)
        {
            _roleManager = roleManager;
            _users = new List<LibraryUser>();
        }

        /// <summary>
        /// In real scenario this method loads users from Database
        /// </summary>
        public void LoadUsers()
        {
            _users.Add(new LibraryUser()
            {
                Name = "Rashik Hasnat",
                UserName = "Rashik",
                UserRole = _roleManager.GetRole("Teacher"),
                Account = new LibraryAccount()
                {
                    Balance = 200,
                    UserName = "Rashik"
                }
            });
            _users.Add(new LibraryUser()
            {
                Name = "Zaki Choudhury",
                UserName = "Zaki",
                UserRole = _roleManager.GetRole("CommonMember"),
                Account = new LibraryAccount()
                {
                    Balance = 50,
                    UserName = "Zaki"
                }
            });
            _users.Add(new LibraryUser()
            {
                Name = "Stephen Hawking",
                UserName = "Steve",
                UserRole = _roleManager.GetRole("Student"),
                Account = new LibraryAccount()
                {
                    Balance = 100,
                    UserName = "Steve"
                }
            });
        }

    }
}
