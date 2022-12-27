using System;

namespace Beecrowd1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor, nota100, nota50, nota20, nota10, nota5, nota2, nota1, qtdNota100, qtdNota50, qtdNota20, qtdNota10, qtdNota5, qtdNota2, qtdNota1, restante1, restante2, restante3, restante4, restante5, restante6, restante7;
            valor = int.Parse(Console.ReadLine());
            nota100 = 100;
            nota50 = 50;
            nota20 = 20;
            nota10 = 10;
            nota5 = 5;
            nota2 = 2;
            nota1 = 1;

            qtdNota100 = valor / nota100;
            restante1 = Math.Abs((qtdNota100 * nota100) - valor);

            qtdNota50 = restante1 / nota50;
            restante2 = Math.Abs((qtdNota50 * nota50) - restante1);

            qtdNota20 = restante2 / nota20;
            restante3 = Math.Abs((qtdNota20 * nota20) - restante2);

            qtdNota10 = restante3 / nota10;
            restante4 = Math.Abs((qtdNota10 * nota10) - restante3);

            qtdNota5 = restante4 / nota5;
            restante5 = Math.Abs((qtdNota5 * nota5) - restante4);

            qtdNota2 = restante5 / nota2;
            restante6 = Math.Abs((qtdNota2 * nota2) - restante5);

            qtdNota1 = restante6 / nota1;
            restante7 = Math.Abs((qtdNota1 * nota1) - restante6);

            Console.WriteLine($"{valor}\n{qtdNota100} nota(s) de R$ 100,00\n{qtdNota50} nota(s) de R$ 50,00\n{qtdNota20} nota(s) de R$ 20,00\n{qtdNota10} nota(s) de R$ 10,00\n{qtdNota5} nota(s) de R$ 5,00\n{qtdNota2} nota(s) de R$ 2,00\n{qtdNota1} nota(s) de R$ 1,00");
        }
    }
}
