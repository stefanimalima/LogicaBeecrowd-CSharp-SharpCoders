using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Beecrowd1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Area = Console.ReadLine().Split(' ');
            double A = double.Parse(Area[0], CultureInfo.InvariantCulture);
            double B = double.Parse(Area[1], CultureInfo.InvariantCulture);
            double C = double.Parse(Area[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"TRIANGULO: {(A * C / 2).ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {(3.14159 * C * C).ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {((A + B) * C / 2).ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {(B * B).ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {(A * B).ToString("f3", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}
