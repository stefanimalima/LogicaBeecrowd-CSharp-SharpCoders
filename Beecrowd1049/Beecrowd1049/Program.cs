using System;

namespace Alternative1049
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tipo_1 = Console.ReadLine();
            string tipo_2 = Console.ReadLine();
            string tipo_3 = Console.ReadLine();

            if (tipo_1.Equals("vertebrado", StringComparison.InvariantCultureIgnoreCase))
            {
                if (tipo_2.Equals("ave", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (tipo_3.Equals("carnivoro", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (tipo_3.Equals("onivoro", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (tipo_2.Equals("mamifero", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (tipo_3.Equals("onivoro", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("homem");
                    }
                    else if (tipo_3.Equals("herbivoro", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("vaca");
                    }
                }

            }
            else if (tipo_1.Equals("invertebrado", StringComparison.InvariantCultureIgnoreCase))
            {
                if (tipo_2.Equals("inseto", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (tipo_3.Equals("hematofago", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (tipo_3.Equals("herbivoro", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (tipo_2.Equals("anelideo", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (tipo_3.Equals("hematofago", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (tipo_3.Equals("onivoro", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}