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

            RunCommandInterface();

            ShowMessage("Goodbye! Cefalo library system will now close.");
            Console.ReadKey();

        }

        private void RunCommandInterface()
        {
            while (true)
            {
                ShowMessage(CommonMessages.Commands);
                ShowMessage(CommonMessages.EnterChoice);
                var choice = Console.ReadLine();

                switch (choice.ToLower())
                {
                    case CommonMessages.CommandExit:
                        return;

                    case CommonMessages.CommandRent:
                        RentItemToUser();
                        break;

                    default:
                        ShowMessage(CommonMessages.InvalidCommand);
                        break;
                }

                ShowMessage(CommonMessages.NewLine2);

            }

        }

        private void RentItemToUser()
        {
            ShowMessage(CommonMessages.RentWelcom);
            ShowMessage(CommonMessages.CurrentUsers);

            // select users
            var users = _userManager.GetAllUsers();
            for (int index = 0; index < users.Count; index++)
            {
                ShowMessage($"No: {index + 1} - {users[index]}");
            }
            var userNo = Console.ReadLine();
            int userNum;
            if (int.TryParse(userNo, out userNum) == false)
            {
                ShowMessage(CommonMessages.InvalidCommand);
                return;
            }
            if (userNum - 1 >=  users.Count)
            {
                ShowMessage("User not found.");
                return;
            }
            var user = users[userNum - 1];
            ShowMessage($"User selected: {user}");

            // select item
            ShowMessage("Select item to rent");
            var items = _itemsManager.GetAllItems();
            for (int index = 0; index < items.Count; index++)
            {
                ShowMessage($"No: {index + 1} - {items[index]}");
            }
            var itemNo = Console.ReadLine();
            int itemNum;
            if (int.TryParse(itemNo, out itemNum) == false)
            {
                ShowMessage(CommonMessages.InvalidCommand);
                return;
            }
            if (itemNum - 1 >= items.Count)
            {
                ShowMessage("Item not found.");
                return;
            }
            var item = items[itemNum - 1];
            ShowMessage($"Item selected: {item}. Proceed? yes/no: ");
            var choice = Console.ReadLine();
            if (choice.ToLower() != "yes")
                return;

            // rent
            var result = _rentalSystem.IsUserAllowedToRent(user, item);

            if (_rentalSystem.IsSuccessfull(result) == false)
            {
                ShowMessage("Can not complete rent request." + result);
            }
            else
            {
                _rentalSystem.RentItemToUser(user, item);
            }
        }

        private static void ShowMessage(string message)
        {
            // show message to user in proper channel
            Console.WriteLine(message);
        }


    }

    public static class CommonMessages
    {
        public static readonly string EnterChoice = "Enter your command";
        public static readonly string Separator = Environment.NewLine + "***********************************************" + Environment.NewLine;

        public const string Commands = "Commands: Rent, Exit";
        public const string CommandExit = "exit";
        public const string CommandRent = "rent";

        //public static readonly string = "";
        //public static readonly string = "";
        public static readonly string RentWelcom = "Welcome to rent option. Select a user first";
        public static readonly string CurrentUsers = "Current users are:";
        public static readonly string SelectUser = "Enter user number: ";
        public static readonly string InvalidCommand = "Invalid command: please try again.";

        //public static readonly string = "";
        public static readonly string NewLine2 = Environment.NewLine + Environment.NewLine;

    }
}
