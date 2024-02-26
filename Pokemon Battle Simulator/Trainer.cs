using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator
{
    class Trainer
    {
        private string name;
        private List<Pokeball> _belt;

        // Constant to replace magic number
        private const int MaxPokeballsOnBelt = 6;
        readonly object belt;


        public string Name 
        {
            get { return name; }
            private set { name = value; }
        }
        public List<Pokeball> Belt
        {
            get { return _belt; }
        }

        public Trainer(string name, List<Pokeball> belt)
        {
            if (belt.Count > MaxPokeballsOnBelt)
            {
                throw new ArgumentException($"The number of pokeballs on the belt cannot exceed {MaxPokeballsOnBelt}.");
            }

            Name = name;
            _belt = belt;
        }   

        public void Call()
        {
            Console.WriteLine($"{Name} is being called!");

            Console.WriteLine($"{Name} has:");
            foreach (Pokeball ball in _belt)
            {
                Console.WriteLine(ball.PokemonName.PokemonName);
            }
        }
    }
}
