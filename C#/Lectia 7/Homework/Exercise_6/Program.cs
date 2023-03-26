namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a class called "BankAccount" that has a string variable "accountNumber",
            // a double variable "balance", and methods "deposit" and "withdraw" that update
            // the balance of the account.

            BankAccount account = new BankAccount();
            Console.Write("Enter your account's number:");
            string accountNumber = Console.ReadLine();
            account.setAccountNumber(accountNumber);

            Console.Write("Enter the initial balance of your account(in $):");
            double balance = Convert.ToDouble(Console.ReadLine());  
            account.setBalance(balance);

            Console.Write("Enter the number of $ you want to deposit: ");
            int deposit = Convert.ToInt32(Console.ReadLine());
            account.deposit(deposit);

            Console.Write("Enter the number of $ you want to withdraw: ");
            int withdraw = Convert.ToInt32(Console.ReadLine());
            account.withdraw(withdraw);

            Console.WriteLine($"After these 2 transactions your account's balance is: {account.getBalance()}$");
        }
    }
}