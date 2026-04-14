//namespace Sample
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            //int mark = 60;
//            //if (mark > 50) 
//            //{
//            //    Console.WriteLine("Pass");
//            //}
//            int num = 7;
//            if (num % 2 == 0)
//            {
//                Console.WriteLine("Even");
//            }
//            else if (num % 2 == 1)
//            {
//                Console.WriteLine("Odd");
//            }
//        }
//    }
//}


//namespace Sample
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            int mark = 85;
//            if (mark > 90)
//            {
//                Console.WriteLine("A");
//            }
//            else if (mark > 70)
//            {
//                Console.WriteLine("B");
//            }
//            else if (mark > 50)
//            {
//                Console.WriteLine("C");
//            }
//            else if (mark < 50)
//            {
//                Console.WriteLine("Fail");
//            }
//            else
//            {
//                Console.WriteLine("Invalid");
//            }
//        }
//    }
//}


//namespace Sample
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            int age = 20;
//            if (age >= 18)
//            {
//                Console.WriteLine("ELigible to vote");
//            }
//            else
//            {
//                Console.WriteLine("Not Eligible to vote");
//            }
//        }
//    }
//}



//namespace Sample
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int a = 10;
//            int b = 20;

//            if (a > b)
//            {
//                Console.WriteLine("a is larger");
//            }
//            else
//            {
//                Console.WriteLine("b is larger");
//            }

//        }
//    }
//}


namespace Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 10000;
            int result  = 0;
            String pin = "1010";
            Console.WriteLine("Enter ATM PIN");
            String c_pin = Console.ReadLine();
            if (c_pin == pin)
            {
                Console.Write("Enter amount to withdraw: ");
                double withdrawAmount = Convert.ToDouble(Console.ReadLine());

                if (withdrawAmount <= balance)
                {
                    balance -= withdrawAmount;
                    Console.WriteLine("Withdrawal successful!");
                    Console.WriteLine("Remaining Balance: " + balance);
                }
                else
                {
                    Console.WriteLine("Insufficient balance!");
                }
               
            }
            else
            {
                Console.WriteLine("Wrong pin");
            }
        }
    }
}




//namespace Sample
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            String password = "1234";
//            String username = "admin";

//            Console.WriteLine("Enter username ");
//            String c_username = Console.ReadLine();
//            Console.WriteLine("Enter password");
//            String c_password = Console.ReadLine();

//            if (username == c_username)
//            {
//                if (password == c_password)
//                {
//                    Console.WriteLine("Login Success");
//                }
//             else
//            {
//                Console.WriteLine("Invalid password");
//            }
//            }
//            else
//            {
//                Console.WriteLine("Invalid username");
//            }
//        }
//    }
//}



//namespace Sample
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int day = 3;
//            switch (day)
//            {
//                case 1:
//                    Console.WriteLine("Monday");
//                    break;
//                case 2:
//                    Console.WriteLine("Tuesday");
//                    break;
//                case 3:
//                    Console.WriteLine("Wednesday");
//                    break;
//                default:
//                    Console.WriteLine("Invalid day");
//                    break ;
//            }
//        }
//    }
//}


//namespace Sample
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("Enter light colour (Red,Yellow,Green)");
//            String action = Console.ReadLine();
//            switch (action)
//            {
//                case "Red":
//                    Console.WriteLine("Stop");
//                    break;
//                case "Yello":
//                    Console.WriteLine("Stop");
//                    break;
//                case "Green":
//                    Console.WriteLine("Stop");
//                    break;
//                default: Console.WriteLine("invalid color");
//                    break;
//            }
//        }
//    }
//}


//namespace Sample
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter first number:");
//            float num1 = float.Parse(Console.ReadLine());

//            Console.WriteLine("Enter second number:");
//            float num2 = float.Parse(Console.ReadLine());

//            Console.WriteLine("Enter operator (+, -, *, /):");
//            string op = Console.ReadLine();

//            float result = 0;

//            switch (op)
//            {
//                case "+":
//                    result = num1 + num2;
//                    break;
//                case "-":
//                    result = num1 - num2;
//                    break;
//                case "*":
//                    result = num1 * num2;
//                    break;
//                case "/":
//                    if (num2 != 0)
//                        result = num1 / num2;
//                    else
//                        Console.WriteLine("Cannot divide by zero.");
//                    break;
//                default:
//                    Console.WriteLine("Invalid operator.");
//                    break;
//            }

//            Console.WriteLine("Result: " + result);
//        }

//    }

//}


