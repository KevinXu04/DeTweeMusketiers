using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator
{
    class Trainer
    {
        public string name;
        public List<Pokeball> belt;

        public Trainer(string name, List<Pokeball> belt)
        {
            this.name = name;
            this.belt = belt;
        }

        public void Call()
        {
            Console.WriteLine($"{name} is being called!");

            Console.WriteLine($"{name} has:");
            foreach (Pokeball ball in belt)
            {
                Console.WriteLine(ball.pokemon.pokemon);
            }
        }
    }
}
