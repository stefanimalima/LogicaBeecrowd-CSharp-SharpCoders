using System;

namespace Beecrowd1115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Aux = Console.ReadLine().Split(' ');

            int X = int.Parse(Aux[0]);
            int Y = int.Parse(Aux[1]);

            while (X != 0 && Y != 0)
            {
                if (X > 0 && Y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (X < 0 && Y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (X < 0 && Y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (X > 0 && Y < 0)
                {
                    Console.WriteLine("quarto");
                }

                Aux = Console.ReadLine().Split(' ');
                X = int.Parse(Aux[0]);
                Y = int.Parse(Aux[1]);
            }
        }
    }
}
