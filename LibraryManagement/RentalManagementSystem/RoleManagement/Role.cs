using RentalManagementSystem.Artifacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalManagementSystem.RoleManagement
{
    public class Role : IRole
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double AccessLevel { get; set; }

        public int RentLimit { get; set; }
        public int RentDayLimit { get; set; }
        public float ChargeRate { get; set; }
        
        public virtual string ValidateOtherCriterias(IArtifact item)
        {
            return Constants.SUCCESS_CODE;
        }
        
    }
}
