using RentalManagementSystem.RoleManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalManagementSystem.Artifacts;
using RentalManagementSystem.UserManagement;
using LibraryManagement.UserManagement;
using LibraryManagement.RentItemsManagement;

namespace LibraryManagement.RoleManagement
{
    public class CustomRoles
    {
        public IEnumerable<IRole> GetCustomRoles()
        {
            yield return new Children();
        }
    }

    public class Children : Role
    {
        public Children()
        {
            Name = "Children";
            RentLimit = 3;
            RentDayLimit = 5;
            ChargeRate = 10;
            AccessLevel = 50;
        }

        public override string ValidateOtherCriterias(IUser user, IArtifact item)
        {
            var librUser = (LibraryUser) user;
            var librItem = (LibraryItem)item;

            if (librUser.Age < librItem.MinAgeLimit)
                return $"This item {item} is not suitable for user {user}. Minimum age should be {librItem.MinAgeLimit} to rent this item";

            return base.ValidateOtherCriterias(user, item);
        }
    }
}
