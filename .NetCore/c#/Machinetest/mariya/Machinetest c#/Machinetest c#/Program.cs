namespace Machinetest_c_
{
    struct Account {
        public int AccountNumber;
        public string HolderName;
        public double Balance;
 }

    internal class Program
    {
        static void Main(string[] args)
        {
           
            Account[]accounts=new Account[4];

            
            for (int i = 0; i < accounts.Length; i++)
            {
                Console.WriteLine($"\nEnter details for Account {i + 1}");

                Console.Write("Account Number: ");
                accounts[i].AccountNumber = int.Parse(Console.ReadLine());

                Console.Write("Holder Name: ");
                accounts[i].HolderName = Console.ReadLine();

                Console.Write("Balance: ");
                accounts[i].Balance = double.Parse(Console.ReadLine());
            }

            

            Console.Write("/nEnter Account Number to search:");
            int searchAccNo=int .Parse(Console.ReadLine());

            bool found=false;

            foreach (var acc in accounts)
            {
                if (acc.AccountNumber == searchAccNo) ;
                {
                    Console.WriteLine("\nAccount Found!");
                    Console.WriteLine($"Account Number: {acc.AccountNumber}");
                    Console.WriteLine($"HolderName: {acc.HolderName}");
                    Console.WriteLine($"Balance{acc.Balance}");

                    found = true;
                    break;
                }
            }
            
            if (!found) {
                Console.WriteLine("Account not found!");
            }
            
        }
    }
}
