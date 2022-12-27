﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Beecrowd1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double raio = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double volume = (4.0 / 3) * pi * Math.Pow(raio, 3);

            Console.WriteLine("VOLUME = {0}", volume.ToString("f3", CultureInfo.InvariantCulture));
            
            Console.ReadKey();
        }
    }
}
