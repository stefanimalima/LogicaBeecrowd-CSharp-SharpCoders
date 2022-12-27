using System;

namespace Beecrowd1020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, anos, meses, dias, resto;

            N = int.Parse(Console.ReadLine());
            anos = N / 365;
            resto = N % 365;
            meses = resto / 30;
            resto = resto % 30;
            dias = resto;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
            Console.Read();



        }
    }
}
