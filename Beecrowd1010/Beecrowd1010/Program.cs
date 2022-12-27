using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Beecrowd1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Compra = Console.ReadLine().Split(' ');
            int Codigo_produto = Int32.Parse(Compra[0]);
            int Quantidade_produto = int.Parse(Compra[1]);
            double Valor_produto = double.Parse(Compra[2]);

            string[] Compra1 = Console.ReadLine().Split(' ');
            int Codigo_produto1 = Int32.Parse(Compra1[0]);
            int Quantidade_produto1 = int.Parse(Compra1[1]);
            double Valor_produto1 = double.Parse(Compra1[2]);

            double Total = (Quantidade_produto * Valor_produto) + (Quantidade_produto1 * Valor_produto1);

            Console.WriteLine("VALOR A PAGAR: R$ {0}", Total.ToString("f2", CultureInfo.InvariantCulture));


            Console.ReadKey();
        }
    }
}
