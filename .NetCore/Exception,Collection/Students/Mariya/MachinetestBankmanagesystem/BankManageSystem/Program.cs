using BankManageSystem.Managers;
using BankManageSystem.Models;
using BankManageSystem.Repository;
using BankManageSystem.Enums;

namespace BankManageSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankRepository repository = new BankRepository();

            BankManager manager = new BankManager(repository);

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n===== BANK MANAGEMENT SYSTEM =====");

                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Remove Account");
                Console.WriteLine("3. Deposit Money");
                Console.WriteLine("4. Withdraw Money");
                Console.WriteLine("5. Check Balance");
                Console.WriteLine("6. Display All Accounts");
                Console.WriteLine("7. Exit");

                Console.Write("Enter your choice: ");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:

                            Console.Write("Enter Account Number: ");
                            int accNo = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Account Holder Name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter Initial Balance: ");
                            decimal balance = Convert.ToDecimal(Console.ReadLine());


                            Console.Write("Enter Account Type (Savings/Current): ");

                            AccountType type
                                = (AccountType)Convert.ToInt32(Console.ReadLine());


                            BankAccount account =
                                new BankAccount(
                                    accNo,
                                    name,
                                    balance,
                                    type
                                    

                                    );

                              manager.CreateAccount(account);


                            

                            break;

                        case 2:

                            Console.Write("Enter Account Number: ");
                            int removeNo =
                                Convert.ToInt32(Console.ReadLine());

                            manager.DeleteAccount(removeNo);

                            break;

                        case 3:

                            Console.Write("Enter Account Number: ");
                            int depNo =
                                Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Deposit Amount: ");
                            decimal depAmount =
                                Convert.ToDecimal(Console.ReadLine());

                            manager.DepositMoney(depNo, depAmount);

                            break;

                        case 4:

                            Console.Write("Enter Account Number: ");
                            int witNo =
                                Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Withdrawal Amount: ");
                            decimal witAmount =
                                Convert.ToDecimal(Console.ReadLine());

                            manager.WithdrawMoney(witNo, witAmount);

                            break;

                        case 5:

                            Console.Write("Enter Account Number: ");
                            int balNo =
                                Convert.ToInt32(Console.ReadLine());

                            manager.CheckBalance(balNo);

                            break;

                        case 6:

                            manager.DisplayAllAccounts();

                            break;

                        case 7:

                            exit = true;

                            Console.WriteLine("Application Closed.");

                            break;

                        default:

                            Console.WriteLine("Invalid choice.");

                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unexpected Error: " + ex.Message);
                }
            }
        }
    }
}
        
    
    
    

