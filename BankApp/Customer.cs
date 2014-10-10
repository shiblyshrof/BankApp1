using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Customer
    {
        public string CustomerName { set; get; }
        public string Email { set; get; }
        public Account Account1 { set; get; }

        public Customer(string customerName,string email)
        {
            CustomerName = customerName;
            Email = email;

        }

        public Customer()
        {

        }


    }
}
