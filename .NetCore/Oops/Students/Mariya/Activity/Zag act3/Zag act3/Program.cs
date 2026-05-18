namespace Zag_act3
{
    internal class Program
    {
        static List<Vehicle> vehicles = new List<Vehicle>();
        static List<Customer> customers = new List<Customer>();

       

            static void Main()
        {
                while (true)
                {
                    Console.WriteLine("\nWelcome to the Vehicle Rental System!");
                    Console.WriteLine("1. Add a Vehicle");
                    Console.WriteLine("2. Register a Customer");
                    Console.WriteLine("3. Rent a Vehicle");
                    Console.WriteLine("4. Display Customer Details");
                    Console.WriteLine("5. Exit");

                    Console.Write("Choose an option: ");
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
                            DisplayCustomer();
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
                Console.Write("Enter Vehicle Type (Car/Bike): ");
                string type = Console.ReadLine().ToLower();

                Console.Write("Enter Make: ");
                string make = Console.ReadLine();

                Console.Write("Enter Model: ");
                string model = Console.ReadLine();

                Console.Write("Enter Year: ");
                int year = int.Parse(Console.ReadLine());

                Console.Write("Enter Registration Number: ");
                string regNo = Console.ReadLine();

                if (type == "car")
                {
                    Console.Write("Enter Number of Seats: ");
                    int seats = int.Parse(Console.ReadLine());

                    vehicles.Add(new Car(make, model, year, regNo, seats));
                }
                else if (type == "bike")
                {
                    Console.Write("Has Carrier (true/false): ");
                    bool hasCarrier = bool.Parse(Console.ReadLine());

                    vehicles.Add(new Bike(make, model, year, regNo, hasCarrier));
                }

                Console.WriteLine("Vehicle added successfully!");
            }

            static void RegisterCustomer()
            {
                Console.Write("Enter Customer ID: ");
                string id = Console.ReadLine();

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Contact Number: ");
                string contact = Console.ReadLine();

                Console.Write("Enter Driving License: ");
                string license = Console.ReadLine();

                customers.Add(new Customer(id, name, contact, license));

                Console.WriteLine("Customer registered successfully!");
            }

            static void RentVehicle()
            {
                Console.Write("Enter Customer ID: ");
                string custId = Console.ReadLine();

                Console.Write("Enter Vehicle Registration Number: ");
                string regNo = Console.ReadLine();

                Console.Write("Enter Rental Days: ");
                int days = int.Parse(Console.ReadLine());

                Vehicle vehicle = vehicles.Find(v => v.GetRegistrationNumber() == regNo);

                if (vehicle == null)
                {
                    Console.WriteLine("Vehicle not found!");
                    return;
                }

                double cost = vehicle.CalculateRentalCost(days);

                Console.WriteLine($"Total Rental Cost: ${cost}");
            }

            static void DisplayCustomer()
            {
                Console.Write("Enter Customer ID: ");
                string id = Console.ReadLine();

                Customer customer = customers.Find(c => c.CustomerId == id);

                if (customer != null)
                {
                    customer.DisplayDetails();
                }
                else
                {
                    Console.WriteLine("Customer not found!");
                }
            }
        }
    }
}
