using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, vad vill du döpa din tamagotchi");
            string name = Console.ReadLine();

            Tamagotchi tama = new Tamagotchi();

            tama.Teach("teknik");
            tama.Tick();
            tama.PrintStats();

            // while (tama.GetAlive())
            // {

            // }



            Console.ReadLine();


        }
    }
}
