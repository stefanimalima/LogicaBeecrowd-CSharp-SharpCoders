using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd1016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Distancia = Int32.Parse(Console.ReadLine());

            int Tempo = Distancia * 2;

            Console.WriteLine($"{Tempo} minutos");

        }
    }
}
