using System;
class URI
{

    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int productCode = int.Parse(input[0]);
        int quantity = int.Parse(input[1]);
        if (productCode == 1)
        {
            string quantityOfCachorroQuente = (quantity * 4.00).ToString("F2");
            Console.WriteLine($"Total: R$ {quantityOfCachorroQuente}".Replace(',', '.'));
        }
        else if (productCode == 2)
        {
            string quantityOfXSalada = (quantity * 4.50).ToString("F2");
            Console.WriteLine($"Total: R$ {quantityOfXSalada}".Replace(',', '.'));
        }
        else if (productCode == 3)
        {
            string quantityOfXBacon = (quantity * 5.00).ToString("F2");
            Console.WriteLine($"Total: R$ {quantityOfXBacon}".Replace(',', '.'));
        }
        else if (productCode == 4)
        {
            string quantityOfTorrada = (quantity * 2.00).ToString("F2");
            Console.WriteLine($"Total: R$ {quantityOfTorrada}".Replace(',', '.'));

        }
        else if (productCode == 5)
        {
            string quantityOfRefrigerante = (quantity * 1.50).ToString("F2");
            Console.WriteLine($"Total: R$ {quantityOfRefrigerante}".Replace(',', '.'));
        }
    }

}