using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd1015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] distancia1 = Console.ReadLine().Split(' ');
            double x1 = double.Parse(distancia1[0]);
            double y1 = double.Parse(distancia1[1]);

            string[] distancia2 = Console.ReadLine().Split(' ');
            double x2 = double.Parse(distancia2[0]);
            double y2 = double.Parse(distancia2[1]);

            double p1 = x2 - x1;
            p1 = Math.Pow(p1, 2);
            double p2 = y2 - y1;
            p2 = Math.Pow(p2, 2);

            double p3 = p1 + p2;
            double distancia = Math.Sqrt(p3);

            Console.WriteLine($"{distancia:F4}");

        }
    }
}
