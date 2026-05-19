namespace OOPs
{
    internal class Program
    {


        static List<Vehicle> vehicles = new List<Vehicle>();
        static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nWelcome to Vehicle Rental System!");
                Console.WriteLine("1. Add Vehicle");
                Console.WriteLine("2. Register Customer");
                Console.WriteLine("3. Rent Vehicle");
                Console.WriteLine("4. Display Customers");
                Console.WriteLine("5. Exit");

                Console.Write("Choose option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddVehicle();
                        break;
                    case 2:
                        RegisterCustomer();
                        break;
                    case 3:
                        RentVehicle();
                        break;
                    case 4:
                        DisplayCustomers();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }


        static void AddVehicle()
        {
            Console.Write("Enter type (Car/Bike): ");
            string type = Console.ReadLine();

            Console.Write("Make: ");
            string make = Console.ReadLine();

            Console.Write("Model: ");
            string model = Console.ReadLine();

            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Registration Number: ");
            string reg = Console.ReadLine();

            if (type.ToLower() == "car")
            {
                Console.Write("Seats: ");
                int seats = int.Parse(Console.ReadLine());

                vehicles.Add(new Car(make, model, year, reg, seats));
            }
            else
            {
                Console.Write("Has Carrier (true/false): ");
                bool carrier = bool.Parse(Console.ReadLine());

                vehicles.Add(new Bike(make, model, year, reg, carrier));
            }

            Console.WriteLine("Vehicle added successfully!");
        }

        static void RegisterCustomer()
        {
            Console.Write("Customer ID: ");
            string id = Console.ReadLine();

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Contact: ");
            string contact = Console.ReadLine();

            Console.Write("License: ");
            string license = Console.ReadLine();

            customers.Add(new Customer(id, name, contact, license));

            Console.WriteLine("Customer registered!");
        }

        static void RentVehicle()
        {
            Console.Write("Enter Customer ID: ");
            string cid = Console.ReadLine();

            Console.Write("Enter Vehicle Reg No: ");
            string reg = Console.ReadLine();

            Console.Write("Days: ");
            int days = int.Parse(Console.ReadLine());

            Vehicle foundVehicle = vehicles.Find(v => v.GetRegistrationNumber() == reg);

            if (foundVehicle != null)
            {
                double cost = foundVehicle.CalculateRentalCost(days);
                Console.WriteLine("Total Rental Cost: $" + cost);
            }
            else
            {
                Console.WriteLine("Vehicle not found!");
            }
        }

        static void DisplayCustomers()
        {
            foreach (var c in customers)
            {
                c.DisplayDetails();
                Console.WriteLine("--------------------");
            }
        }
    }
}