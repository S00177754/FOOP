using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCashRegister
{
    class CashRegister
    {
        private decimal total;
        public decimal Total
        {
            get
            {
                return this.total;
            }
        }

        private int quantity = 0;
        public decimal Quantity
        {
            get
            {
                return this.quantity;
            }
        }

        public void AddItem(decimal price)
        {
            total += price;
            quantity++;

            Console.WriteLine($"Adding an item worth {price}.");
        }

        public void Display()
        {
            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Number of Items: {quantity}");
        }

    }
}
