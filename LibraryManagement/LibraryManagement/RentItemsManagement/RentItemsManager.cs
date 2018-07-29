using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.RentItemsManagement
{
    public class RentItemsManager
    {
        List<LibraryItem> _rentItems;

        public RentItemsManager()
        {
            _rentItems = new List<LibraryItem>();
        }

        public void LoadItems()
        {
            _rentItems.Add(new Book() {
                Title = "A brief history of time",
                Category = "Astronomy",
                AccessLevel = 30,
                Price = 200,
                Publisher = "Andromida publications"
            });
            _rentItems.Add(new Book()
            {
                Title = "A textbook on Quantum Physics",
                Category = "Physics",
                AccessLevel = 10,
                Price = 100,
                Publisher = "ABC publications"
            });
            _rentItems.Add(new Book()
            {
                Title = "The origin of species (Original print)",
                Category = "Biology",
                AccessLevel = 70,
                Price = 300,
                Publisher = "Harverd publications"
            });
            _rentItems.Add(new Book()
            {
                Title = "Essense of Rumid",
                Category = "Literature",
                AccessLevel = 20,
                Price = 200,
                Publisher = "Inner peace publications"
            });

            _rentItems.Add(new Magazine()
            {
                Title = "A new look on your home",
                Category = "LifeStyle",
                AccessLevel = 10,
                Price = 50,
                Publisher = "Stylelife inc"
            });

            _rentItems.Add(new Magazine()
            {
                Title = "Techworld horizon",
                Category = "Technology",
                IssueType = MagazineType.Monthly,
                AccessLevel = 10,
                Price = 50,
                Publisher = "Technology inc"
            });

            //_rentItems.Add(new Book()
            //{
            //    Title = "",
            //    Category = "",
            //    AccessLevel = 30,
            //    Price = 200,
            //    Publisher = "publications"
            //});

        }

        public List<LibraryItem> GetAllItems()
        {
            return _rentItems;
        }
    }
}
