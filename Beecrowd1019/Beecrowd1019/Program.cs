using System;

namespace Beecrowd1019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, hora, minuto, segundo, resto;

            N = int.Parse(Console.ReadLine());
            hora = N / 3600;
            resto = N % 3600;
            minuto = resto / 60;
            resto = resto % 60;
            segundo = resto;

            Console.WriteLine(hora + ":" + minuto + ":" + segundo);
            Console.ReadLine();
        }
    }
}
