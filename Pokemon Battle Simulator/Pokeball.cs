using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pokemon_Battle_Simulator
{
    class Pokeball
    {
        private bool isOpen;
        internal bool used;
        private Pokemon _pokemon;


        public bool _isOpen
        {
            get { return isOpen; }
        }
        public bool Used
        {
            get { return used; }
            private set { used = value; }
        }
        public Pokemon PokemonName
        {
            get { return _pokemon; }
        }

        public Pokeball(Pokemon pokemon)
        {
            _pokemon = pokemon;
            used = false;
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
