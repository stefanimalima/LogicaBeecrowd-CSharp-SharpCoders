using System;

namespace Beecrowd1004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor_1 = Convert.ToInt16(Console.ReadLine());
            int valor_2 = Convert.ToInt16(Console.ReadLine());

            int PROD = valor_1 * valor_2;
            Console.WriteLine($"PROD = {PROD}");

            Console.ReadKey();
        }
    }
}
