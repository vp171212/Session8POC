using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AvoidMagicNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Balance");
            int balance=Convert.ToInt32(Console.ReadLine());
            
            CheckBalance(balance);
        }

        private static void CheckBalance(int balance)
        {
            int minBalance = 1000;
            if (balance >= minBalance)
                Console.WriteLine("You have enough balance");
            else
                Console.WriteLine("You balance is below minimum balance");
        }
    }
}
