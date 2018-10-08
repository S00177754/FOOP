using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassTesting;

namespace ClassTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount BA1 = new BankAccount();

            BA1.accountNumber = 245006;
            Console.WriteLine(BA1.accountNumber);

            Console.ReadKey();
        }
    }
}
