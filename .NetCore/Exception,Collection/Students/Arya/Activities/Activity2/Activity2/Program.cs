using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<BankAccount> accounts = new List<BankAccount>();

            int choice = 0;

            while (choice != 5)
            {
                Console.WriteLine("\n===== BANKING SYSTEM =====");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Display Accounts");
                Console.WriteLine("5. Exit");
                Console.Write("Enter Choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Console.WriteLine("1. Savings Account");
                        Console.WriteLine("2. Current Account");
                        Console.Write("Choose Account Type: ");

                        int type = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Account Number: ");
                        string accNo = Console.ReadLine();

                        Console.Write("Enter Holder Name: ");
                        string holder = Console.ReadLine();

                        Console.Write("Enter Initial Balance: ");
                        decimal balance = Convert.ToDecimal(Console.ReadLine());

                        if (type == 1)
                        {
                            Console.Write("Enter Interest Rate: ");
                            decimal rate = Convert.ToDecimal(Console.ReadLine());

                            accounts.Add(new SavingsAccount(accNo, holder, balance, rate));

                            Console.WriteLine("Savings Account Created.");
                        }
                        else if (type == 2)
                        {
                            Console.Write("Enter Overdraft Limit: ");
                            decimal limit = Convert.ToDecimal(Console.ReadLine());

                            accounts.Add(new CurrentAccount(accNo, holder, balance, limit));

                            Console.WriteLine("Current Account Created.");
                        }

                        break;

                    case 2:

                        try
                        {
                            Console.Write("Enter Account Number: ");
                            string depAcc = Console.ReadLine();

                            Console.Write("Enter Amount: ");
                            decimal depAmount = Convert.ToDecimal(Console.ReadLine());

                            foreach (BankAccount acc in accounts)
                            {
                                if (acc.AccountNumber == depAcc)
                                {
                                    acc.Deposit(depAmount); // Polymorphism
                                }
                            }
                        }
                        catch (InvalidAmountException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    case 3:

                        try
                        {
                            Console.Write("Enter Account Number: ");
                            string withAcc = Console.ReadLine();

                            Console.Write("Enter Amount: ");
                            decimal withAmount = Convert.ToDecimal(Console.ReadLine());

                            foreach (BankAccount acc in accounts)
                            {
                                if (acc.AccountNumber == withAcc)
                                {
                                    acc.Withdraw(withAmount); // Polymorphism
                                }
                            }
                        }
                        catch (InvalidAmountException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (InsufficientBalanceException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    case 4:

                        foreach (BankAccount acc in accounts)
                        {
                            Console.WriteLine("\n-------------------");
                            acc.DisplayDetails();
                        }

                        break;

                    case 5:

                        Console.WriteLine("Thank You...");
                        break;

                    default:

                        Console.WriteLine("Invalid Choice.");
                        break;
                }
            }
        }
    }
    }

