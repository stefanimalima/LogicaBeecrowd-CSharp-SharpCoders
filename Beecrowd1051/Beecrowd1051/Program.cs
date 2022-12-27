using System;

namespace Beecrowd1051
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double renda = double.Parse(Console.ReadLine());

            if (renda > 0 && renda <= 2000.00)
            {
                Console.WriteLine("Isento");
            }

            else if (renda >= 2000.01 && renda <= 3000.00)
            {
                double imposto8 = (renda - 2000.00) * 0.08;
                Console.WriteLine($"R$ {imposto8:F2}");
            }

            else if (renda >= 3000.01 && renda <= 4500.00)
            {
                double imposto18 = (renda - 3000.00) * 0.18 + (1000.00 * 0.08);
                Console.WriteLine($"R$ {imposto18:F2}");
            }

            else if (renda > 4500.00)
            {
                double imposto28 = (renda - 4500.00) * 0.28 + (1500 * 0.18) + (1000 * 0.08);
                Console.WriteLine($"R$ {imposto28:F2}");
            }
        }
    }
}
