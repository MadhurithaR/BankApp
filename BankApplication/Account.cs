using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    enum TypeOfAccount
    {
        Savings,
        Checking,
        InstantAccess,
        CD,
        Loan
    }
    class Account
    {
        private static int lastAccountNumber = 0;

        #region Properties

        public int AccountNumber  { get; private set; }
        public string AccountName { get; set; }
        public TypeOfAccount AccountType { get; set; }
        public decimal Balance { get; private set; }
        public string  EmailAddress { get; set; }

        public DateTime CreatedDate { get; set; }

        #endregion

        #region Constructors

        public  Account()
        {
            AccountNumber =  ++lastAccountNumber;
            CreatedDate = DateTime.UtcNow;
        }

        //public Account(string accountName) : this()
        //{
        //   AccountName = accountName;
        //}

        //public Account(string accountName,string accountType) : this(accountName)
        //{
        //    AccountType = accountType;
        //}
        #endregion

        #region Methods

        /// <summary>
        /// Deposits the given amount
        /// </summary>
        /// <param name="amount"></param>
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        /// <summary>
        /// Withdraw a given amount of money and return balance
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public decimal Withdraw(decimal amount)
        {
            Balance -= amount;
            return Balance;
        }

        #endregion
    }
}
