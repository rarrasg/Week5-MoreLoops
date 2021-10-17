using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user)
            //mõlemad mängijad viskavad täringut
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskab rohkem, on mängu võitja
            //*täringuid visatakse kolm korda
            //programm kuulutab võitja

            Random rnd = new Random();

            

            int cpuScore = 0;
            int userScore = 0;

            for(int throwRound = 0;throwRound < 3; throwRound++)
            {
                int cpuRandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");

                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja on viske võitnud.");
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti on viske võitnud.");
                    cpuScore = cpuScore + 1;
                }
                else
                {
                    Console.WriteLine("Vise jäi viiki!");
                }
            }

            if (userScore > cpuScore)
            {
                Console.WriteLine("Kasutaja võitis mängu. Palju õnne!");
            }
            else if (userScore < cpuScore)
            {
                Console.WriteLine("Arvuti võitis mängu");
            }
            else
            {
                Console.WriteLine("Mäng jäi viiki");
            }            
        }
    }
}
