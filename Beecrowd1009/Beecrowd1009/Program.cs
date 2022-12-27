using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Beecrowd1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nome_vendedor = Console.ReadLine();
            double Salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Total_vendas = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Salario_total = (Total_vendas * 0.15) + Salario;

            Console.WriteLine("TOTAL = R$ {0}", Salario_total.ToString("f2", CultureInfo.InvariantCulture));
            
            Console.ReadKey();
        }
    }
}
