using static System.Console;
namespace ActivityLinQ2
{
    class TourPackage
    {
        public int TourId { get; set; }
        public string TourName { get; set; }
        public string Destination { get; set; }
        public double Price { get; set; }


        public TourPackage(int tourId, string tourName, string destination, double price)
        {
            this.TourId = tourId;
            this.TourName = tourName;
            this.Destination = destination;
            this.Price = price;
        }
    };

    //class Employees
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public string Department { get; set; }
    //};


    internal class Program
    {
        static void Main(string[] args)
        {
            List<TourPackage> packages = new List<TourPackage>();

            while (true)
            {


                Console.WriteLine("1. ADD Tour");
                Console.WriteLine("2. Display All Tour");
                Console.WriteLine("3. Calculate average package price");
                Console.WriteLine("4. Rank Tour ");
                Console.WriteLine("5. Remove Tour");
                Console.WriteLine("6. Find Tour");
                Console.WriteLine("7. Exit");

                Console.WriteLine("Enter choice :");
                int Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        AddTour(packages);
                        break;
                    case 2:
                        DisplayAllTour(packages);
                        break;
                    case 3:
                        AverageTour(packages);
                        break;
                    case 4:
                        OrderByRank(packages);
                        break;
                    case 5:
                        TourRemove(packages);
                        break;
                    case 6:
                        TourSearch(packages);
                        break;
                    case 7:
                        return;
                }
            }
            static void AddTour(List<TourPackage> packages)
            {
                Console.Write("Enter number of tours: ");
                int count = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < count; i++)
                {
                    Console.Write("Enter Tour Id: ");
                    int tourId = Convert.ToInt32(Console.ReadLine());

                    foreach (var item in packages)
                    {
                        if (tourId == item.TourId)
                        {
                            Console.WriteLine("Tour ID exist");
                            return;
                        }

                        if (tourId <= 0)
                        {
                            Console.WriteLine("Id cannot be negative");
                            return;
                        }

                    }

                    Console.Write("Tour Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Destination: ");
                    string destination = Console.ReadLine();

                    Console.Write("Package Price: ");
                    double price = Convert.ToDouble(Console.ReadLine());

                    TourPackage tour = new TourPackage(tourId, name, destination, price);

                    packages.Add(tour);

                    Console.WriteLine("Tour Added Successfully");
                    Console.WriteLine("\n");
                }
            }

            static void DisplayAllTour(List<TourPackage> packages)
            {

                Console.WriteLine("\nTour Details");
                foreach (TourPackage tours in packages)
                {
                    Console.WriteLine(tours.TourId + "  " + tours.TourName + "  " + tours.Destination + "  " + tours.Price);

                }

            }

            static void AverageTour(List<TourPackage> packages)
            {
                double average = packages.Average(t => t.Price);
                Console.WriteLine("\nAverage Price : " + average);
            }

            static void OrderByRank(List<TourPackage> packages)
            {
                var rank = packages.OrderBy(s => s.Price);


                int count1 = 1;
                foreach (var item in rank)
                {
                    Console.WriteLine("Rank: " + count1 + " " + item.TourName + " " + item.Destination + " " + item.Price);


                    count1++;
                }
            }

            static void TourRemove(List<TourPackage> packages)
            {
                Console.WriteLine("\nEnter tour id to remove");
                int id = Convert.ToInt32(Console.ReadLine());



                TourPackage tourToRemove = packages.FirstOrDefault(t => t.TourId == id);

                if (tourToRemove != null)
                {
                    packages.Remove(tourToRemove);
                    Console.WriteLine("Tour removed successfully.");
                }
                else
                {
                    Console.WriteLine("Tour ID not found.");
                }
            }

            static void TourSearch(List<TourPackage> packages)
            {

                Console.Write("\nEnter Tour Name to search: ");
                string names = Console.ReadLine();

                TourPackage to = packages.FirstOrDefault
                (t => t.TourName.ToLower().Contains(names.ToLower()));

                if (to != null)
                {
                    Console.WriteLine("Tour Found");
                    Console.WriteLine("Tour ID: " + to.TourId);
                    Console.WriteLine("Destination: " + to.Destination);
                    Console.WriteLine("Price: " + to.Price);
                }
                else
                {
                    Console.WriteLine("Tour not found");
                }

            }
        }
    }
}

//2nd Question
//            {
//                List<Employees> employees = new List<Employees>();

//                while (true)
//                {

//                    Console.WriteLine("1. Add employee");
//                    Console.WriteLine("2. Display employees");
//                    Console.WriteLine("3.FIlter by department");
//                    Console.WriteLine("4.Exit");

//                    int value = Convert.ToInt32(Console.ReadLine());

//                    switch (value)
//                    {
//                        case 1:
//                            AddEmployee(employees);
//                            break;

//                        case 2:
//                            DisplayAll(employees);
//                            break;
//                        case 3:
//                            Filter(employees);
//                            break;
//                        case 4:
//                            return;
//                    }
//                }
//            }

//            static void AddEmployee(List<Employees> employees)
//            {
//                Employees e = new Employees();
//                Console.Write("Enter id:");
//                e.Id = Convert.ToInt32(Console.ReadLine());

//                foreach (var item in employees)
//                {
//                    if (item.Id == e.Id)
//                    {
//                        Console.WriteLine("Id exist");
//                        return;
//                    }
//                }
//                if (e.Id < 0)
//                {
//                    Console.WriteLine("Id cannot be negative");
//                }
//                Console.Write("enter name:");
//                e.Name = Console.ReadLine();

//                Console.Write("Enter Age:");
//                e.Age = Convert.ToInt32(Console.ReadLine());

//                Console.Write("Enter Department:");
//                e.Department = Console.ReadLine();

//                employees.Add(e);

//            }

//            static void DisplayAll(List<Employees> employees)
//            {
//                foreach (var item in employees)
//                {
//                    Console.WriteLine(item.Id + " " + item.Name + " " + item.Department);
//                }
//            }

//            static void Filter(List<Employees> employees)
//            {
//                Console.Write("Enter Department Name: ");
//                string dept = Console.ReadLine();

//                List<Employees> filteredEmployees = employees
//                    .Where(e => e.Department.ToLower() == dept.ToLower())
//                    .ToList();

//                if (filteredEmployees.Count == 0)
//                {
//                    Console.WriteLine("No Employees Found in this Department.");
//                    return;
//                }

//                Console.WriteLine("\n--- Filtered Employees ---");

//                foreach (Employees emp in filteredEmployees)
//                {
//                    Console.WriteLine("Id: " + emp.Id + ", Name: " + emp.Name + ", Age: " + emp.Age + ", Department: " + emp.Department);

//                }

//            }
//        }
//    }
//}
