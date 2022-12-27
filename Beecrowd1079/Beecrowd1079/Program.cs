using System;
using System.Globalization;

namespace Beecrowd1079
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] vetor;

            for (int i = 0; i < N; i++)
            {
                vetor = Console.ReadLine().Split(' ');
                double valor1 = double.Parse(vetor[0], CultureInfo.InvariantCulture);
                double valor2 = double.Parse(vetor[1], CultureInfo.InvariantCulture);
                double valor3 = double.Parse(vetor[2], CultureInfo.InvariantCulture);

                double media = ((valor1 * 2.0) + (valor2 * 3.0) + (valor3 * 5.0)) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
