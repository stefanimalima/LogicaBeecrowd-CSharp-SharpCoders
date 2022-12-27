using System;

namespace Beecrowd1067
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());

            for (int i = 0; i < X; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }

            }

            if (X % 2 == 1)
            {
                Console.WriteLine(X);
            }
        }
    }
}
