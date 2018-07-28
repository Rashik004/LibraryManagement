using RentalManagementSystem.Artifacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.RentItemsManagement
{
    public class Book : LibraryItem
    {
        public string ISBN { get; set; }
        public string Publisher { get; set; }
        public double Edition { get; set; }
    }
}
