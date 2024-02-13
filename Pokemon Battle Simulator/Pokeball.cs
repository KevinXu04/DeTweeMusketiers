using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator
{
    class Pokeball
    {
        public bool isOpen;
        public Pokemon pokemon;
        public bool used = false;

        public Pokeball(Pokemon pokemon)
        {
            this.pokemon = pokemon;
        }

        public void Open()
        {
            isOpen = true;
        }

        public void Close()
        {
            isOpen = false;
        }

        public void Use()
        {
            used = true;
        }

        public bool IsOpen()
        {
            return isOpen;
        }
    }
}
