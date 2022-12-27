using System;

namespace Beecrowd1073
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            if (N % 2 == 1)
            {
                N++;
            }

            for (int i = 2; i <= N; i = i + 2)
            {
                int quadrado = i * i;
                Console.WriteLine(i + "^" + 2 + " = " + quadrado);
            }
        }
    }
}
