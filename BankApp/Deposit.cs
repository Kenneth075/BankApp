using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Deposit
    {
        public void Deposits(Account account)
        {
            Console.WriteLine("Enter the amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());



            Console.WriteLine($"{account.Balance}");
            account.Balance += amount;
            Console.WriteLine("Deposit Successful!");
            Console.WriteLine($"{account.Balance}");



            account.Transaction.Add(new Transaction
            {
                Date = DateTime.Now,
                Description = "Deposit",
                Amount = amount,
                Balance = account.Balance
            });
        }
    }
}

