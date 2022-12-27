using System;
using System.Globalization;


namespace Beecrowd1116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] Aux = Console.ReadLine().Split(' ');
                int X = int.Parse(Aux[0]);
                int Y = int.Parse(Aux[1]);

                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double divisao = (double)X / Y;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }

            }
        }
    }
}
