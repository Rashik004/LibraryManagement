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
        public bool IsSuccessfull(string result)
        {
            return result == Constants.SUCCESS_CODE;
        }

        public string IsUserAllowedToRent(IUser user, IArtifact item)
        {

            if (user.UserRole.AccessLevel < item.AccessLevel)
                return Constants.NeedHigherAccess;

            if (user.UserRole.RentLimit <= user.Account.RentedItems.Count)
                return Constants.RentCountReached;

            if (user.Account.Balance < user.CalculateFeeForItem(item))
                return Constants.NotEnoughBalance;
            
            return user.UserRole.ValidateOtherCriterias(user, item);
        }

        public void RentItemToUser(IUser user, IArtifact item)
        {
            user.Account.RentItem(item, item.Price * (user.UserRole.ChargeRate / 100));
        }

        public void ReturnItemFromUser(IUser user, IArtifact item)
        {
            user.Account.ReturnItem(item, item.Price * (user.UserRole.ChargeRate / 100));
        }


    }
}
