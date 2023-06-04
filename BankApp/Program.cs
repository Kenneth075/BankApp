using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            string choice;
            do
            {
                Console.WriteLine("1. Create Account\n2. Login\n3. Exit");
                Console.WriteLine("Enter your choice");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        OpenAccount openAccount = new OpenAccount();
                        openAccount.CreateAccount(bank);
                        break;
                    case "2":
                        Login login = new Login();
                        login.Log(bank);
                        break;
                    case "3":
                        Console.WriteLine("Exit..");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                //choice = Console.ReadLine();
            } while (choice != "3");




        }



    }
}

