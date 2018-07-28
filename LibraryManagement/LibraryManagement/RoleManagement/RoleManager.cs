using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.RoleManagement
{
    public class RoleManager
    {
        List<Role> _roles;

        public RoleManager()
        {
            _roles = new List<Role>();

        }

        private void SetupRoles()
        {
            _roles.Add(new Role()
            {
                Name = "CommonMember",
                RentLimit = 1,
                RentDayLimit = 3,
                ChargeRate = 10,
                PrivScale = 20,
                Description = "Common members of the library. Has the least priviledge. 1 item for 3 days. Priviledge scale 20"
            });
            _roles.Add(new Role()
            {
                Name = "Student",
                RentLimit = 3,
                RentDayLimit = 5,
                ChargeRate = 10,
                PrivScale =50,
                Description = "Student of the university. 3 item for 5 days. Priviledge scale 50"
            });
            _roles.Add(new Role()
            {
                Name = "Teacher",
                RentLimit = 5,
                RentDayLimit = 10,
                ChargeRate = 15,
                PrivScale = 80,
                Description = ""
            });
            _roles.Add(new Role()
            {
                Name = "CommonMember",
                RentLimit = 1,
                RentDayLimit = 3,
                ChargeRate = 5,
                PrivScale = 20,
                Description = ""
            });
            //_roles.Add(new Role()
            //{
            //    Name = "CommonMember",
            //    RentLimit = 1,
            //    RentDayLimit = 3,
            //    ChargeRate = 5,
            //    PrivScale = 20,
            //    Description = ""
            //});

        }

        public List<Role> GetAllRoles()
        {
            return _roles;
        }
    }
}
