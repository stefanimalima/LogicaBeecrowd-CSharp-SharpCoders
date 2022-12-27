using System;
using System.Globalization;

namespace Beecrowd1064
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero = 0;
            double positivo = 0;
            double soma = 0;

            for (int i = 0; i < 6; i++)
            {

                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (numero > 0)
                {
                    positivo++;
                    soma = soma + numero;
                }
            }

            double media = soma / positivo;
            Console.WriteLine(positivo + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
