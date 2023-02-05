using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp60Ass2
{
    
    class Game
    {
        private static string[] wordBank = new string[] { "it", "big", "entertainment", "cool" };
        private static int[] prizeAmt = new int[] {50, 30, 20,10 };
        public string TargetWords { get; set; }
        public int PlayerNo { get; set; }
        public int CurrentScore { get; set; }
     

        //constructor
        public Game()
        {
            TargetWords = generateRandomWord();
            PlayerNo = 0;
            CurrentScore = 0;
        }

        //function to assign the target word a random value
        string generateRandomWord()
        {
            int index;
            Random randomGenerator = new Random();
            index = randomGenerator.Next(4) ;

            return wordBank[index];
        }

        //function to generate random currentScore
        public void generateScore()
        {
            int index;

            Random randomGenerator = new Random();
            index = randomGenerator.Next(4) ;

            CurrentScore = prizeAmt[index];
          
        }
        

    }
}
