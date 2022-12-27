using System;

class URI
{

    static void Main(string[] args)
    {

        int distancia = int.Parse(Console.ReadLine());
        double combustivel = double.Parse(Console.ReadLine());
        double consumo_medio;

        consumo_medio = distancia / combustivel;

        Console.WriteLine($"{consumo_medio:F3} km/l");

    }

}
