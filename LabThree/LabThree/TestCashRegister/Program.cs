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
            CashRegister CR2 = new CashRegister();

            CR1.AddItem(2.70m,"Cash Register 1");
            CR1.AddItem(6.20m, "Cash Register 1");
            CR1.AddItem(12.90m, "Cash Register 1");
            CR1.AddItem(1.45m, "Cash Register 1");

            Console.WriteLine();

            CR2.AddItem(22.74m, "Cash Register 2");
            CR2.AddItem(4.56m, "Cash Register 2");
            CR2.AddItem(2.10m, "Cash Register 2");
            CR2.AddItem(7.72m, "Cash Register 2");

            Console.WriteLine();

            CR1.Display("CR1");
            CR2.Display("CR2");

            Console.ReadKey();
        }
    }
}
