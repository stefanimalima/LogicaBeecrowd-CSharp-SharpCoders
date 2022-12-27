using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Beecrowd1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Nota_1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Nota_2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Media = (Nota_1 * 3.5 + Nota_2 * 7.5) / 11; 

            Console.WriteLine($"MEDIA = {Media.ToString("f5",CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}
