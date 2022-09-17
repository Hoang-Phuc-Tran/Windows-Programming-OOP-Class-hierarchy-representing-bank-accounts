/*
 * FILE:        Program.cs
 * Project:	    A01 – C# AND OBJECT-ORIENTED PROGRAMMING
 * Author:	    Hoang Phuc Tran
 * Student ID:  8789102
 * Date:		September 16, 2022
 * Description: This file is used as a testing harness for three account classes. It will 
 * instantiate 3 different accounts and test the properties of each account class
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a Savings Account
            SavingsAccount account1 = new SavingsAccount("SavingsAccount", 3000, 202, 5m);
            Console.WriteLine("Creating a Savings Account with $3000 balance");
            // Instantiate a chequing Account
            ChequingAccount account2 = new ChequingAccount("ChequingAccount", 1000, 303, 15m);
            Console.WriteLine("Creating a Chequing Account with $1000 balance");
            // Instantiate a loan Account
            LoanAccount account3 = new LoanAccount("LoanAccount", 5000, 404, 0.15m);
            Console.WriteLine("Creating a Loan Account with $5000 balance\n");

            account1.PrintAccount();    // Display all the information of the SavingsAccount
            account2.PrintAccount();    // Display all the information of the ChequingAccount
            account3.PrintAccount();    // Display all the information of the LoanAccount

            // Test the savings account
            Console.WriteLine("************ Testing SavingsAccount ************");
            Console.WriteLine("---Deposit $1500 into SavingsAccount.---");
            account1.Deposit(1500);
            account1.PrintAccount();

            Console.WriteLine("---Withdraw $1000 from SavingsAccount.---");
            account1.Withdraw(1000);
            account1.PrintAccount();

            Console.WriteLine("---Calculate Interest Rate from SavingsAccount.---");
            account1.Deposit(account1.ApplyInterestRate());
            account1.PrintAccount();

            // Test the chequing account
            Console.WriteLine("************ Testing ChequingAccount ************");
            Console.WriteLine("---Deposit $2000 into ChequingAccount.---");
            account2.Deposit(2000);
            account2.PrintAccount();

            Console.WriteLine("---Withdraw $500 from ChequingAccount.---");
            account2.Withdraw(500);
            account2.PrintAccount();

            Console.WriteLine("---Calculate Interest Rate from ChequingAccount.---");
            account2.ApplyAnnualFree();
            account2.PrintAccount();

            // Test the loan account
            Console.WriteLine("************ Testing LoanAccount ************");
            Console.WriteLine("---Withdraw $5000 from LoanAccount.---");
            account3.Withdraw(5000);
            account3.PrintAccount();

            Console.WriteLine("---Deposit $1000 into LoanAccount.---");
            account3.Deposit(1000);
            account3.PrintAccount();

            Console.WriteLine("---Deposit $5000 into LoanAccount.---");
            account3.Deposit(5000);
            account3.PrintAccount();

            Console.WriteLine("---Withdraw $1000 from LoanAccount agian---");
            account3.Withdraw(5000);
        }
    }
}
