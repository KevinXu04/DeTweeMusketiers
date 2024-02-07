using Pokemon_Battle_Simulator;

namespace Pokemon_Battle_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokemon charmander = new Pokemon("Charmander", "Fire", "Water");

            for (int i = 1; i < 3; i++)
            {
                Pokeball pokeball1 = new Pokeball(charmander);
                List<Pokeball> belt = new List<Pokeball>();
                for (int x = 0; x < 7; x++)
                {
                    belt.Add(pokeball1);
                }

                Console.WriteLine($"Choose a name for trainer {i}.");
                string trainerName = Console.ReadLine();
                Trainer trainer = new Trainer(trainerName, belt);

                Console.WriteLine($"{trainerName} has:");
                foreach (Pokeball ball in belt)
                {
                    Console.WriteLine(ball.pokemon.pokemon);
                }
            }


            for (int i = 0; i <= 10; i++)
            {
                charmander.battleCry();
            }

        }
    }

    class Pokemon
    {
        public string pokemon;
        public string strength;
        public string weakness;

        public Pokemon(string pokemon, string strength, string weakness)
        {
            this.pokemon = pokemon;
            this.strength = strength;
            this.weakness = weakness;
        }

        public void battleCry()
        {
            Console.WriteLine(this.pokemon + ": " + this.pokemon + "!");
        }
    }
}

class Pokeball
{
    public bool isOpen;
    public Pokemon pokemon;

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

    public bool IsOpen()
    {
        return isOpen;
    }
}

class Trainer
{
    public string name;
    public List<Pokeball> belt;

    public Trainer(string name, List<Pokeball> belt)
    {
        this.name = name;
        this.belt = belt;
    }

}