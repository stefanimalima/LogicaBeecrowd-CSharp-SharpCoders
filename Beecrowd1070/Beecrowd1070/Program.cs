using System;

namespace URI_1070
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                numero++;
            }

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(numero);
                numero = numero + 2;
            }
        }
    }
}