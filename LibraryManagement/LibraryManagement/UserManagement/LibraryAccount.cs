using RentalManagementSystem.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.UserManagement
{
    public class LibraryAccount : UserAccount
    {

        public override void AdditionalRentSteps()
        {
            Console.WriteLine($"Rent request successful. User now has {RentedItems.Count} items rented. Current balance {Balance}");
        }
    }
}
