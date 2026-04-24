namespace workshopc_
{
    internal class Program
    {
        struct interview
        {
            public string title;
            public DateTime date;
            public string time;
            public string Location;
                
        }
        static void Main(string[] args)
        {
            interview[] shedule = new interview[10];
            Console.WriteLine("-----------------------------------------------------------\n");
            Console.WriteLine("-----------shedule an interview for job seekers------------\n");
            Console.WriteLine("-----------------------------------------------------------\n");
            string ch;
            do
            {
                Console.WriteLine("A - shedule a interview\n");
                Console.WriteLine("D - shedule interview list\n");
                Console.WriteLine("-------------------------------------------------------\n");
                Console.WriteLine("select an option");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "A":
                        {
                            Console.WriteLine("How many no of interviews are sheduling \n");
                            int count = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine("--------------interview shedule{0}-----------------", i + 1);
                                Console.WriteLine("---------------------------------------------------\n");
                                Console.Write("Enter the Name of job post {0}:", i + 1);
                                shedule[i].title = Console.ReadLine();
                                Console.WriteLine("Enter the Date for interview(DD-MM-YY)");
                                shedule[i].date = Convert.ToDateTime(Console.ReadLine());
                                Console.WriteLine("Enter the Time of a interview(H-M)");
                                shedule[i].time = Console.ReadLine();
                                Console.Write("Location of shedule interview {0}:", i + 1);
                                shedule[i].Location = Console.ReadLine();
                                Console.WriteLine("--------------------------------------------------\n");
                            }
                            break;
                        }
                    case "D":
                        {
                            Console.WriteLine("----------------sheduled interview details are:----------------");
                            Console.WriteLine("---------------------------------------------------------------\n");
                            for (int i = 0; i < shedule.Length; i++)
                            {
                                if (shedule[i].title != null)
                                {
                                    Console.WriteLine("-----------------------------------------------------------\n");
                                    Console.WriteLine("Name:{0}", shedule[i].title);
                                    Console.WriteLine("Date:{0}", shedule[i].date.Date.ToString("MM/DD/YYY"));
                                    Console.WriteLine("Time:{0}", shedule[i].time);
                                    Console.WriteLine("Location:{0}", shedule[i].Location);
                                    Console.WriteLine("-----------------------------------------------------------\n");

                                }
                            }

                            Console.ReadLine();
                            break;
                        }
                }
                Console.WriteLine("Do you want to continue (Y/N)\n");
                ch = Console.ReadLine();
            }
            while (ch == "y" || ch == "Y");


            
        }
    }
}
