using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.RoleManagement
{
    public class Role
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float PrivScale { get; set; }

        public int RentLimit { get; set; }
        public int RentDayLimit { get; set; }
        public float ChargeRate { get; set; }

        public virtual bool ValidateOtherCriterias()
        {
            return true;
        }
        
    }
}
