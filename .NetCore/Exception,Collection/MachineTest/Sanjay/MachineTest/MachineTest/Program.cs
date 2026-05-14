namespace MachineTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Department cs = new Department { DepartmentName = "Computer Science" };

            cs.Students.Add(new Student { Name = "Alfin", Age = 20, Marks1 = 90, Marks2 = 85, Marks3 = 88, Marks4 = 92, Marks5 = 87, Marks6 = 91 });
            cs.Students.Add(new Student { Name = "Arya", Age = 22, Marks1 = 70, Marks2 = 75, Marks3 = 72, Marks4 = 68, Marks5 = 74, Marks6 = 71 });

            
            Department mech = new Department { DepartmentName = "Mechanical" };

            mech.Students.Add(new Student { Name = "Mariya", Age = 21, Marks1 = 95, Marks2 = 93, Marks3 = 90, Marks4 = 94, Marks5 = 92, Marks6 = 96 });
            mech.Students.Add(new Student { Name = "Alfin_2.0", Age = 23, Marks1 = 60, Marks2 = 65, Marks3 = 62, Marks4 = 58, Marks5 = 64, Marks6 = 61 });

            
            Student csTopper = cs.GetTopper();
            Student mechTopper = mech.GetTopper();

            Console.WriteLine("Topper of " + cs.DepartmentName + ": " + csTopper.Name + " CGPA: " + csTopper.CalculateCGPA() + " and Grade " +csTopper.GetGrade());
            Console.WriteLine("Topper of " + mech.DepartmentName + ": " + mechTopper.Name + " CGPA: " + mechTopper.CalculateCGPA() + " and Grade " + csTopper.GetGrade());
        }
    }
}
