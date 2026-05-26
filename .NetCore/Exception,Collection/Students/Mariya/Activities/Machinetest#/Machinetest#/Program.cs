namespace Machinetest_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            LibraryMember[] members = new LibraryMember[2];
            members[0] = new StudentMember(1,"mariya");
            members[1] = new FacultyMember(2, "Raihan");

            int overduedays = 5;


            foreach (var member in members)
            {

                double fine = member.CalculateFine(overduedays);
                Console.WriteLine($"Member ID:{member.MemberId},Name: {member.Name}, Fine: $ {fine}");

            }

        }
    }
}
