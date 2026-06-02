using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            var numbers = new[] { 1, 5, 3, 4, 7 };

            var squares = numbers.Select(n => n * n);

            foreach (var square in squares)
            {
                WriteLine($"{square} ");
            }

            

            var scores = new List<int> { 1, 5, 2, 3, 8, 7, 9 };
            var sortedScores = scores.OrderBy(n => n);

            foreach (var score in sortedScores)
            {
                Write($"{score} ");
            }
        }
    }
}
