using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.RentItemsManagement
{
    public class Magazine : LibraryItem
    {
        public string Publisher { get; set; }
        public MagazineType IssueType { get; set; }

        public override string ToString()
        {
            return  base.ToString() +  $" {IssueType} Magazine";
        }
    }
    

    public enum MagazineType
    {
        Weekly,
        Monthly
    }
}
