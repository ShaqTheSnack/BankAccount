using System;

namespace BankAccount
{
    internal class Balance
    {
        private double accountBalance;

        #region MyBalance 
        public Balance(double initialBalance)
        {
            accountBalance = initialBalance;
        }

        public double GetCurrentBalance()
        {
            return accountBalance;
        }
        #endregion

        #region Deposit
        public void Deposit(double amount)
        {
            accountBalance += amount;
        }
        #endregion

        #region Withdraw 
        public void Withdraw(double amount)
        {
            if (amount > accountBalance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            
            else
            {
                accountBalance -= amount;
            }
        }
        #endregion
    }
}
