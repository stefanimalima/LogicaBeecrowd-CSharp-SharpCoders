using System;
using System.Globalization;

namespace Beecrowd1117
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (Nota1 < 0 || Nota1 > 10)
            {
                Console.WriteLine("nota invalida");
                Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (Nota2 < 0 || Nota2 > 10)
            {
                Console.WriteLine("nota invalida");
                Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double Media = (Nota1 + Nota2) / 2.0;

            Console.WriteLine("media = " + Media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
