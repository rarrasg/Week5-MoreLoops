﻿using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt kasutajatunnust ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!"
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."
            //kasutajal on kolm katset

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna:");
                string userPassword = Console.ReadLine();

                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else if (i < 2)
                {
                    i++;                                  
                    Console.WriteLine($"Vale kasutajatunnus või salasõna. Proovi uuesti, katseid alles {3 - i}. ");                                
                }
                else
                {
                    Console.WriteLine($"Vale kasutajatunnus või salasõna. Katsed on otsas, sisselogimine blokeeritud. ");
                    break;
                }
            }



        }
    }
}