using Pokemon_Battle_Simulator;
using System;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace Pokemon_Battle_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating charmander
            Pokemon charmander = new Pokemon("Charmander", "Fire", "Water");

            // Creating trainer's belt with 6 pokeballs
            List<Pokeball> belt = new List<Pokeball>();

            // Creating list with all trainers
            List<Trainer> trainersLst = new List<Trainer>();

            bool gameStart = true;

            // For restarting game
            while (gameStart)
            {
                bool question = true;

                // For loop which creates two trainers
                for (int i = 1; i < 3; i++)
                {
                    try
                    {
                        // Creating pokeball with Charmander inside and using a for loop to add the pokeballs inside the belt
                        Pokeball pokeball = new Pokeball(charmander);
                        for (int x = 0; x < 6; x++)
                        {
                            belt.Add(pokeball);
                        }

                        // The user can choose a name for the trainers
                        Console.WriteLine($"Choose a name for trainer {i}.");
                        string trainerName = Console.ReadLine();

                        // This creates the trainer with the user's chosen name
                        Trainer trainer = new Trainer(trainerName, belt);

                        // The newly created trainer will be added to the list of trainers 
                        trainersLst.Add(trainer);
                    }
                    catch (Exception ex)
                    {
                        // Error message
                        Console.WriteLine($"Error: " + ex.Message);
                    }

                }

                // Displaying all pokemons
                trainersLst[0].Call();
                trainersLst[1].Call();

                for (int i = 0; i < 6; i++)
                {
                    // Trainer 1 throw
                    Console.WriteLine($"Trainer {trainersLst[0].name} throws {i + 1}. {trainersLst[0].belt[i].pokemon.pokemon}");
                    trainersLst[0].belt[i].Open();
                    trainersLst[0].belt[i].pokemon.battleCry();

                    // Trainer 2 throw
                    Console.WriteLine($"Trainer {trainersLst[1].name} throws {i + 1}. {trainersLst[1].belt[i].pokemon.pokemon}");
                    trainersLst[1].belt[i].Open();
                    trainersLst[1].belt[i].pokemon.battleCry();

                    // Trainer 1 recall
                    Console.WriteLine($"Trainer {trainersLst[0].name} recalls {i + 1}. {trainersLst[0].belt[i].pokemon.pokemon}!");
                    trainersLst[0].belt[i].Close();
                    trainersLst[0].belt[i].pokemon.battleCry();

                    // Trainer 2 recall
                    Console.WriteLine($"Trainer {trainersLst[1].name} recalls {i + 1}. {trainersLst[1].belt[i].pokemon.pokemon}!");
                    trainersLst[1].belt[i].Close();
                    trainersLst[1].belt[i].pokemon.battleCry();
                }

                while (question)
                {
                    // Asking if the user wants to restart the game
                    Console.WriteLine("Do you want to quit or restart?");
                    string answer = Console.ReadLine();
                    if (answer == "quit")
                    {
                        gameStart = false;
                        break;
                    }
                    else if (answer == "restart")
                    {
                        question = false;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid answer");
                    }
                }
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
            Console.WriteLine(this.pokemon + " uses battle cry: " + this.pokemon + "!");
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