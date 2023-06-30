namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.Deposit(1050.0);
            account.Deposit(8050.0);
            double currentBalance = account.getBalance();
            Console.WriteLine("Current balance: $" + currentBalance);
        }
    }
}
