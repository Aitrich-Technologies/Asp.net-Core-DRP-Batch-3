
using System.Text.RegularExpressions;

namespace Exception_Handling
{
    //class User
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //    public string Phone { get; set; }
    //}
    class InvalidAmountException : Exception
    {
        public InvalidAmountException(string message) : base(message)
        {
        }
    }

    // Custom Exception for Insufficient Balance
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {
        }
    }

    // Abstract Base Class
    abstract class BankAccount
    {
        // Private fields
        private string accountNumber;
        private string accountHolderName;
        private decimal balance;

        // Properties (Encapsulation)
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string AccountHolderName
        {
            get { return accountHolderName; }
            set { accountHolderName = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        // Constructor
        public BankAccount(string accNo, string name, decimal bal)
        {
            AccountNumber = accNo;
            AccountHolderName = name;
            Balance = bal;
        }

        // Abstract Methods
        public abstract void Deposit(decimal amount);

        public abstract void Withdraw(decimal amount);

        // Concrete Method
        public void DisplayDetails()
        {
            Console.WriteLine("\nAccount Number : " + AccountNumber);
            Console.WriteLine("Account Holder : " + AccountHolderName);
            Console.WriteLine("Balance        : " + Balance);
        }
    }

    // Savings Account Class
    class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        decimal minimumBalance = 1000;

        public SavingsAccount(string accNo, string name,
            decimal bal, decimal interest)
            : base(accNo, name, bal)
        {
            InterestRate = interest;
        }

        public override void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidAmountException(
                    "Deposit amount must be greater than 0.");
            }

            Balance += amount;

            Console.WriteLine("Amount Deposited Successfully.");
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidAmountException(
                    "Withdrawal amount must be greater than 0.");
            }

            if (Balance - amount < minimumBalance)
            {
                throw new InsufficientBalanceException(
                    "Minimum balance of ₹1000 must be maintained.");
            }

            Balance -= amount;

            Console.WriteLine("Amount Withdrawn Successfully.");
        }
    }

    // Current Account Class
    class CurrentAccount : BankAccount
    {
        public decimal OverdraftLimit { get; set; }

        public CurrentAccount(string accNo, string name,
            decimal bal, decimal overdraft)
            : base(accNo, name, bal)
        {
            OverdraftLimit = overdraft;
        }

        public override void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidAmountException(
                    "Deposit amount must be greater than 0.");
            }

            Balance += amount;

            Console.WriteLine("Amount Deposited Successfully.");
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidAmountException(
                    "Withdrawal amount must be greater than 0.");
            }

            if (amount > Balance + OverdraftLimit)
            {
                throw new InsufficientBalanceException(
                    "Overdraft limit exceeded.");
            }

            Balance -= amount;

            Console.WriteLine("Amount Withdrawn Successfully.");
        }
    }

    internal class Program
    {
        //static List<User> users = new List<User>();
        static void Main(string[] args)
        //{
        //    try
        //    {
        //        int a = 10;
        //        int b = 0;
        //        int result = a / b;
        //    }
        //    catch (DivideByZeroException)
        //    {
        //        Console.WriteLine("Cannot divisible by zero");
        //    }
        //    finally 
        //    { 
        //        Console.WriteLine("Finally Block");
        //    }
        //}

        //{
        //    try
        //    {
        //        Console.WriteLine("enter number :");
        //        int a = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("enter another number :");
        //        int b = Convert.ToInt32(Console.ReadLine());
        //        int result = a / b;
        //    }
        //    catch (DivideByZeroException)
        //    {
        //        Console.WriteLine("Can't divisible by zero");
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Please enter number");
        //    }
        //    catch (OverflowException)
        //    {
        //        Console.WriteLine("Number Overflow");
        //    }
        //}

        //{
        //    int age = 15;
        //    try
        //    {
        //        if (age < 18)
        //        {
        //            throw new AgeException("Age must be 18 or above");
        //        }
        //        Console.WriteLine("Eligible");
        //    }
        //    catch (AgeException ex) 
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        //{
        //    List<User> users = new List<User>();
        //    try
        //    {
        //        User u = new User();
        //        Console.WriteLine("Enter id");
        //        u.Id =Convert.ToInt32( Console.ReadLine());
        //        Console.WriteLine("Enter name");
        //        u.Name = Console.ReadLine();
        //        Console.WriteLine("Enter email");
        //        u.Email = Console.ReadLine();
        //        Console.WriteLine("Enter phone");
        //        u.Phone = Convert.ToInt32(Console.ReadLine());

        //        users.Add(u);
        //    }
        //    catch ()
        //    }



        //{ 
        //        char choice;

        //        do
        //        {
        //            User user = new User();

        //            user.Id = GetValidId();
        //            user.Name = GetValidName();
        //            user.Email = GetValidEmail();
        //            user.Phone = GetValidPhone();

        //            users.Add(user);

        //            Console.WriteLine("\nUser Added Successfully!\n");

        //            DisplayUsers();

        //        Console.Write("Add another user? (y/n): ");
        //            choice = Convert.ToChar(Console.ReadLine());

        //        } while (choice == 'y' || choice == 'Y');
        //    }


        //    static int GetValidId()
        //    {
        //        while (true)
        //        {
        //            try
        //            {
        //                Console.Write("Enter ID: ");
        //                int id = Convert.ToInt32(Console.ReadLine());

        //                return id;
        //            }
        //            catch
        //            {
        //                Console.WriteLine("Invalid ID. Enter only integer value.");
        //            }
        //        }
        //    }


        //    static string GetValidName()
        //    {
        //        while (true)
        //        {
        //            try
        //            {
        //                Console.Write("Enter Name: ");
        //                string name = Console.ReadLine();

        //                if (Regex.IsMatch(name, @"\d"))
        //                {
        //                    throw new Exception("Name cannot contain numbers.");
        //                }

        //                return name;
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //            }
        //        }
        //    }


        //    static string GetValidEmail()
        //    {
        //        while (true)
        //        {
        //            try
        //            {
        //                Console.Write("Enter Email: ");
        //                string email = Console.ReadLine();

        //                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        //                if (!Regex.IsMatch(email, pattern))
        //                {
        //                    throw new Exception("Invalid Email Format.");
        //                }

        //                return email;
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //            }
        //        }
        //    }


        //    static string GetValidPhone()
        //    {
        //        while (true)
        //        {
        //            try
        //            {
        //                Console.Write("Enter Phone Number: ");
        //                string phone = Console.ReadLine();

        //                if (!Regex.IsMatch(phone, @"^\d{10}$"))
        //                {
        //                    throw new Exception("Phone number must contain exactly 10 digits.");
        //                }

        //                return phone;
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //            }
        //        }
        //    }


        //    static void DisplayUsers()
        //    {
        //        Console.WriteLine("----- User List -----");

        //        foreach (User u in users)
        //        {
        //            Console.WriteLine("ID    : " + u.Id);
        //            Console.WriteLine("Name  : " + u.Name);
        //            Console.WriteLine("Email : " + u.Email);
        //            Console.WriteLine("Phone : " + u.Phone);

        //            Console.WriteLine("----------------------");
        //        }
        //    }

        {
            List<BankAccount> accounts = new List<BankAccount>();

            int choice;

            do
            {
                Console.WriteLine("\n===== Banking System =====");
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

                        Console.WriteLine("\n1. Savings Account");
                        Console.WriteLine("2. Current Account");

                        Console.Write("Choose Account Type: ");
                        int type = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Account Number: ");
                        string accNo = Console.ReadLine();

                        Console.Write("Enter Holder Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Initial Balance: ");
                        decimal bal = Convert.ToDecimal(Console.ReadLine());

                        if (type == 1)
                        {
                            Console.Write("Enter Interest Rate: ");
                            decimal rate =
                                Convert.ToDecimal(Console.ReadLine());

                            accounts.Add(
                                new SavingsAccount(
                                    accNo, name, bal, rate));

                            Console.WriteLine(
                                "Savings Account Created.");
                        }
                        else if (type == 2)
                        {
                            Console.Write("Enter Overdraft Limit: ");
                            decimal limit =
                                Convert.ToDecimal(Console.ReadLine());

                            accounts.Add(
                                new CurrentAccount(
                                    accNo, name, bal, limit));

                            Console.WriteLine(
                                "Current Account Created.");
                        }

                        break;

                    case 2:

                        try
                        {
                            Console.Write("Enter Account Number: ");
                            string depositAcc =
                                Console.ReadLine();

                            Console.Write("Enter Amount: ");
                            decimal depAmt =
                                Convert.ToDecimal(Console.ReadLine());

                            foreach (BankAccount acc in accounts)
                            {
                                if (acc.AccountNumber == depositAcc)
                                {
                                    acc.Deposit(depAmt);

                                    // Polymorphism
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    case 3:

                        try
                        {
                            Console.Write("Enter Account Number: ");
                            string withdrawAcc =
                                Console.ReadLine();

                            Console.Write("Enter Amount: ");
                            decimal withAmt =
                                Convert.ToDecimal(Console.ReadLine());

                            foreach (BankAccount acc in accounts)
                            {
                                if (acc.AccountNumber == withdrawAcc)
                                {
                                    acc.Withdraw(withAmt);

                                    // Polymorphism
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    case 4:

                        Console.WriteLine("\n===== Account Details =====");

                        foreach (BankAccount acc in accounts)
                        {
                            acc.DisplayDetails();

                            // Polymorphism
                        }

                        break;

                    case 5:

                        Console.WriteLine("Thank You!");
                        break;

                    default:

                        Console.WriteLine("Invalid Choice.");
                        break;
                }

            } while (choice != 5);
        }
    }
}
    


