using Exercise.Enum;
using Exercise.Interface;
using Exercise.Models;
using Exercise.Repository;
using Exercise.Manager;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBankRepository repository = new BankRepository();

            BankManager manager = new BankManager(repository);

            bool isRunning = true;

            while (isRunning)
            {
                
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Remove Account");
                Console.WriteLine("3. Deposit Money");
                Console.WriteLine("4. Withdraw Money");
                Console.WriteLine("5. Check Balance");
                Console.WriteLine("6. Display All Accounts");
                Console.WriteLine("7. Exit");

                Console.Write("Enter Choice : ");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:

                            Console.Write("Enter Account Number : ");
                            int accNo = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Holder Name : ");
                            string name = Console.ReadLine();

                            Console.WriteLine("1. Savings");
                            Console.WriteLine("2. Current");

                            Console.Write("Choose Account Type : ");
                            AccountType type = (AccountType)Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Initial Balance : ");

                            decimal balance = Convert.ToDecimal(Console.ReadLine());
                            BankAccount account = new BankAccount(accNo, name, type, balance);
                            manager.CreateAccount(account);
                            break;

                        case 2:

                            Console.Write("Enter Account Number : ");

                            int removeAcc = Convert.ToInt32(Console.ReadLine());
                            manager.DeleteAccount(removeAcc);
                            break;

                        case 3:

                            Console.Write("Enter Account Number : ");
                            int depositAcc = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Amount : ");

                            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                            manager.DepositMoney(depositAcc, depositAmount);
                            break;

                        case 4:

                            Console.Write("Enter Account Number : ");
                            int withdrawAcc = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Amount : ");
                            decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                            manager.WithdrawMoney(withdrawAcc, withdrawAmount);
                            break;

                        case 5:

                            Console.Write("Enter Account Number : ");
                            int checkAcc = Convert.ToInt32(Console.ReadLine());
                            manager.CheckBalance(checkAcc);
                            break;

                        case 6:
                            manager.DisplayAccounts();
                            break;

                        case 7:
                            isRunning = false;
                            break;

                        default:
                            Console.WriteLine("Invalid Choice.");
                            break;
                    }
                }
                catch (AccountNotFoundException ex)
                {
                    Console.WriteLine($"Error : {ex.Message}");
                }
                catch (InsufficientBalanceException ex)
                {
                    Console.WriteLine($"Error : {ex.Message}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input Format.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"System Error : {ex.Message}");
                }
            }
        }
    }
 }

