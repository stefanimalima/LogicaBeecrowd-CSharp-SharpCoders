using System;

class URI
{

    static void Main(string[] args)
    {

        string[] horas = Console.ReadLine().Split();
        int H1 = int.Parse(horas[0]);
        int H2 = int.Parse(horas[1]);
        int X = 24;

        if (H1 > H2)
        {
            X = X - H1 + H2;
            Console.WriteLine($"O JOGO DUROU {X} HORA(S)");
        }
        else if (H1 < H2)
        {
            X = H2 - X + X - H1;
            Console.WriteLine($"O JOGO DUROU {X} HORA(S)");
        }
        else if (H1 == H2)
        {
            Console.WriteLine($"O JOGO DUROU 24 HORA(S)");
        }
    }

}