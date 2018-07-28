using RentalManagementSystem.RoleManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.RoleManagement
{
    public class RoleManager : IRoleManager
    {


        List<IRole> _roles;

        public RoleManager()
        {
            _roles = new List<IRole>();

        }

        /// <summary>
        /// In real scenario roles are loaded from database
        /// </summary>
        public void LoadRoles()
        {
            _roles.Add(new Role()
            {
                Name = "CommonMember",
                RentLimit = 1,
                RentDayLimit = 3,
                ChargeRate = 10,
                AccessLevel = 20,
                Description = "Common members of the library. 1 item for 3 days. Access scale 20/100. Charge rate 10% of item price"
            });
            _roles.Add(new Role()
            {
                Name = "Student",
                RentLimit = 3,
                RentDayLimit = 5,
                ChargeRate = 10,
                AccessLevel =50,
                Description = "Student of the university. 3 item for 5 days. Priviledge scale 50/100. Charge rate 10% of item price"
            });
            _roles.Add(new Role()
            {
                Name = "Teacher",
                RentLimit = 5,
                RentDayLimit = 10,
                ChargeRate = 15,
                AccessLevel = 80,
                Description = "Teachers of the university. 5 items for 10 days. Access level 80/100. Charge rate 15% of item price"
            });
            _roles.Add(new Role()
            {
                Name = "Authority",
                RentLimit = 7,
                RentDayLimit = 15,
                ChargeRate = 25,
                AccessLevel = 100,
                Description = "Authority or admin members of the university. 7 items for 15 days. Access level 100/100. Charge rate 25% of item price"
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

        public void RemoveRole(IRole role)
        {
            _roles.Remove(role);
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
