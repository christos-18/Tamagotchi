using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hej, vad vill du döpa din tamagotchi");
            string name = Console.ReadLine();

            Tamagotchi tama = new Tamagotchi();

            int i = 10;
            while (i > 0)
            {

                i--;




                tama.Teach("teknik");
                tama.Tick();
                tama.PrintStats();






                Console.ReadLine();

            }

        }
    }
}
