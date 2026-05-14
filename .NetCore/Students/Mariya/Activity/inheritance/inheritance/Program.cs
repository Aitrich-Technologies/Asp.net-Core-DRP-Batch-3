namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            {
                tourist t = new tourist();
                t.userid = 1;
                t.name = "Arya";
                t.login();
                t.booktour();

                Touroperator tp = new Touroperator();
                tp.userid = 2;
                tp.name = "sanjay";
                tp.login();
                tp.createtourpackage();

                domestictour d = new domestictour();
                d.packageid = 1;
                d.location = "kerala";
                d.price = 10000;
                d.DisplayPackageType();

                internationaltour i = new internationaltour();
                i.packageid = 1;
                i.location = "japan";
                i.price = 80000;
                i.DisplayPackageType();

                Guide g = new Guide();
                g.empId = 1;
                g.Name = "Devu";
                g.langauages = "English";
                g.Expertise = "international tours";
                g.displayinfo();
                g.showguidedetails();

                travelagent ta = new travelagent();
                ta.empId = 10;
                ta.Name = "jency";
                ta.bookingsystem = "online";
                ta.customerhandling = "Excellent";
                ta.displayinfo();
                ta.showagentdetails();


                Solotravelprofile s = new Solotravelprofile();
                s.Name = "Abhi";
                s.solotrips = "Two";
                s.travelhistory = "tokyo,paris";
                s.preference = "international tours";
                s.ShowSoloTravellerProfile();

                Familytravelprofile f = new Familytravelprofile();
                f.Name = "Arya";
                f.travelhistory = "japan,korea,london";
                f.familymembers = "three";
                f.grouptours = 6;
                f.ShowFamilyTravellerProfile();




            }

        }
    }
}
