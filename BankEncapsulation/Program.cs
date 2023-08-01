using System.Dynamic;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Account = new BankAccount();

            var Accountbalance = Account.GetBalance();

            Console.WriteLine($"Your current balance is {Accountbalance}");

            Console.WriteLine("How much would you like to add?");


            Account.Deposit(double.Parse(Console.ReadLine()));

            Accountbalance = Account.GetBalance();

            Console.WriteLine($"Your new balance is {Accountbalance}");


        }
    }
}
