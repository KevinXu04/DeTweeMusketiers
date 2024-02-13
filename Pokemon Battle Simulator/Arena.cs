using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator
{
    class Arena
    {
        public static int rounds = 0;
        public static int battles = 0;

        public static int roundsAddUp()
        {
            rounds++;
            return rounds;
        }

        public static int battlesAddUp()
        {
            battles++;
            return battles; 
        }
    }
}
