namespace machinetestOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savings = new SavingsAccount();
            savings.Accountholder = "ALFIN";
            savings.Balance = 1000;
            Console.WriteLine("Savings Account Details");
            savings.DisplayDetails();
            savings.CalculateInterest();

            

            
            CurrentAccount current = new CurrentAccount();
            current.Accountholder = "alfin";
            current.Balance = 1000;
            Console.WriteLine("Current Account Details");
            current.DisplayDetails();
            current.CalculateInterest();
            current.ApplyMaintenanceFee();
        }
    }
}
