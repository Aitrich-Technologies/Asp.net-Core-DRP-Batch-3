using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1

            //int mark = 60;
            //if (mark > 50)
            //{
            //    Console.WriteLine("pass");
            //}
            //else
            //{
            //    Console.WriteLine("fail");
            //}

            //2

            //int num = 7;
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("even");
            //}
            //else
            //{
            //    Console.WriteLine("odd");
            //}

            //3

            //int mark = 85;
            //if (mark >= 90)
            //{
            //    Console.WriteLine("Grade A");
            //}
            //else if (mark >= 70)
            //{
            //    Console.WriteLine("Grade B");
            //}
            //else if (mark >= 50)
            //{
            //    Console.WriteLine("Grade c");

            //}
            //else
            //{
            //    Console.WriteLine("fail");
            //}

            //4

            //int age = 20;
            //if (age > 18)
            //{
            //    Console.WriteLine("Eligible");

            //}
            //else
            //{
            //    Console.WriteLine("not eligible");
            //}

            //5
            //int a = 10;
            //int b = 20;
            //if (a > b)
            //{
            //    Console.WriteLine("largest");
            //}
            //else
            //{
            //    Console.WriteLine("smallest");
            //}

            //6


            //string username = "admin";
            //string password = "1234";

            //if (username == "admin")
            //{
            //    if (password == "1234")
            //    {
            //        Console.WriteLine("login success");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong password");
            //    }


            //}
            //else
            //{
            //    Console.WriteLine("wrong username");
            //}

            //7

            //int day = 3;

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;

            //    case 2:
            //        Console.WriteLine("tuesday");
            //        break;

            //    case 3:
            //        Console.WriteLine("wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("satuarday");
            //        break;
            //    case 7:
            //        Console.WriteLine("sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Day");
            //        break;
            //}

            //8

            //    string signal = "Red";

            //    switch (signal)
            //    {
            //        case "Red":
            //            Console.WriteLine("Stop");
            //            break;

            //        case "Yellow":
            //            Console.WriteLine("Wait");
            //            break;

            //        case "Green":
            //            Console.WriteLine("Go");
            //            break;

            //        default:
            //            Console.WriteLine("Invalid Signal");
            //            break;
            //    }

            //    Console.ReadLine();
            //}

            //9

            //int choice;
            //double num1, num2, result;


            //Console.WriteLine("Simple Calculator");
            //Console.WriteLine("1 → Add");
            //Console.WriteLine("2 → Subtract");
            //Console.WriteLine("3 → Multiply");
            //Console.WriteLine("4 → Divide");


            //Console.Write("Enter your choice (1-4): ");
            //choice = Convert.ToInt32(Console.ReadLine());


            //Console.Write("Enter first number: ");
            //num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //num2 = Convert.ToDouble(Console.ReadLine());


            //switch (choice)
            //{
            //    case 1:
            //        result = num1 + num2;
            //        Console.WriteLine("Result = " + result);
            //        break;

            //    case 2:
            //        result = num1 - num2;
            //        Console.WriteLine("Result = " + result);
            //        break;

            //    case 3:
            //        result = num1 * num2;
            //        Console.WriteLine("Result = " + result);
            //        break;

            //    case 4:
            //        if (num2 != 0)
            //        {
            //            result = num1 / num2;
            //            Console.WriteLine("Result = " + result);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Cannot divide by zero!");
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("Invalid choice!");
            //        break;
            //}

            //Console.ReadLine();

            //10


            int correctPin = 1234;
            int balance = 10000;

            Console.Write("Enter PIN: ");
            int pin = Convert.ToInt32(Console.ReadLine());

            if (pin == correctPin)
            {
                Console.Write("Enter withdraw amount: ");
                int amount = Convert.ToInt32(Console.ReadLine());

                if (amount <= balance)
                {
                    balance = balance - amount;
                    Console.WriteLine("Withdrawal Successful");
                    Console.WriteLine("Remaining Balance: " + balance);
                }
                else
                {
                    Console.WriteLine("Insufficient Balance");
                }
            }
            else
            {
                Console.WriteLine("Incorrect PIN");
            }

            Console.ReadLine();








        }
    }
}

