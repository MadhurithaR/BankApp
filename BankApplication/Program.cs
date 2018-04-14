using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //  // Object or instance
            //  //  var account = new Account();
            //  var account = new Account { AccountName = "my checking", AccountType = "Checking", EmailAddress = "test@test.com"};
            //  account.AccountName = "My Checking";
            //  account.Deposit(100.45M);
            //// // account.Balance = 1000;
            ////  Console.WriteLine("The amount before a deposit is {0}", account.Balance);
            ////  account.deposit(100);
            ////  Console.WriteLine("The amount after a deposited amount is {0}",account.Balance );
            ////// account.Balance = account.withdraw(500);
            ////  Console.WriteLine("The amount after a withdrawal amount is {0}", account.Balance);
            //  Console.WriteLine($"AN: {account.AccountName}, CD: {account.CreatedDate}, Balance: {account.Balance},Name: {account.AccountName}, Type :{account.AccountType}");

            //  var account2 = new Account();
            //  Console.WriteLine($"AN: {account2.AccountName}, CD: {account2.CreatedDate}, Balance: {account2.Balance},Name: {account2.AccountName}, Type :{account.AccountType}");

            Console.WriteLine("*********************");
            Console.WriteLine("**Welcome to my bank!**");

            while(true)
            { 
            Console.WriteLine("0. Quit");
            Console.WriteLine("1. Create a new account");
            Console.WriteLine("2. Deposit money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Print all accounts");

            Console.WriteLine("Please select an option from above.");
            var option = Console.ReadLine();

                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting");
                        return;
                    case "1":
                        Console.Write("Email Address: ");
                        var email = Console.ReadLine();
                        Console.Write("Account Name: ");
                        var accountName = Console.ReadLine();
                        Console.WriteLine("Account Type: ");
                        var accountTypes = Enum.GetNames(typeof(TypeOfAccount)); // GetNames gives an array of the enum
                        for (var i = 0; i < accountTypes.Length; i++)// you can also increment as i+=2 or how ever u want to increment
                        {
                            Console.WriteLine($"{i} . {accountTypes[i]}");
                        }
                        Console.Write("Your choice: ");
                        var accountType = (TypeOfAccount)Enum.Parse(typeof(TypeOfAccount), Console.ReadLine());
                        Console.Write("Initial Deposit: ");
                        var amount = Convert.ToDecimal(Console.ReadLine());

                       var account = Bank.createAccount(accountName, email, accountType, amount);
                        Console.WriteLine($"AN: {account.AccountName},emailAddress:{account.EmailAddress}, CD: {account.CreatedDate}, Balance: {account.Balance},Name: {account.AccountName}, Type :{account.AccountType}");

                        break;
                    case "4":
                        Console.Write("Email Address: ");
                        email = Console.ReadLine();
                        var accounts = Bank.GetAllAccounts(email);
                        foreach(var acc in accounts)
                        {
                            Console.WriteLine($"AN: {acc.AccountName}, emailAddress:{acc.EmailAddress},CD: {acc.CreatedDate}, Balance: {acc.Balance},Name: {acc.AccountName}, Type :{acc.AccountType}");
                        }
                        break;
                }

                //case "2":
                //case "3":

                //case "5":
            }





        }
    }
}
