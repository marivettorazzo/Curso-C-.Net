using contaBancáriaExcecoes146.Entities;
using System;
using System.Globalization;

namespace contaBancáriaExcecoes146
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bom dia!");
                Console.WriteLine("Enter account data ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string dataHolder = (Console.ReadLine());
                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine());
                Account account = new Account(number, dataHolder, balance);
                Console.WriteLine("For deposit type 1, for withdrawal type 2") ;
                int answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    Console.Write("Deposit value : ");
                    double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    account.Deposit(amount);
                }
                else if (answer == 2)
                {
                    Console.Write("Withdraw value : ");
                    double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    account.Withdraw(amount);
                }
                Console.WriteLine(account);
            }
            catch ( FormatException e)
            {
                Console.WriteLine("Format error"+ e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error "+ e.Message);
            }
            //marianavettorazzo@gmail.com
        }
    }
}
