using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point origin = new Point(0, 0);
            Point first = new Point(1, 2);
            Point second = new Point(1, 5);

            Vector vector1 = new Vector(origin, first);
            Vector vector2 = new Vector(origin, second);

            double magnitude = vector1 * vector2;
            Console.WriteLine($"The magnitude between the two vectors are {magnitude}");

            Console.ReadLine();
        }
    }
}
