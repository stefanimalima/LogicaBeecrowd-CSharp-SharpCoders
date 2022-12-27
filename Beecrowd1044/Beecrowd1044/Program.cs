using System;

namespace Beecrowd1044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valor = Console.ReadLine().Split(' ');
            int A = int.Parse(valor[0]);
            int B = int.Parse(valor[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

        }

    }
}
