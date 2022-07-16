using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            const double pi = 3.14d;

            Console.WriteLine("Choose circles radius");
            radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area of your circle equal {0}", pi * Math.Pow(radius, 2));
            Console.ReadLine();


        }
    }
}
