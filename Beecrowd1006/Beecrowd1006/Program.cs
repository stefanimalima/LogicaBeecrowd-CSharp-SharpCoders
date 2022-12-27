using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Beecrowd1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Nota_1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Nota_2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Nota_3 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Media = (Nota_1 * 2 + Nota_2 * 3 + Nota_3 * 5) / 10;

            Console.WriteLine($"MEDIA = {Media.ToString("f1", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}
