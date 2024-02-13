using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator
{
    abstract class Pokemon
    {
        public string pokemon;
        public string nickname;
        public string strength;
        public string weakness;

        public Pokemon(string pokemon, string nickname, string strength, string weakness)
        {
            this.pokemon = pokemon;
            this.nickname = nickname;
            this.strength = strength;
            this.weakness = weakness;
        }

        public abstract void battleCry();
    }

    class Squirtle : Pokemon
    {
        public Squirtle(string nickname) : base("Squirtle", nickname, "Water", "Leaf")
        {
        }

        public override void battleCry()
        {
            Console.WriteLine(this.pokemon + " uses battle cry: " + this.nickname + "!");
        }
    }

    class Bulbasaur : Pokemon
    {
        public Bulbasaur(string nickname) : base("Bulbasaur", nickname, "Grass", "Fire")
        {
        }

        public override void battleCry()
        {
            Console.WriteLine(this.pokemon + " uses battle cry: " + this.nickname + "!");
        }
    }

    class Charmander : Pokemon
    {
        public Charmander(string nickname) : base("Charmander", nickname, "Water", "Leaf")
        {
        }

        public override void battleCry()
        {
            Console.WriteLine(this.pokemon + " uses battle cry: " + this.nickname + "!");
        }
    }
}
