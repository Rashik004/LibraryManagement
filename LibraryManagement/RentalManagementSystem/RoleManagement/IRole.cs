using RentalManagementSystem.Artifacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalManagementSystem.RoleManagement
{
    public interface IRole
    {
        string Name { get; set; }
        string Description { get; set; }

        int RentLimit { get; set; }
        int RentDayLimit { get; set; }
        float ChargeRate { get; set; }

        double AccessLevel { get; set; }

        string ValidateOtherCriterias(IArtifact item);

    }
}
