using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulationExcersize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();

            bool deposit = false;
            bool getBalance = false;

            do
            {
                Console.WriteLine("Would you like to deposit money?");
                string response = Console.ReadLine().ToLower();
                if (response.Equals("yes"))
                {
                    Console.WriteLine("You entered yes");
                    Console.WriteLine("How much would you like to deposit?");
                    double amount = double.Parse(Console.ReadLine());
                    bankAccount.Deposit(amount);
                    deposit = true;
                }
                else
                {
                    Console.WriteLine("Ending Transaction");
                    deposit = true;
                }
            } while (deposit == false) ;

            do
            {
                Console.WriteLine("Would you like to see you balance?");
                string response = Console.ReadLine().ToLower();
                if (response.Equals("yes"))
                {
                    Console.WriteLine(bankAccount.GetBalance());
                    getBalance = true;
                }
                else
                {
                    Console.WriteLine("Ending Transaction");
                    getBalance = true;
                }
            } while (getBalance == false);

            Console.ReadLine();

        }
    }
}
