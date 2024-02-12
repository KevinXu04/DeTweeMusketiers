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
            // Creating the pokemons
            // Pokemon charmander = new Pokemon("Charmander", "nickname", "Fire", "Water");
            Squirtle squirtle = new Squirtle("Waterman");
            Bulbasaur bulbasaur = new Bulbasaur("Grassman");
            Charmander charmander = new Charmander("Fireman");

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
                        Pokeball pokeballSqui = new Pokeball(squirtle);
                        Pokeball pokeballBulb = new Pokeball(bulbasaur);
                        Pokeball pokeballChar = new Pokeball(charmander);
                        for (int x = 0; x < 2; x++)
                        {
                            belt.Add(pokeballSqui);
                            belt.Add(pokeballBulb);
                            belt.Add(pokeballChar);
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

                
                Battle.battle(trainersLst);

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
}