using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator { 
    public enum PokemonType
    {
        Fire,
        Water,
        Grass
    }
    public enum Strength
    {
        Fire,
        Water,
        Grass
    }

    public enum Weakness
    {
        Fire,
        Water,
        Grass
    }

    abstract class Pokemon
    {
        private string pokemon;
        private string nickname;
        private PokemonType pokemontype;
        private Strength strength;
        private Weakness weakness;

        public string PokemonName
        {
            get { return pokemon;}
            private set { pokemon = value; }  
        }
        public string Nickname
        {
            get { return nickname; }
            private set { nickname = value; }
        }
        public PokemonType PokemonType
    {
            get { return pokemontype; }
            private set { pokemontype = value; }
        }
        public Strength Strength
        {
            get { return strength; }
            private set { strength = value; }
        }
        public Weakness Weakness
        {
            get { return weakness; }
            private set { weakness = value; }
        }

        protected Pokemon(string pokemon, string nickname, PokemonType pokemontype, Strength strength, Weakness weakness)
        {
            PokemonName = pokemon;
            Nickname = nickname;
            PokemonType = pokemontype;
            Strength = strength;
            Weakness = weakness;
        }

        public abstract void battleCry();
    }

    sealed class Squirtle : Pokemon
    {
        public Squirtle(string nickname) : base("Squirtle", nickname, PokemonType.Water, Strength.Water, Weakness.Grass)
        {
        }

        public override void battleCry()
        {
            Console.WriteLine(this.PokemonName + " uses battle cry: " + Nickname + "!");
        }
    }

    sealed class Bulbasaur : Pokemon
    {
        public Bulbasaur(string nickname) : base("Bulbasaur", nickname, PokemonType.Grass, Strength.Grass, Weakness.Fire)
        {
        }

        public override void battleCry()
        {
            Console.WriteLine(this.PokemonName + " uses battle cry: " + Nickname + "!");
        }
}

    sealed class Charmander : Pokemon
    {
        public Charmander(string nickname) : base("Charmander", nickname, PokemonType.Fire, Strength.Fire, Weakness.Water)
        {
        }

        public override void battleCry()
        {
            Console.WriteLine(this.PokemonName + " uses battle cry: " + Nickname + "!");
        }
    }
}
