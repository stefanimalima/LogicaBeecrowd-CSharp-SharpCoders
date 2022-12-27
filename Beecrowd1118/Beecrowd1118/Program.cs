using System;

namespace Beecrowd1118
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Aux = 0;
            double Media = 0;

            do
            {
                double X = double.Parse(Console.ReadLine());

                while (X < 0.0 || X > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    X = double.Parse(Console.ReadLine());
                }

                double Y = double.Parse(Console.ReadLine());

                while (Y < 0.0 || Y > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    Y = double.Parse(Console.ReadLine());
                }

                Media = (X + Y) / 2.0;
                Console.WriteLine("media = " + Media.ToString("F2"));

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                Aux = int.Parse(Console.ReadLine());

                while (Aux != 1 && Aux != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    Aux = int.Parse(Console.ReadLine());
                }

            } while (Aux != 2);
        }
    }
}
