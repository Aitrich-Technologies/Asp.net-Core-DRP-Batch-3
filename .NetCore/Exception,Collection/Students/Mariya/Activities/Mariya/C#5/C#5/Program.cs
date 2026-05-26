using System.Runtime.InteropServices;

namespace C_5
{
    public enum roles
    {
        Admin, consultant, customer
    }

    //public struct books
    //{
    //    public string name;
    //    public int id;
    //    public string author;

    //}
    //public struct student
    //{
    //    public string name;
    //    public int standard;
    //    public string age;
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            roles job = roles.Admin;
            Console.WriteLine(job);
            Console.WriteLine((int)job);

            //struct
            //books b;
            //b.name = "beloved";
            //b.id = 1;
            //b.author = "william shakespear";
            //Console.WriteLine(b.author);

            //student X;
            //X.name = "Rayyan";
            //X.standard = 7;
            //X.age = "15";
            //Console.WriteLine(X.name);
            //Console.WriteLine(X.standard);
            //Console.WriteLine(X.age);
            //Console.WriteLine($"name is :{ X.name},standard is:{X.standard},age is:{X.age}");

            
        }
    }
}
