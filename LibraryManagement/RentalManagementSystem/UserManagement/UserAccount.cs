using RentalManagementSystem.Artifacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalManagementSystem.UserManagement
{
    public class UserAccount : IUserAccount
    {
        public string UserName { get; set; }
        public double Balance { get; set; }

        public List<IArtifact> RentedItems { get; set; }

        public UserAccount()
        {
            RentedItems = new List<IArtifact>();
        }

        public virtual void RentItem(IArtifact item, double fee)
        {
            if (RentedItems.Contains(item) == false)
            {
                RentedItems.Add(item);
                Balance -= fee;

                AdditionalRentSteps();
            }
        }
        public virtual void AdditionalRentSteps()
        {
        }

        public virtual void ReturnItem(IArtifact item, double fee)
        {
            if (RentedItems.Contains(item))
            {
                RentedItems.Remove(item);
                Balance += fee;

                AdditionalReturnSteps();
            }
        }

        public virtual void AdditionalReturnSteps()
        {
        }


    }
}
