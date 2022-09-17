/*
 * FILE:        SavingsAccount.cs
 * Project:	    A01 – C# AND OBJECT-ORIENTED PROGRAMMING
 * Author:	    Hoang Phuc Tran
 * Student ID:  8789102
 * Date:		September 16, 2022
 * Description: This file contains an SavingsAccount class and its properties which is inherited from the Account classes
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace A01
{
    /*CLASS NAME:  SavingsAccount
    * PURPOSE : The SavingsAccount class is inherited from the Account classes. It has properties 
    * to calculate the interest rate and display all information about the account)
    */
    class SavingsAccount : Account
    {
        private decimal interestRate;       // Holds the decimal of the interest rate` of the bank account

        /*  -- Method Header Comment
        Name	: SavingsAccount -- CONSTRUCTOR
        Purpose : to instantiate a new SavingsAccount object - given a set of attribute values
        Inputs	: NONE
        Outputs	: NONE
        Returns	: Nothing
        */
        public SavingsAccount() : base() 
        {
            interestRate = 0;
        }

        /*  -- Method Header Comment
        Name	: SavingsAccount -- CONSTRUCTOR
        Purpose : to instantiate a new SavingsAccount object - given a set of attribute values
        Inputs	: NONE
        Outputs	: NONE
        Returns	: Nothing
        */
        public SavingsAccount(string accountName, decimal currentBalance, int accountNumber, decimal interestRateNew) : base(accountName, currentBalance, accountNumber)
        {
            InterestRate = interestRateNew;
        }

        /*  -- Method Header Comment
	    Name	: InterestRate
	    Purpose : this property will return and set the data member (interestRate).
	    Inputs	:	NONE
	    Outputs	:	NONE
	    Returns	:	decimal
        */
        public decimal InterestRate
        {
            get { return interestRate; }
            set 
            {
                // If the value is larger than 0, then set interestRate to zero
                if (value > 0)
                {
                    interestRate = value;
                }
                else
                {
                    interestRate = 0;
                }
            }
        }

        /*  -- Method Header Comment
	    Name	:   ApplyInterestRate
	    Purpose :   this property will calculate the interest rate of the account's current balance
	    Inputs	:	NONE
	    Outputs	:	NONE
	    Returns	:	decimal
        */
        public decimal ApplyInterestRate()
        {
            decimal result = 0;

            result = (InterestRate / 100) * CurrentBalance;

            return result;
        }

        /*  -- Method Header Comment
	    Name	:   PrintAccount
	    Purpose :   this property will display all the account's information
	    Inputs	:	NONE
	    Outputs	:	all the data members
	    Returns	:	NONE
        */
        public override void PrintAccount()
        {
            Console.WriteLine("Account Type: " + AccountType);
            Console.WriteLine("Account Number: " + AccountNumber.ToString());
            Console.WriteLine("Balance: $" + CurrentBalance.ToString("#,###.00"));
            Console.WriteLine("Interest Rate: " + InterestRate.ToString() + "%\n");
        }

    }
}
