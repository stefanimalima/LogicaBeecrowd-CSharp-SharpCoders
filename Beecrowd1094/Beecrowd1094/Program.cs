using System;

namespace Beecrowd1094
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double coelhosP, ratosP, saposP;
            int num = int.Parse(Console.ReadLine());
            string[] valorcod;
            int[] valores = new int[num];
            string[] codigo = new string[num];
            double total = 0;
            double coelhos = 0;
            double ratos = 0;
            double sapos = 0;

            for (int i = 0; i < num; i++)
            {
                valorcod = Console.ReadLine().Split();
                valores[i] = int.Parse(valorcod[0]);
                codigo[i] = valorcod[1];
                total = total + valores[i];
                if (codigo[i] == "C")
                {
                    coelhos = coelhos + valores[i];
                }
                else if (codigo[i] == "R")
                {
                    ratos = ratos + valores[i];
                }
                else if (codigo[i] == "S")
                {
                    sapos = sapos + valores[i];
                }
            }
            coelhosP = (coelhos / total) * 100;
            ratosP = (ratos / total) * 100;
            saposP = (sapos / total) * 100;

            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {coelhos}");
            Console.WriteLine($"Total de ratos: {ratos}");
            Console.WriteLine($"Total de sapos: {sapos}");
            Console.WriteLine($"Percentual de coelhos: {coelhosP:F2} %");
            Console.WriteLine($"Percentual de ratos: {ratosP:F2} %");
            Console.WriteLine($"Percentual de sapos: {saposP:F2} %");
        }
    }
}
     