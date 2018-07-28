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

        private LibraryAccount _account;

        public override IUserAccount Account
        {
            get
            {
                return _account;
            }

            set
            {
                base.Account = value;
            }
        }
    }
}
