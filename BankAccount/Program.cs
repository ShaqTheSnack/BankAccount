using System;
using System.Collections.Generic;

namespace BankAccount
{
    internal class Program
    {
        private static List<string> accountNames = new List<string>();

        #region Layout
        static void Main(string[] args)
        {

            Console.WriteLine("BANK ACCOUNT");
            Console.WriteLine("-----------------------------------------------");
            MakeAccount();
            Console.Clear();


            Console.WriteLine("BANK ACCOUNT");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("LOGIN. ");
            Console.Write("Username:");
            string name = Console.ReadLine();


            if (accountNames.Contains(name))
            {
                Console.Clear();
                Console.WriteLine($"Hi {name}, What can I do for you?");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Press '1' To View Balance. ");
                Console.WriteLine("Press '2' To Deposit");
                Console.WriteLine("Press '3' To Withdraw");
                string press123 = Console.ReadLine(); 


                if (press123 == "1")
                {
                    Console.Clear();
                    Console.WriteLine("You chose to View Balance.");
                    Console.WriteLine();
                    MyBalance();


                }
                else if (press123 == "2")
                {
                    Console.Clear();
                    Console.WriteLine("You chose to Deposit.");
                    Console.WriteLine();
                    Depositing();

                }
                else if (press123 == "3")
                {
                    Console.Clear();
                    Console.WriteLine("You chose to Withdraw.");
                    Console.WriteLine();
                    Withdrawing();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("INVALID ANSWER");
                }
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("You are not a member of this bank.");
                Console.ReadLine();
            }
        }
        #endregion

        #region MyBalance 
        private static void MyBalance()
        {
            Balance accountBalance = new Balance(0);
   
            double currentBalance = accountBalance.GetCurrentBalance();
            Console.WriteLine($"Current Balance: {currentBalance}");

        }
        #endregion

        #region Depositings 
        private static void Depositing()
        {
            Balance accountBalance = new Balance(0);

            Console.Write("Enter the amount to deposit: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            accountBalance.Deposit(amount);
            Console.WriteLine($"Deposited {amount} kr. New balance: {accountBalance.GetCurrentBalance()} kr.");
        }
        #endregion

        #region Withdrawings 
        private static void Withdrawing()
        {
            Balance accountBalance = new Balance(0);

            Console.Write("Enter the amount to withdraw: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.Clear() ;
            accountBalance.Withdraw(amount);
            Console.WriteLine($"Withdrawn {amount} kr. New balance: {accountBalance.GetCurrentBalance()} kr.");
        }
        #endregion

        #region AccountManagment
        private static void MakeAccount()
        
        {
            Console.WriteLine("Create your account. press [ENTER]");
            Console.WriteLine("-----------------------------------------------");
            Console.ReadLine();
            while (true)
            {
                Console.Clear ();
                Console.Write("Create a username:");

                string input = Console.ReadLine();



                accountNames.Add(input);

                Console.WriteLine();
                Console.Clear();
                Console.WriteLine("BANK ACCOUNT");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Make one more account press:            [ENTER]");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Sign in press:                              [1]");
                Console.WriteLine("-----------------------------------------------");
                string inpot = Console.ReadLine();
                if (inpot.ToLower() == "1")
                {
                    break;
                }
            }
        }
        #endregion
    }
}
