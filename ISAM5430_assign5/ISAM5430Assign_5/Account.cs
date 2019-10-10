using System;
using System.Collections.Generic;
using System.Text;

namespace ISAM5430Assign_5
{
    class Account
    {
        public string Name { get; set; }
        private decimal balance;
        public Account(string accountName, decimal initialBalance)
        {
            Name = accountName;
            Balance = initialBalance;
        }
        public decimal Balance
        {
            get
            {
                return balance;
            }
            private set
            {
                if (value > 0.0m)
                {
                    balance = value;
                }
            }
        }
        //public void Deposit(decimal depositAmount)
        //{
        //    if (depositAmount > 0.0m)
        //    {
        //        Balance = Balance + depositAmount;
        //    }
        //}
        public void Withdrawal(decimal withdrawalAmount)
        {
            if (withdrawalAmount < Balance)
            {
                Balance = Balance - withdrawalAmount;
            }
            else
            {
                Console.WriteLine("Withdrawal amount exceeded balance");
                Balance = Balance;
            }
        }
    }
  
}
