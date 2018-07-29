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

        //private LibraryAccount _account;

        //public new IUserAccount Account
        //{
        //    get
        //    {
        //        return (IUserAccount) _account;
        //    }

        //    set
        //    {
        //        base.Account = (IUserAccount) value;
        //    }
        //}

        public override string ToString()
        {
            return $"{UserName} ({Name}). Balance: {Account.Balance}";
        }
    }
}
