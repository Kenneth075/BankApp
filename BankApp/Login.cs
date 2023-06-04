using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Login
    {
        public void Log(Bank bank)
        {
            Console.WriteLine("Enter your Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your Password");
            string password = Console.ReadLine();



            Account account = bank.GetAccounts().Find(x => x.Email == email && x.Password == password);



            if (account != null)
            {
                Console.WriteLine("Login Successful");
                string choice;
                do
                {
                    BankOperationMenu();
                    Console.WriteLine("Enter your choice");
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            Deposit deposit = new Deposit();
                            deposit.Deposits(account);
                            break;
                        case "2":
                            Withdraw withdraw = new Withdraw();
                            withdraw.withdrawal(account);
                            break;
                        case "3":
                            Transfer transfer = new Transfer();
                            transfer.Transfers(account, bank);
                            break;
                        case "4":
                            Balance checkbalance = new Balance();
                            checkbalance.PrintBalance(account);
                            break;
                        case "5":
                            Balance accountdetails = new Balance();
                            accountdetails.AccountDetails(account);
                            break;
                        case "6":
                            Balance statement = new Balance();
                            statement.PrintStatement(account);
                            break;
                        case "7":
                            Console.WriteLine("Exit");
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;




                    }
                } while (choice != "7");

            }
            else
            {
                Console.WriteLine("Invalid Email or Password");
            }
        }



        public void BankOperationMenu()
        {
            string message = $"1. Deposit\n2. Withdrawal\n" +
                $"3. Transfer\n4.Check Balance\n5.Account Details\n6.Statement Of Account\n7. Exit";
            Console.WriteLine(message);
        }




    }
}

    
             