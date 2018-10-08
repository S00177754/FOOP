using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTesting
{
    class BankAccount
    {
        //Variables
        private int account_Number;
        public int accountNumber
        {
            get
            {
                return account_Number;
            }

            set
            {
                account_Number = value;
            }
        }

        private double account_Balance;
        public double accountBalance
        {
            get
            {
                return account_Balance;
            }

            set
            {
                account_Balance = value;
            }
        }

        private string account_Name;
        public string accountName
        {
            get
            {
                return account_Name;
            }

            set
            {
                account_Name = value;
            }
        }

    }
}
