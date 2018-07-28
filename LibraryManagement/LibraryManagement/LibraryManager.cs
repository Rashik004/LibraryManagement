using LibraryManagement.RentItemsManagement;
using LibraryManagement.RoleManagement;
using LibraryManagement.UserManagement;
using RentalManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class LibraryManager
    {
        IRoleManager _roleManager;
        UserManager _userManager;
        RentItemsManager _itemsManager;
        RentalManager _rentalSystem;


        public LibraryManager()
        {
            _roleManager = new RoleManager();
            _userManager = new UserManager(_roleManager);
            _itemsManager = new RentItemsManager();

            _rentalSystem = new RentalManager();
        }


        private void SetUp()
        {
            _roleManager.LoadRoles();
            _userManager.LoadUsers();
            _itemsManager.LoadItems();
        }

        public void Start()
        {
            SetUp();

            ShowMessage("Welcome to Cefalo Library");
            ShowMessage(CommonMessages.Separator);

            while(true)
            {
                ShowMessage(CommonMessages.EnterChoice);
                var choice = Console.ReadLine();

                if (choice.Equals(CommonMessages.Exit, StringComparison.InvariantCultureIgnoreCase))
                    break;

                ShowMessage(CommonMessages.NewLine2);

            }

            ShowMessage("Goodbye! Cefalo library system will now close.");
            Console.ReadKey();

        }

        //private string GetUserResponse()
        //{
            
        //}

        private static void ShowMessage(string message)
        {
            // show message to user in proper channel
            Console.WriteLine(message);
        }


    }

    public static class CommonMessages
    {
        public static readonly string EnterChoice = "Enter your choice";
        public static readonly string Separator = Environment.NewLine + "***********************************************" + Environment.NewLine;
        public static readonly string Exit = "Exit";

        //public static readonly string
        public static readonly string NewLine2 = Environment.NewLine + Environment.NewLine;

    }
}
