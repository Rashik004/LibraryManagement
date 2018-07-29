using RentalManagementSystem.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.UserManagement
{
    public class LibraryUser : User
    {
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{UserName} ({Name}). Balance: {Account.Balance}";
        }
    }
}
