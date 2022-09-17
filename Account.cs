/*
 * FILE:        Account.cs
 * Project:	    A01 – C# AND OBJECT-ORIENTED PROGRAMMING
 * Author:	    Hoang Phuc Tran
 * Student ID:  8789102
 * Date:		September 16, 2022
 * Description: This file contains an Account class and its properties which is used to be inherited from the other classes
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace A01
{
    /*CLASS NAME:  Account
    * PURPOSE : The Account class has been created to model A Bank account. This class is used to be inherited from other accounts. It has properties 
    * to perform Deposit and Withdraw money from accounts and display all information about the account)
    */
    class Account
    {
        private string accountType;             // Holds the string of the bank account
        private decimal currentBalance;         // Holds the decimal of the current ballance of the bank account
        private int accountNumber;              // Holds the account number

        /*  -- Method Header Comment
	     Name	    : Account -- CONSTRUCTOR
	     Purpose    : to instantiate a new account object - given a set of attribute values
	     Inputs	    : NONE
	     Outputs	: NONE
	     Returns	: Nothing
        */
        public Account()
        {
            accountType = "Unknown";
            currentBalance = 0;
            accountNumber = 0;
        }

        /*  -- Method Header Comment
	     Name	    : Account -- CONSTRUCTOR
	     Purpose    : to instantiate a new account object - given a set of attribute values
	     Inputs	    : accountTypeNew        string
                      currentBalanceNew     decimal
                      accountNumberNew      int
	     Outputs	: NONE
	     Returns	: Nothing
        */
        public Account(string accountTypeNew, decimal currentBalanceNew, int accountNumberNew)
        {
            AccountType = accountTypeNew;
            CurrentBalance = currentBalanceNew;
            AccountNumber = accountNumberNew;
        }

        /*  -- Method Header Comment
	    Name	: AccountType
	    Purpose : this property will return and set the data member (accountType).
	    Inputs	:	NONE
	    Outputs	:	NONE
	    Returns	:	string
        */
        public string AccountType
        {
            get { return accountType; }
            set 
            { 
                // Check if the account type matches the accounts type bellow
                if(value == "SavingsAccount" || value == "ChequingAccount" || value == "LoanAccount" )
                {
                    accountType = value;
                }
                // If it is not, then set the account type is unknown
                else
                {
                    accountType = "Unknown";
                }
            }
        }

        /*  -- Method Header Comment
	    Name	: CurrentBalance
	    Purpose : this property will return and set the data member (currentBalance).
	    Inputs	:	NONE
	    Outputs	:	NONE
	    Returns	:	decimal
        */
        public decimal CurrentBalance
        {
            get { return currentBalance; }
            set
            {
                // If the value is larger than 0, then set currentBalance to zero
                if (value > 0)
                {
                    currentBalance = value;
                }
                else
                {
                    currentBalance = 0;
                }
             }  
        }

        /*  -- Method Header Comment
	    Name	: AccountNumber
	    Purpose : this property will return and set the data member (accountNumber).
	    Inputs	:	NONE
	    Outputs	:	NONE
	    Returns	:	int
        */
        public int AccountNumber
        {
            get { return accountNumber; }
            set
            {
                // If the value is larger than 0, then set accountNumber to zero
                if (value > 0)
                {
                    accountNumber = value;
                }
                else
                {
                    accountNumber = 0;
                }

            }
        }

        /*  -- Method Header Comment
	    Name	:   Deposit
	    Purpose :   this property will add the amount of money to the current ballance of the bank account, if
        it fails, it will display an error message.
	    Inputs	:	amount  decimal
	    Outputs	:	a message indicating an error
	    Returns	:	void
        */
        public virtual void Deposit(decimal amount)
        {
            // Check if the ammount of money is larger than zero
            if(amount > 0)
            {
                CurrentBalance += amount;
            }
            else
            {
                Console.WriteLine("Deposit transaction must be greater than zero");
            }
        }

        /*  -- Method Header Comment
	    Name	:   Withdraw
	    Purpose :   this property will subtract the amount of money to the current ballance of the bank account, if
        it fails, it will display an error message.
	    Inputs	:	amount  decimal
	    Outputs	:	a message indicating an error
	    Returns	:	bool - true if it successes, otherwise false
        */
        public virtual bool Withdraw(decimal amount)
        {
            // Check if the ammount of money is larger than zero
            if (CurrentBalance - amount >= 0)
            {
                currentBalance -= amount;
                return true;

            }
            else
            {
                Console.WriteLine("Withdraw transaction exceeded account banlance");
                return false;
            }
        }

        /*  -- Method Header Comment
	    Name	:   PrintAccount
	    Purpose :   this property will display all the account's information
	    Inputs	:	NONE
	    Outputs	:	all the data members
	    Returns	:	NONE
        */
        public virtual void PrintAccount()
        {
            Console.WriteLine("Account Type: " + AccountType);
            Console.WriteLine("Account Number: " + AccountNumber.ToString());
            Console.WriteLine("Balance: $" + CurrentBalance.ToString("#,###.00") + "\n");
        }


    }
}
