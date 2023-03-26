using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supraincarcarea_constructorilor
{
    internal class BankAccount
    {
        string name;
        double initialBalance;

        public BankAccount(string name, int initialBalance)
        {
            this.name = name;
            this.initialBalance = initialBalance;   
        }

        public BankAccount(string name, double initialBalance, bool foreignAccount)
        {
            this.name = name;

            if (foreignAccount)
            {        
                this.initialBalance = initialBalance / 19.37; // from lei to USD
            } else
            {
                this.initialBalance = initialBalance;
            }        
        }

        public void showBankAccount()
        {
            if (name != null) 
            { 
                Console.WriteLine($"Name: {name} ");
            } 
            
            if (initialBalance > 0)
            {
                Console.WriteLine($"Initial balance: {Math.Round(initialBalance,2)}$$ of initial balance");
            }
        }

    }
}
