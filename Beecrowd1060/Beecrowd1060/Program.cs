﻿using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {
        double valor;
        int quantidadePositivos = 0;
        for (int i = 0; i < 6; i++)
        {
            valor = Convert.ToDouble(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            if (valor >= 1)
                quantidadePositivos++;
        }
        System.Console.WriteLine($"{quantidadePositivos} valores positivos");
        Console.ReadKey();
    }

}