using System;

namespace Beecrowd1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Horas = int.Parse(Console.ReadLine());
            int Velocidade = int.Parse(Console.ReadLine()); 

            Console.WriteLine($"{(double) Horas * Velocidade / 12:F3}");
        }
    }
}
