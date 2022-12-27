using System;

namespace Beecrowd1001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            x = a + b;

            Console.WriteLine($"X = {x}");

            Console.ReadKey();
        }
    }
}
