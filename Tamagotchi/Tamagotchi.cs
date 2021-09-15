using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class Tamagotchi
    {
        private int hunger;
        private int boredom;

        private int continueplaying = 1;

        private List<string> words = new List<string>();

        private bool isalive = true;

        private Random generator = new Random();

        public string name;
        public string playerName;


        public void PlayAgain()
        {


            while (continueplaying == 1)
            {

                Console.WriteLine("Din tamagotchi dog, vill du spela igen?", Console.ForegroundColor = ConsoleColor.White);


                string answer = Console.ReadLine();

                if (answer.ToLower() == "ja")
                {
                    Console.Clear();

                    //RunGame(); //jag måste köra main här
                }
                else if (answer.ToLower() == "nej")
                {
                    continueplaying = 0;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ogiltigt svar! Svara bara ja eller nej. \n");

                }


            }
        }

        public void Feed()
        {

        }

        public void Hi()
        {

        }

        private string word = "";

        public void Teach(string word)
        {
            words.Add(word);

        }

        public void Tick()
        {

            hunger += generator.Next(1, 3);
            boredom += generator.Next(1, 3);

            if (hunger >= 10 || boredom >= 10)
            {
                isalive = false;


                PlayAgain();

            }

        }

        public void PrintStats()
        {
            System.Console.WriteLine($"{name} har {hunger} i hunger");
            System.Console.WriteLine($"{name} har {boredom} i boredom");

        }

        public bool GetAlive()
        {
            return isalive;
        }

        private void ReduceBoredom()
        {
            boredom--;
        }




    }


}