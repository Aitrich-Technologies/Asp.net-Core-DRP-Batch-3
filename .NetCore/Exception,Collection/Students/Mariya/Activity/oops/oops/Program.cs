namespace oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Student students = new Student();
            students.Name = "Raihan";
            students.Id = 15;
            students.age = 18;

            students.display();
            {
                //Console.WriteLine(students.Name);
                //Console.WriteLine(students.Id);
                //Console.WriteLine(students.age);
            }

            
        }
    }
}
