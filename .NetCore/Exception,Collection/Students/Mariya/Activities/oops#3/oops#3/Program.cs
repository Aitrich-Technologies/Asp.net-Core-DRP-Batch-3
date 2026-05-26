namespace oops_3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ////Console.WriteLine("Hello, World!");
            //jobseeker jobseeker = new jobseeker();
            //jobseeker.Password = "34567";
            //Console.WriteLine(jobseeker.Password);

            //jobseeker.login();
            //jobseeker.Applyjob();

           domestictour w = new domestictour();
            w.tourname = "sunday tour";
            w.destination = "kerala";
            w.price = 100;
             Console.WriteLine(w.tourname);
            Console.WriteLine(w.destination);
            Console.WriteLine(w.price);
            w.display();
            w.applyjob();
        }
    }
}
