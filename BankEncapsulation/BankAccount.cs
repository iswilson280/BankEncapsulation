using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
        private double balance = 0;

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public double getBalance()
        {
            return balance;
        }
    }
}

