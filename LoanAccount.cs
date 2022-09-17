/*
 * FILE:        LoanAccount.cs
 * Project:	    A01 – C# AND OBJECT-ORIENTED PROGRAMMING
 * Author:	    Hoang Phuc Tran
 * Student ID:  8789102
 * Date:		September 16, 2022
 * Description: This file contains an LoanAccount class and its properties which is inherited from the Account classes
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01
{
    /*CLASS NAME:  LoanAccount
    * PURPOSE : The LoanAccount class is inherited from the Account classes. It has properties 
    * to calculate the annual free and display all information about the account)
    */
    internal class LoanAccount : Account
    {
        private decimal loanInterestRate;
        private decimal loanAmount;

        /*  -- Method Header Comment
        Name	: LoanAccount -- CONSTRUCTOR
        Purpose : to instantiate a new LoanAccount object - given a set of attribute values
        Inputs	: NONE
        Outputs	: NONE
        Returns	: Nothing
        */
        public LoanAccount() : base()
        {
            loanInterestRate = 0;
        }

        /*  -- Method Header Comment
        Name	: LoanAccount -- CONSTRUCTOR
        Purpose : to instantiate a new LoanAccount object - given a set of attribute values
        Inputs	: NONE
        Outputs	: NONE
        Returns	: Nothing
        */
        public LoanAccount(string accountName, decimal currentBalance, int accountNumber, decimal loanInterestRateNew) : base(accountName, currentBalance, accountNumber)
        {
            LoanInterestRate = loanInterestRateNew;
            LoanAmount = currentBalance;
        }

        /*  -- Method Header Comment
	    Name	: LoanInterestRate
	    Purpose : this property will return and set the data member (loanInterestRate).
	    Inputs	:	NONE
	    Outputs	:	NONE
	    Returns	:	decimal
        */
        public decimal LoanInterestRate
        {
            get { return loanInterestRate; }
            set
            {
                // If the value is larger than 0, then set loanInterestRate to zero
                if (value > 0)
                {
                    loanInterestRate = value;
                }
                else
                {
                    loanInterestRate = 0;
                }
            }
        }

        /*  -- Method Header Comment
	    Name	: LoanAmount
	    Purpose : this property will return and set the data member (loanAmount).
	    Inputs	:	NONE
	    Outputs	:	NONE
	    Returns	:	decimal
        */
        public decimal LoanAmount
        {
            get { return loanAmount; }
            set { loanAmount = value; }
        }

        /*  -- Method Header Comment
       Name	    :   CalculateInterestLoan
       Purpose  :   this property will calculate the loan interest
       Inputs	:	NONE
       Outputs	:	NONE
       Returns	:	decimal
       */
        public decimal CalculateInterestLoan()
        {
            decimal result = 0;

            result = (LoanAmount * LoanInterestRate) / 12;

            return result;
        }

        /*  -- Method Header Comment
	    Name	:   Deposit
	    Purpose :   this property will subtract the amount of money that is doposited and then add the loan interest to the current ballance, if
        it fails, it will display an error message.
	    Inputs	:	amount  decimal
	    Outputs	:	a message indicating an error
	    Returns	:	void
        */
        public override void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                decimal interestMonthly = CalculateInterestLoan();

                LoanAmount = LoanAmount - amount + interestMonthly;
            }
            else
            {
                Console.WriteLine("Deposit transaction must be greater than zero");
            }
        }

        /*  -- Method Header Comment
       Name	:   Withdraw
       Purpose :   this property will subtract the amount of money to the current ballance of 
        the bank account(this is usually only done once when the loan is given out), if
        it fails, it will display an error message.
       Inputs	:	amount  decimal
       Outputs	:	a message indicating an error
       Returns	:	bool - true if it successes, otherwise false
       */
        public override bool Withdraw(decimal amount)
        {
            if(CurrentBalance == amount)
            {
                CurrentBalance = 0;
                Console.WriteLine("*Withdraw transaction successed!*");
                return true;
            }
            else
            {
                Console.WriteLine("You are not allowed to withdraw because the amount of the available loan: $" + CurrentBalance + "\n");
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
        public override void PrintAccount()
        {
            Console.WriteLine("Account Type: " + AccountType);
            Console.WriteLine("Account Number: " + AccountNumber.ToString());
            Console.WriteLine("Balance: $" + LoanAmount.ToString("#,###.00"));
            Console.WriteLine("Loan interest rate: " + LoanInterestRate.ToString() + "%\n");
        }
    }

}
