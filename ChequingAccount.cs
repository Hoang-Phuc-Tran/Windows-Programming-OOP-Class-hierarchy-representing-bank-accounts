/*
 * FILE:        ChequingAccount.cs
 * Project:	    A01 – C# AND OBJECT-ORIENTED PROGRAMMING
 * Author:	    Hoang Phuc Tran
 * Student ID:  8789102
 * Date:		September 16, 2022
 * Description: This file contains an ChequingAccount class and its properties which is inherited from the Account classes
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace A01
{
    /*CLASS NAME:  SavingsAccount
    * PURPOSE : The ChequingAccount class is inherited from the Account classes. It has properties 
    * to calculate the annual free and display all information about the account)
    */
    internal class ChequingAccount : Account
    {
        private decimal annualFree;         // Holds the decimal of the interest rate` of the bank account

        /*  -- Method Header Comment
        Name	: ChequingAccount -- CONSTRUCTOR
        Purpose : to instantiate a new ChequingAccount object - given a set of attribute values
        Inputs	: NONE
        Outputs	: NONE
        Returns	: Nothing
        */
        public ChequingAccount() : base()
        {
            annualFree = 0;
        }

        /*  -- Method Header Comment
        Name	: ChequingAccount -- CONSTRUCTOR
        Purpose : to instantiate a new ChequingAccount object - given a set of attribute values
        Inputs	: NONE
        Outputs	: NONE
        Returns	: Nothing
        */
        public ChequingAccount(string accountName, decimal currentBalance, int accountNumber, decimal annualFreeNew) : base(accountName, currentBalance, accountNumber)
        {
            AnnualFree = annualFreeNew;
        }

        /*  -- Method Header Comment
	    Name	: InterestRate
	    Purpose : this property will return and set the data member (annualFree).
	    Inputs	:	NONE
	    Outputs	:	NONE
	    Returns	:	decimal
        */
        public decimal AnnualFree
        {
            get { return annualFree; }
            set 
            {
                // If the value is larger than 0, then set annualFree to zero
                if (value > 0)
                {
                    annualFree = value;
                }
                else
                {
                    annualFree = 0;
                }
            }
        }

        /*  -- Method Header Comment
       Name	    :   ApplyAnnualFree
       Purpose  :   this property will calculate the annual free of the account's current balance
       Inputs	:	NONE
       Outputs	:	NONE
       Returns	:	decimal
       */
        public void ApplyAnnualFree()
        {
            CurrentBalance -= AnnualFree ;
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
            Console.WriteLine("Annual Free: $" + AnnualFree.ToString() + "\n");
        }

    }

}
