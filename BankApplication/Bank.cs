using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    static class Bank
    {
        private static List<Account> accounts = new List<Account>();

       public static Account createAccount(string accountName,string emailAddress, TypeOfAccount accountType, decimal initialBalance)
        {
            var account = new Account
            {
                AccountName = accountName,
                AccountType = accountType,
                EmailAddress = emailAddress,
            };
            if (initialBalance > 0)
            {
                account.Deposit(initialBalance);
            }
            accounts.Add(account);
            return account;
        }   
        
        public static IEnumerable<Account> GetAllAccounts(string emailAddress)
        {
            // LINQ and lambda
           return accounts.Where(a => a.EmailAddress == emailAddress);// foreach a in my accounts give it to the right hand side to evaluate, that is give a's email address


        }
   
    }
}
