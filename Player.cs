using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp60Ass2
{
     class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int NoWins { get; set; }
        public int NoLoses { get; set; }

        //constructor
        public Player(string initialName)
        {
            Name = initialName;
            Score = 0;
            NoWins = 0;
            NoLoses = 0;
        }
    }
}
