using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Transfer
    {
        public void Transfers(Account account, Bank bank)
        {



            Console.WriteLine("Enter destination account number: ");
            string destinationAccountNumber = Console.ReadLine();



            Account destinationAccount = bank.GetAccounts().Find(x => x.AccountNumber == destinationAccountNumber);



            if (destinationAccount != null)
            {
                Console.WriteLine("Enter the amount: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());



                Console.WriteLine($"My Balance Before: {account.Balance}");
                Console.WriteLine($"Recipient Balance before: {destinationAccount.Balance}");
                account.Balance -= amount;
                destinationAccount.Balance += amount;
                Console.WriteLine("Transfer Successful!");
                Console.WriteLine($"My Balance After: {account.Balance}");
                Console.WriteLine($"Recipient Balance After: {destinationAccount.Balance}");



                account.Transaction.Add(new Transaction
                {
                    Date = DateTime.Now,
                    Description = $"Transfer To {destinationAccount.AccountNumber} ",
                    Amount = amount,
                    Balance = account.Balance
                });



                destinationAccount.Transaction.Add(new Transaction
                {
                    Date = DateTime.Now,
                    Description = $"Transfer from {account.AccountNumber} ",
                    Amount = amount,
                    Balance = account.Balance
                });
            }
            else
            {
                Console.WriteLine("Destination account Number not found");
            }




        }
    }
}


    

