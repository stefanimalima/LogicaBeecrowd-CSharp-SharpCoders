﻿using System;

namespace Beecrowd1061
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {

                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}