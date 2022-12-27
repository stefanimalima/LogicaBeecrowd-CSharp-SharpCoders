using System;

class URI
{

    static void Main(string[] args)
    {
        for (int j = 60, i = 1; j >= 0; j = j - 5, i = i + 3)
        {
            Console.WriteLine($"I={i} J={j}");
        }
    }
}