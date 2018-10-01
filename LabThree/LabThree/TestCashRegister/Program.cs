using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCashRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister CR1 = new CashRegister();
            CR1.AddItem(2.70m);
            Console.WriteLine($"Adding item worth {2.70} to ");

            Console.ReadKey();
        }
    }
}
