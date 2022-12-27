using System;

namespace Beecrowd1131
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Gremio, Inter;
            int VitGremio = 0;
            int VitInter = 0;
            int Aux = 0;
            int AuxGrenais = 0;
            int Empates = 0;

            do
            {

                string[] vetor = Console.ReadLine().Split(' ');
                Inter = int.Parse(vetor[0]);
                Gremio = int.Parse(vetor[1]);

                if (Gremio > Inter)
                {
                    VitGremio++;
                }
                else if (Inter > Gremio)
                {
                    VitInter++;
                }
                else
                {
                    Empates++;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                AuxGrenais = AuxGrenais + 1;


                Aux = int.Parse(Console.ReadLine());
            } while (Aux != 2);

            Console.WriteLine(AuxGrenais + " grenais");
            Console.WriteLine("Inter:" + VitInter);
            Console.WriteLine("Gremio:" + VitGremio);
            Console.WriteLine("Empates:" + Empates);

            if (VitGremio > VitInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else if (VitInter > VitGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else
            {
                Console.WriteLine("Nãoo houve vencedor");
            }
        }
    }
}
