using System;

class URI
{

    static void Main(string[] args)
    {

        string[] input = Console.ReadLine().Split(' ');

        double A = double.Parse(input[0]);
        double B = double.Parse(input[1]);
        double C = double.Parse(input[2]);
        
        double perimetro = (A + B + C);
        double area = (((A + B) * C) / 2);

        if (A < (B + C) && C < (A + B) && B < (A + C))
        {
            Console.WriteLine($"Perimetro = {perimetro:F1}");
        }
        else
        {
            Console.WriteLine($"Area = {area:F1}");
        }
    }

}