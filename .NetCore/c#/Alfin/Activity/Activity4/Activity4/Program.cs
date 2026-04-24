namespace Activity4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            ////1
            //int mark = 60;
            //if (mark > 50)
            //{
            //    Console.WriteLine("Pass");
            //}
            //else
            //{
            //    Console.WriteLine("Fail");


            //}
            //2
            int num = 7;
            if (num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            //3
            int mark = 85;
            if (mark >= 90)
            {
                Console.WriteLine("A");
            }
            if (mark >= 70)
            {
                Console.WriteLine("B");
            }
            if (mark >= 50)
            {
                Console.WriteLine("c");
            }
            else
            {
                Console.WriteLine("fail");
            }
            //4

            int age = 20;
            if (age >= 18)
            {
                Console.WriteLine("eligible");
            }
            else
            {
                Console.WriteLine("not eligible");
            }
            //5
            int A = 10;
            int B = 20;
            if (A > B)
            {
                Console.WriteLine("A is larger");
            }
            else
            {
                Console.WriteLine("B is larger");
            }
            //6
            string username = "admin";
            int password = 1234;
            if (username == "admin")
            {
                if (password == 1234)
                {
                    Console.WriteLine("login success");
                }

                else
                {
                    Console.WriteLine("wrong username");
                }
            }
            else
            {
                Console.WriteLine("wrong password");
            }
            //7
            int pin = 1234;
            int enteredPin = 1234;
            int balance = 5000;
            int withdrawAmount = 2000;

            if (enteredPin == pin)
            {
                if (balance > withdrawAmount)
                {
                    Console.WriteLine("Transaction Successful");
                    balance -= withdrawAmount;
                    Console.WriteLine("Remaining Balance: " + balance);
                }
                else
                {
                    Console.WriteLine("Insufficient Balance");
                }
            }
            else
            {
                Console.WriteLine("Wrong PIN");
            }
            //8
            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("monday 1");
                    break;
                case 2:
                    Console.WriteLine("tuesday 2");
                    break;
                case 3:
                    Console.WriteLine("wednesday 3");
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;

            }
            //9
            int a = 10;
            int b = 5;
            int choice = 1;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("add:" + (a + b));
                    break;
                case 2:
                    Console.WriteLine("subtraction: " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("multiply:" + (a * b));
                    break;
                case 4:
                    Console.WriteLine("divide:" + +(a / b));
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;

            }
            //10
            string signal = "red";
            switch (signal)
            {
                case "red":
                    Console.WriteLine("stop");
                    break;
                case "yellow":
                    Console.WriteLine("wait");
                    break;
                case "green":
                    Console.WriteLine("go");
                    break;
                default:
                    Console.WriteLine("invalid signal");
                    break;
            }
        }
    }
}
