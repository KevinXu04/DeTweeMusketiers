using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Pokemon_Battle_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a name for your Charmander.");
            string name = Console.ReadLine();
            Pokemon charmander = new Pokemon("Charmander", name, "Fire", "Water");
            Console.WriteLine("Your Charmander's nick name is: " + charmander.getName());

            while (true)
            {
                for (int i = 0; i <= 10; i++)
                {
                    charmander.battleCry();
                }

                Console.WriteLine("Choose a name for your Charmander. To quit type 'quit'.");
                name = Console.ReadLine();
                charmander.setName(name);
                if (name == "quit")
                {
                    break;
                }
            }
        }
    }

    class Pokemon
    {
        public string pokemon;
        public string name;
        public string strength;
        public string weakness;

        public Pokemon(string pokemon, string name, string strength, string weakness)
        {
            this.pokemon = pokemon;
            this.name = name;
            this.strength = strength;
            this.weakness = weakness;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void battleCry()
        {
            Console.WriteLine(this.pokemon + ": " + this.name + "!");
        }
    }
}