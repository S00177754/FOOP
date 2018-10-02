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
            //Variables
            int cashRegisterChoice = 1;
            decimal priceInput = 0;

            CashRegister CR1 = new CashRegister();
            CashRegister CR2 = new CashRegister();

            //Process
            while (cashRegisterChoice == 1 || cashRegisterChoice == 2)
            {
                Console.WriteLine("Exit by entering a value other than 1 or 2.");
                Console.Write("Please choose a cash register: ");
                cashRegisterChoice = int.Parse(Console.ReadLine());

                if(cashRegisterChoice == 1 || cashRegisterChoice == 2)
                {
                    Console.Write("Please enter amount: ");
                    priceInput = decimal.Parse(Console.ReadLine());

                }

                switch (cashRegisterChoice)
                {
                    case 1:
                        CR1.AddItem(priceInput);
                        break;

                    case 2:
                        CR2.AddItem(priceInput);
                        break;

                    default:
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Cash Register 1:");
            Console.WriteLine($"Total: {CR1.Total}  Number of Items:{CR1.Quantity}");

            Console.WriteLine();

            Console.WriteLine("Cash Register 1:");
            Console.WriteLine($"Total: {CR2.Total}  Number of Items:{CR2.Quantity}");

            Console.ReadKey();

        }
    }
}
