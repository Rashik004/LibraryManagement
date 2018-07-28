using RentalManagementSystem.Artifacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalManagementSystem.UserManagement
{
    public interface IUserAccount
    {
        string UserName { get; set; }
        double Balance { get; set; }

        List<IArtifact> RentedItems { get; set; }
    }
}
