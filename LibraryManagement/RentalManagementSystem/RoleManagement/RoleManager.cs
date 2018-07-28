using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalManagementSystem.RoleManagement
{
    public class RoleManager : IRoleManager
    {
        List<IRole> _roles;

        public RoleManager()
        {
            _roles = new List<IRole>();

        }

        public void SetupRoles()
        {
            _roles.Add(new Role()
            {
                Name = "CommonMember",
                RentLimit = 1,
                RentDayLimit = 3,
                ChargeRate = 10,
                AccessLevel = 20,
                Description = "Common members of the library. Has the least priviledge. 1 item for 3 days. Priviledge scale 20/100"
            });
            _roles.Add(new Role()
            {
                Name = "Student",
                RentLimit = 3,
                RentDayLimit = 5,
                ChargeRate = 10,
                AccessLevel =50,
                Description = "Student of the university. 3 item for 5 days. Priviledge scale 50/100"
            });
            _roles.Add(new Role()
            {
                Name = "Teacher",
                RentLimit = 5,
                RentDayLimit = 10,
                ChargeRate = 15,
                AccessLevel = 80,
                Description = ""
            });
            _roles.Add(new Role()
            {
                Name = "CommonMember",
                RentLimit = 1,
                RentDayLimit = 3,
                ChargeRate = 5,
                AccessLevel = 20,
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

        public void AddRole(IRole newRole)
        {
            _roles.Add(newRole);
        }

        public IRole GetRole(string name)
        {
            return _roles.FirstOrDefault(r => r.Name == name);
        }

        public List<IRole> GetAllRoles()
        {
            return _roles;
        }
    }
}
