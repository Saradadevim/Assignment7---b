using ConsoleAppCellPhonev2025.Model;
using ConsoleAppCellPhonev2025.Model.DAL;

namespace ConsoleAppCellPhonev2025
{
    internal class CellPhoneApp
    {
        static void Main(string[] args)
        {
            //Menu Driven
            while (true)
            {
                // Display menu
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Contract ");
                Console.WriteLine("2. PayAsYouGo ");
                Console.WriteLine("3. Display ");
                Console.WriteLine("4. Search ");
                Console.WriteLine("5. Exit ");

                // Get user choice
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Handle Contract option
                        //add contract account 
                        Console.WriteLine("\n--- Add Contract Account ---");

                        //add and save cellphone number
                        Console.Write("Enter Cellphone Number: ");
                        string contractPhoneNumber = Console.ReadLine();

                        //add and save total call time
                        Console.Write("Enter Total Call Time (in minutes): ");
                        double contractCallTime = Convert.ToDouble(Console.ReadLine());

                        //add and save total cost
                        Console.Write("Enter Total Cost: ");
                        double contractCost = Convert.ToDouble(Console.ReadLine());

                        //add and save account holder name
                        Console.Write("Enter Account Holder Name: ");
                        string accountHolderName = Console.ReadLine();

                        //add and save address
                        Console.Write("Enter Address: ");
                        string address = Console.ReadLine();

                        //add and save the length of contract
                        Console.Write("Enter Contract Length (in months): ");
                        int contractLength = Convert.ToInt32(Console.ReadLine());

                        // Create Contract object and add to system
                        Contract contract = new Contract(contractPhoneNumber, contractCallTime, contractCost, accountHolderName, address, contractLength);
                        CellphoneAccountSystem.AddNewAccount(contract);
                        break;

                    case "2":
                        // Handle PayAsYouGo option
                        Console.WriteLine("\n--- Add PayAsYouGo Account --- \n");

                        //add cellphone number
                        Console.Write("Enter Cellphone Number: ");
                        string payAsYouGoPhoneNumber = Console.ReadLine();

                        //add total call time
                        Console.Write("Enter Total Call Time: ");
                        double payAsYouGoCallTime = Convert.ToDouble(Console.ReadLine());

                        //add total cost
                        Console.Write("Enter Total Cost: ");
                        double payAsYouGoCost = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter Account Type (C for Callmore, P for Peak Time, A for Any Time): ");
                        char accountType = Console.ReadKey().KeyChar;
                        Console.WriteLine();

                        // Validate input for account type
                        if (accountType != 'C' && accountType != 'P' && accountType != 'A')
                        {
                            Console.WriteLine("Invalid account type! Please enter C, P, or A.");
                            break;
                        }

                        // Create PayAsYouGo object and add to system
                        PayAsYouGo payAsYouGo = new PayAsYouGo(payAsYouGoPhoneNumber, payAsYouGoCallTime, payAsYouGoCost, accountType);
                        CellphoneAccountSystem.AddNewAccount(payAsYouGo);
                        break;

                    case "3":
                        // Display all accounts
                        Console.WriteLine("\n--- Display All Accounts ---");
                        CellphoneAccountSystem.DisplayAllAccounts();
                        break;

                    case "4":
                        // Search for an account by phone number
                        Console.Write("\nEnter phone number to search: ");
                        string phoneNumber = Console.ReadLine();
                        CellphoneAccountSystem.SearchByPhoneNumber(phoneNumber);
                        break;

                    case "5":
                        // Exit the application
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                // Keep the screen paused
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
