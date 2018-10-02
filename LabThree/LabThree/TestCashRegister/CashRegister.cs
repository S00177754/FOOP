﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCashRegister
{
    class CashRegister
    {
        private readonly decimal total = 0;
        private readonly int quantity = 0;

        public CashRegister(decimal price,string name)
        {
            total += price;
            quantity++;
            Console.WriteLine($"Adding an item worth {price} to {name}");
        }

        public void Display(string name)
        {
            Console.WriteLine($"Cash Register {name} Total: {total}");
            Console.WriteLine($"Cash Register {name} Number of Items: {quantity}");
        }

       

        
    }
}
