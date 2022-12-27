using System;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd1099
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aux = int.Parse(Console.ReadLine());

            for (int i = 0; i < aux; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));
                Array.Sort(input);
                List<int> numImpar = new List<int>();

                for (int x = (input[0] + 1); x < input[1]; x++)
                {
                    if (x % 2 != 0)
                    {
                        numImpar.Add(x);
                    }
                }
                Console.WriteLine(numImpar.Sum());
            }
        }
    }
}
