using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            int g1, g2;
            string time1, time2;

            Console.WriteLine("Qual nome do time 1?");
            time1 = Console.ReadLine();
            Console.WriteLine("Qual nome do time 2?");
            time2 = Console.ReadLine();

            Console.WriteLine("Quantos gols o time 1 marcou?");
            g1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos gols o time 2 marcou?");
            g2 = int.Parse(Console.ReadLine());

            if (g1>g2){
                Console.WriteLine(time1 + " é o vencedor!");
            }
            else{
                 Console.WriteLine(time2 + " é o vencedor!");
            }
            if (g1==g2){
                Console.WriteLine("Empate entre os times " + time1 + " e " + time2 + " em " + g1 + " a " + g2);
            }

        }
    }
}
