﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSix
{
    class Bill
    {
        public string Name { get; private set; }
        public decimal Amount { get; private set; }

        public Bill() : this("Unknown", 0.0m)
        {
        }

        public Bill(string name,decimal amount)
        {
            Name = name;
            Amount = amount;
        }

        public override string ToString()
        {
            return string.Format($"Name:{Name}  Amount:{Amount} Type:{GetType().Name}");
        }
    }

    class OverdueBill: Bill
    {
        public int Days { get; set; }

        public OverdueBill(string name,decimal amount,int daysOverdue): base(name, amount)
        {
            Days = daysOverdue;
        }

        public override string ToString()
        {
            return base.ToString() + $"  Days Overdue:{Days}";
        }
    }
}
