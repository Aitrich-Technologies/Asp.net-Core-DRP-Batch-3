namespace method_overridung_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Circle(5);
            s.Area();

            s = new Rectangle(4, 6);
            s.Area();
        }
    }
}
