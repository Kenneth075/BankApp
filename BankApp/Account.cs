using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Account:Customer
    {
        public string AccountType { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public List<Transaction> Transaction { get; set; }

        public Account()
        {
            Transaction = new List<Transaction>();
        }
        
    }
}
