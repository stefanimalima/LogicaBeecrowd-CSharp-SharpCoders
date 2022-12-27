using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd1013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Maior = Console.ReadLine().Split(' ');

            int A = int.Parse(Maior[0]);
            int B = int.Parse(Maior[1]);
            int C = int.Parse(Maior[2]);    

            int MaiorAB = (A + B + Math.Abs(A - B)) / 2;
            int Omaior = (MaiorAB + C + Math.Abs(MaiorAB - C)) / 2;

            Console.WriteLine($"{Omaior} eh o maior");
           
            Console.ReadKey();
        }
    }
}
