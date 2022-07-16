using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14d;
            double radius, high;

            Console.WriteLine("Choose high and radius of your cilindre");
            high = Convert.ToDouble(Console.ReadLine());
            radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area of your cilindre equal {0} and vol equal {1}", 2 * pi * radius * (radius + high), pi * Math.Pow(radius, 2) * high);
            Console.ReadLine();

        }
    }
}
