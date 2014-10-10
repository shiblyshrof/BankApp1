using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Account
    {
        public string Number { set; get; }
        public string OpeningDate { set; get; }
        public double Balance {  private set; get; }

        public Account(string number,string openingdate)
        {
            OpeningDate = openingdate;
            Number = number;
        }

        public Account ()
        {
            Balance = 0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;

        }

        public void Withdraw(double amount)
        {

            Balance -= amount;
        }
    }
}
