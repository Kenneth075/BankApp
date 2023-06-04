using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Bank
    {
        private List<Account> accounts { get; set; }
        public Bank()
        {
            accounts = new List<Account>();
        }
        public List<Account> GetAccounts()
        {
            return accounts;
        }
        public void Addaccount(Account account)
        {
            accounts.Add(account);
        }
    }
}
