using System;

namespace Beecrowd1071
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int menorNum = 0;
            int maiorNum = 0;

            if (X > Y)
            {
                maiorNum = X;
                menorNum = Y;
            }
            else
            {
                maiorNum = Y;
                menorNum = X;
            }

            int resultado = 0;

            for (int i = menorNum + 1; i < maiorNum; i++)
            {
                if (i % 2 != 0)
                {
                    resultado = resultado + i;
                }
            }

            Console.WriteLine(resultado);
        }
    }
}
