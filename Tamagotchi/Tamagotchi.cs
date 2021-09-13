using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class Tamagotchi
    {
        private int hunger;
        private int boredom;

        private List<string> words = new List<string>();

        bool isalive = true;

        private Random generator = new Random();

        public string name;

            public void Feed()
             {
                
             }

             public void Hi()
             {

             }

            private string word = "";
  
             public void Teach()
              {
                Console.WriteLine(this.word);
              }

              public void Tick()
              {

              }

              public void PrintStats()
              {

              }

              public bool GetAlive()
              {
                return isalive;

              }

              private void ReduceBoredom()
              {
                  
              }

        

      
      }   
      

    }      