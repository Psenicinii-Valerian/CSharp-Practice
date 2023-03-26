using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    internal class BankAccount
    {
        string accountNumber;
        double balance;

        public BankAccount()
        {

        }

        public void setAccountNumber(string accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public void setBalance(double balance)
        {
            this.balance = balance;
        }

        public string getAccountNumber() 
        {
            return this.accountNumber;  
        }

        public double getBalance() 
        { 
            return this.balance;
        }

        public void deposit(int deposit)
        {
            this.balance += deposit;
        }

        public void withdraw(int withdraw)
        {
            this.balance -= withdraw;
        }

    }



}
