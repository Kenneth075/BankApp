using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class OpenAccount
    {
        public void CreateAccount(Bank bank)
        {
            Console.WriteLine("Enter your First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            Console.WriteLine("Enter 1 for Saving or 2 for Current");
            string accounttype = Console.ReadLine();
            Random random = new Random();
            string accountNumber = "";
            switch (accounttype)
            {
                case "1":
                    accounttype = "Savings";
                    accountNumber = "0" + random.Next().ToString().Substring(0, 9);
                    break;
                case "2":
                    accounttype = "Current";
                    accountNumber = "1" + random.Next().ToString().Substring(0, 9);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            Console.WriteLine("Make initial deposit");
            decimal amount = Convert.ToDecimal(Console.ReadLine());



            Account account = new Account
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password,
                AccountType = accounttype,
                AccountNumber = accountNumber,
                Balance = amount
            };



            bank.Addaccount(account);
            Console.WriteLine("Acccount created successfully");
            Console.WriteLine($"Your account number is {account.AccountNumber}");



            account.Transaction.Add(new Transaction
            {
                Date = DateTime.Now,
                Description = "Initial Deposit",
                Amount = amount,
                Balance = account.Balance
            });

            

            

        }
    }
}

