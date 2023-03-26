using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Supraincarcarea_functiilor
{
    internal class BankAccount
    {
        public void deposit(int money)
        {
            Console.WriteLine($"You've deposited {money}$$");
        }

        public void deposit(double money, bool foreignCurrency)
        {
            if (foreignCurrency)
            {
                string currency;
                Console.WriteLine("What currency do you use?");
                currency = Convert.ToString(Console.ReadLine());

                Console.WriteLine($"Due to bank's conversion rate you'll be depositing {money * 0.9}{currency}");
            } else
            {
                Console.WriteLine($"You've deposited {money}$$");
            }
        }
    }
}
