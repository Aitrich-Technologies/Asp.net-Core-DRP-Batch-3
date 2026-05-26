namespace NonGenAC;
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        
        ArrayList list = new ArrayList();

        
        list.Add(10);
        list.Add(20);
        list.Add("Hello");
        list.Add(45);
        list.Add("World");
        list.Add(99);
        list.Add(12.5);
        list.Add(5);

        Console.WriteLine("===== ORIGINAL ARRAYLIST =====");

        foreach (object item in list)
        {
            Console.WriteLine(item);
        }

        // -----------------------------------
        // 1. Sum Only Integers
        // -----------------------------------

        int sum = 0;

        foreach (object item in list)
        {
            if (item is int)
            {
                sum += (int)item;
            }
        }

        Console.WriteLine("\nSum of Integers = " + sum);

        // -----------------------------------
        // 2. Find Maximum Integer
        // -----------------------------------

        int max = int.MinValue;

        foreach (object item in list)
        {
            if (item is int)
            {
                int value = (int)item;

                if (value > max)
                {
                    max = value;
                }
            }
        }

        Console.WriteLine("Maximum Integer = " + max);

        // -----------------------------------
        // 3. Remove Item
        // -----------------------------------

        Console.Write("\nEnter item to remove: ");
        string removeItem = Console.ReadLine();

        // Remove matching item
        if (list.Contains(removeItem))
        {
            list.Remove(removeItem);
            Console.WriteLine("Item removed!");
        }
        else
        {
            // Try integer remove
            int num;

            if (int.TryParse(removeItem, out num))
            {
                if (list.Contains(num))
                {
                    list.Remove(num);
                    Console.WriteLine("Item removed!");
                }
                else
                {
                    Console.WriteLine("Item not found!");
                }
            }
            else
            {
                Console.WriteLine("Item not found!");
            }
        }

        // -----------------------------------
        // 4. Search Element
        // -----------------------------------

        Console.Write("\nEnter item to search: ");
        string search = Console.ReadLine();

        if (list.Contains(search))
        {
            Console.WriteLine("String exists in ArrayList");
        }
        else
        {
            int value;

            if (int.TryParse(search, out value) && list.Contains(value))
            {
                Console.WriteLine("Integer exists in ArrayList");
            }
            else
            {
                Console.WriteLine("Element not found");
            }
        }

        // -----------------------------------
        // 5. Separate Data Types
        // -----------------------------------

        ArrayList integers = new ArrayList();
        ArrayList strings = new ArrayList();

        foreach (object item in list)
        {
            if (item is int)
            {
                integers.Add(item);
            }
            else if (item is string)
            {
                strings.Add(item);
            }
        }

        Console.WriteLine("\n--- Integer List ---");

        foreach (object item in integers)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\n--- String List ---");

        foreach (object item in strings)
        {
            Console.WriteLine(item);
        }

        // -----------------------------------
        // 6. Count Each Type
        // -----------------------------------

        int intCount = 0;
        int stringCount = 0;

        foreach (object item in list)
        {
            if (item is int)
            {
                intCount++;
            }
            else if (item is string)
            {
                stringCount++;
            }
        }

        Console.WriteLine("\nInteger Count = " + intCount);
        Console.WriteLine("String Count = " + stringCount);

        // -----------------------------------
        // 7. Type Casting Practice
        // -----------------------------------

        Console.WriteLine("\n--- Integer Values Only ---");

        foreach (object item in list)
        {
            if (item is int)
            {
                int number = (int)item;   
                Console.WriteLine(number);
            }
        }
    }
}