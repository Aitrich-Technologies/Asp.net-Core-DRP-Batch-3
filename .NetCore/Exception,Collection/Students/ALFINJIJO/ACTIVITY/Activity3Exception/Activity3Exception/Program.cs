namespace Activity3Exception
{
    internal class Program
    {
        static List<BankAccount> accounts = new List<BankAccount>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("----- Banking System -----");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Display Accounts");
                Console.WriteLine("5. Exit");

                Console.Write("Enter choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateAccount();
                        break;

                    case 2:
                        DepositAmount();
                        break;

                    case 3:
                        WithdrawAmount();
                        break;

                    case 4:
                        DisplayAccounts();
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void CreateAccount()
        {
            Console.WriteLine("1. Savings Account");
            Console.WriteLine("2. Current Account");

            Console.Write("Choose account type: ");
            int type = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Account Number: ");
            string accNo = Console.ReadLine();

            Console.Write("Enter Holder Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Initial Balance: ");
            decimal balance = Convert.ToDecimal(Console.ReadLine());

            if (type == 1)
            {
                Console.Write("Enter Interest Rate: ");
                decimal rate = Convert.ToDecimal(Console.ReadLine());

                accounts.Add(new SavingsAccount(accNo, name, balance, rate));
            }
            else if (type == 2)
            {
                Console.Write("Enter Overdraft Limit: ");
                decimal limit = Convert.ToDecimal(Console.ReadLine());

                accounts.Add(new CurrentAccount(accNo, name, balance, limit));
            }

            Console.WriteLine("Account created successfully.");
        }

        static BankAccount FindAccount(string accNo)
        {
            return accounts.FirstOrDefault(a => a.AccountNumber == accNo);
        }

        static void DepositAmount()
        {
            try
            {
                Console.Write("Enter Account Number: ");
                string accNo = Console.ReadLine();

                BankAccount account = FindAccount(accNo);

                if (account == null)
                {
                    Console.WriteLine("Account not found.");
                    return;
                }

                Console.Write("Enter Deposit Amount: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());

                account.Deposit(amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void WithdrawAmount()
        {
            try
            {
                Console.Write("Enter Account Number: ");
                string accNo = Console.ReadLine();

                BankAccount account = FindAccount(accNo);

                if (account == null)
                {
                    Console.WriteLine("Account is not founded.");
                    return;
                }

                Console.Write("Enter Withdraw Amount: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());

                account.Withdraw(amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void DisplayAccounts()
        {
            foreach (BankAccount account in accounts)
            {
                account.DisplayDetails();
            }
        }

       
        
    
        abstract class BankAccount
        {
            private string accountNumber;
            private string accountHolderName;
            private decimal balance;

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

            public BankAccount(string accNo, string holderName, decimal balance)
            {
                AccountNumber = accNo;
                AccountHolderName = holderName;
                Balance = balance;
            }

            public abstract void Deposit(decimal amount);
            public abstract void Withdraw(decimal amount);

            public void DisplayDetails()
            {
                Console.WriteLine("\n--- Account Details ---");
                Console.WriteLine("Account Number: " + AccountNumber);
                Console.WriteLine("Holder Name: " + AccountHolderName);
                Console.WriteLine("Balance: ₹" + Balance);
            }
        }

      
        class SavingsAccount : BankAccount
        {
            public decimal InterestRate { get; set; }
            private decimal minimumBalance = 1000;

            public SavingsAccount(string accNo, string holderName, decimal balance, decimal interestRate)
                : base(accNo, holderName, balance)
            {
                InterestRate = interestRate;
            }

            public override void Deposit(decimal amount)
            {
                if (amount <= 0)
                    throw new InvalidAmountException("Deposit amount must be positive.");

                Balance += amount;
                Console.WriteLine("Deposit successfull.");
            }

            public override void Withdraw(decimal amount)
            {
                if (amount <= 0)
                    throw new InvalidAmountException("Withdrawal amount must be positive.");

                if (Balance - amount < minimumBalance)
                    throw new InsufficientBalanceException("Minimum balance ₹1000 should be maintained.");

                Balance -= amount;
                Console.WriteLine("Withdrawal successful.");
            }
        }

      
        class CurrentAccount : BankAccount
        {
            public decimal OverdraftLimit { get; set; }

            public CurrentAccount(string accNo, string holderName, decimal balance, decimal overdraftLimit)
                : base(accNo, holderName, balance)
            {
                OverdraftLimit = overdraftLimit;
            }

            public override void Deposit(decimal amount)
            {
                if (amount <= 0)
                    throw new InvalidAmountException("Deposit amount must be positive.");

                Balance += amount;
                Console.WriteLine("Deposit successful.");
            }

            public override void Withdraw(decimal amount)
            {
                if (amount <= 0)
                    throw new InvalidAmountException("Withdrawal amount must be positive.");

                if (Balance + OverdraftLimit < amount)
                    throw new InsufficientBalanceException("Overdraft limit exceeded.");

                Balance -= amount;
                Console.WriteLine("Withdrawal successful.");
            }
        }



    }
}


    

