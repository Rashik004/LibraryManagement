using RentalManagementSystem.Artifacts;
using RentalManagementSystem.RoleManagement;
using RentalManagementSystem.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalManagementSystem
{
    public class RentalManager
    {


        public string IsUserAllowedToRent(IUser user, IArtifact item)
        {

            if (user.UserRole.AccessLevel < item.AccessLevel)
                return $"{user.Name} is not allowed to rent {item.Title}. User need a higher acount than {user.UserRole.Name}";

            if (user.UserRole.RentLimit >= user.Account.RentedItems.Count)
                return $"Cannot rent item {item.Title} to {user.Name}. User has already reached his rent limit of {user.UserRole.RentLimit} items";

            if (user.Account.Balance < item.Price * (user.UserRole.ChargeRate / 100))
                return $"Cannot rent {item.Title} to user. user need a minimum {item.Price * (user.UserRole.ChargeRate / 100)} fund in his account. " + 
                    $"Current account balance is {user.Account.Balance}";

            
            return user.UserRole.ValidateOtherCriterias(item);
        }
    }
}
