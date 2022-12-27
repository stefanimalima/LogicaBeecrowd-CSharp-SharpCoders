using System;
using System.Globalization;

namespace Beecrowd1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, novoSalario, reajuste;
            int percentual;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario >= 0 && salario <= 400)
            {
                novoSalario = salario * 1.15;
                reajuste = novoSalario - salario;
                percentual = 15;

            }
            else if (salario > 400 && salario <= 800)
            {
                novoSalario = salario * 1.12;
                reajuste = novoSalario - salario;
                percentual = 12;
            }
            else if (salario > 800 && salario <= 1200)
            {
                novoSalario = salario * 1.10;
                reajuste = novoSalario - salario;
                percentual = 10;
            }
            else if (salario > 1200 && salario <= 2000)
            {
                novoSalario = salario * 1.07;
                reajuste = novoSalario - salario;
                percentual = 7;
            }
            else
            {
                novoSalario = salario * 1.04;
                reajuste = novoSalario - salario;
                percentual = 4;
            }

            Console.WriteLine($"Novo salario: {novoSalario:F2}");
            Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
            Console.WriteLine($"Em percentual: {percentual} %");
        }
    }
}