using System;
using System.Linq;
public class Program
{
    public static void Main(string[] args)
    {

        int valor;
        int[] valores = new int[100];

        for (int i = 0; i < 100; i++)
        {
            valor = int.Parse(Console.ReadLine());
            valores[i] = valor;
        }
        int maiorValor = valores.Max();
        Console.WriteLine(maiorValor);
        int index = Array.IndexOf(valores, maiorValor);
        Console.WriteLine(index + 1);
    }
}
