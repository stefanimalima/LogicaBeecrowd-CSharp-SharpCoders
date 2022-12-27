using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Beecrowd1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero_funcionario = Convert.ToInt32(Console.ReadLine());
            int Quantidade_de_horas = Convert.ToInt32(Console.ReadLine());
            double Valor_da_hora = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Salario = (Valor_da_hora * Quantidade_de_horas);

            Console.WriteLine($"NUMBER = {Numero_funcionario}\nSALARY = U$ {Salario.ToString("f2", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}
