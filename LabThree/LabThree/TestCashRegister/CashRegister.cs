using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCashRegister
{
    class CashRegister
    {
        public decimal total = 0;
        public int quantity = 0;

        public void AddItem(decimal price)
        {
            total += price;
            quantity++;
        }
    }
}
