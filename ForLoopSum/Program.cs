using System;

namespace ForLoopSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada kolm numbrit
            //programm kuvab nende numbrite summat

            int sum = 0;

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Siesta number:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                sum = sum + userNumber;

                
            }

            Console.WriteLine($"Sinu summa on: {sum}");
        }
    }
}
