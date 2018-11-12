using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill bill = new Bill("Ronan",24.20m);
            OverdueBill overdueBill = new OverdueBill("Ben",100.46m,12);

            Console.WriteLine(bill.ToString());
            Console.WriteLine(overdueBill.ToString());

            Console.ReadKey();
        }
    }
}
