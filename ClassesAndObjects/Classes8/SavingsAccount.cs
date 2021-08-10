using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes8
{
    public class SavingsAccount
    {
        private double annualInterestRate, balance, accumulativeInterest, accumulativeDeposits = 0, accumulativeWithdrawals = 0;

        public SavingsAccount(double b)
        {
            balance = b;
        }

        public void Withdraw(double w)
        {
            balance -= w;
            accumulativeWithdrawals += w;
        }

        public void Deposit(double d)
        {
            balance += d;
            accumulativeDeposits += d;
        }

        public void AddMonthlyInterest()
        {
            accumulativeInterest += balance * (annualInterestRate / 12);
            balance += balance * (annualInterestRate / 12);
        }

        public void SetBalance(double b)
        {
            balance = b;
        }

        public void SetAnnualInterestRate(double air)
        {
            annualInterestRate = air;
        }

        public double GetBalance()
        {
            return balance;
        }

        public double GetAnnualInterestRate()
        {
            return annualInterestRate;
        }

        public double GetMonthlyInterest()
        {
            return balance * (annualInterestRate / 12);
        }

        public double GetAccumulativeInterest()
        {
            return accumulativeInterest;
        }

        public double GetAccumulativeDeposits()
        {
            return accumulativeDeposits;
        }

        public double GetAccumulativeWithdrawals()
        {
            return accumulativeWithdrawals;
        }
    }
}


