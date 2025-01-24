using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCellPhonev2025.Model.DAL
{
    public class CellphoneAccountSystem
    {
        //storing data
        public static CellPhoneAccount[] cellPhoneAccounts = new CellPhoneAccount[50];

        //to keep track of number of accounts added
        private static int counter = 0;

        //Method to Add a new account
        public static void AddNewAccount(CellPhoneAccount account)
        {
            if (counter < cellPhoneAccounts.Length)
            {
                cellPhoneAccounts[counter] = account;
                counter++;

                Console.WriteLine("\nAdded new entry successfully.\n");
                Console.WriteLine("  ");
                Console.WriteLine("\n--------------Details of the added account-------------\n");

                // Display common fields
                Console.WriteLine($"Cellphone Number: {account.CellPhoneNumber}");
                Console.WriteLine($"Total Call Time Used: {account.TotalCallTime} minutes");
                Console.WriteLine($"Total Cost of Calls: ${account.TotalCost}");

                // Display specific fields based on the account type
                if (account is Contract contract)
                {
                    Console.WriteLine($"Account Holder's Name: {contract.AccountHolderName}");
                    Console.WriteLine($"Address: {contract.Address}");
                    Console.WriteLine($"Contract Length: {contract.ContractLengthMonths} months");
                }
                else if (account is PayAsYouGo payAsYouGo)
                {
                    string accountTypeDescription = payAsYouGo.AccountType switch
                    {
                        'C' => "Callmore Time",
                        'P' => "Peak Time",
                        'A' => "Any Time",
                        _ => "Unknown Type"
                    };
                    Console.WriteLine($"Account Type: {accountTypeDescription}");
                }
                Console.WriteLine("----------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("Cannot add more accounts! Account list is full.");
            }
        }


        //Method  to display all accounts
        public static void DisplayAllAccounts()
        {
            foreach (var account in cellPhoneAccounts)
            {
                if (account != null)
                {
                    Console.WriteLine(account);
                }
            }
        }

        //Method to search using phone number
        public static void SearchByPhoneNumber(string phoneNumber)
        {
            bool found = false;
            foreach (var account in cellPhoneAccounts)
            {
                if (account != null && account.CellPhoneNumber == phoneNumber)
                {
                    Console.WriteLine("Account found:");
                    Console.WriteLine(account);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("No account found with the given phone number.");
            }
        }

    }
}
