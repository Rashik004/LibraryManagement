using RentalManagementSystem.Artifacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.RentItemsManagement
{
    public class LibraryItem : ArtifactBase
    {
        public DateTime AddedToInventory { get; set; }
        public int MinAgeLimit { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Category}. Price: {Price}";
        }
    }
}
