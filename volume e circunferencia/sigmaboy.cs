using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sixsevenn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Raio: ");
            double r = double.Parse(Console.ReadLine());
            double pi = 3.14;
            double c = 2 * pi * r;
            double v = 4 * pi * r * r;
            Console.WriteLine("Circunferência: " + c);
            Console.WriteLine("Volume: " + v);
            Console.WriteLine("Valor de PI: " + pi);

        }
    }
}
