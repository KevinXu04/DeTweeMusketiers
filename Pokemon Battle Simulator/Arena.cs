using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator
{
    class Arena
    {
        private static int _rounds = 0;
        private static int _battles = 0;

        public static int Rounds
        {
            get { return _rounds; }
            private set { _rounds = value; }
        }

        public static int Battles
        {
            get { return _battles; }
            private set { _battles = value; }
        }
        public static int roundsAddUp()
        {
            return ++Rounds; 
        }

        public static int battlesAddUp()
        {
            return ++Battles; 
        }
   
    }
}
