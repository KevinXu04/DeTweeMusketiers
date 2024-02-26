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
            Random RP = new Random();

            // Creating the pokemons
            // Pokemon charmander = new Pokemon("Charmander", "nickname", "Fire", "Water");
            Squirtle squirtle = new Squirtle("Waterman");
            Bulbasaur bulbasaur = new Bulbasaur("Grassman");
            Charmander charmander = new Charmander("Fireman");

            // Creating trainer's belt with 6 pokeballs
            List<Pokeball> belt1 = new List<Pokeball>();
            List<Pokeball> belt2 = new List<Pokeball>();

            // Creating list with all trainers
            List<Trainer> trainersLst = new List<Trainer>();

            bool gameStart = true;

            // For restarting game
            while (gameStart)
            {
                bool question = true;

                // For loop which creates two trainers
                    try
                    {
                        // Creating pokeball with Charmander inside and using a for loop to add the pokeballs inside the belt
                        belt1.Add(new Pokeball(squirtle));
                        belt1.Add(new Pokeball(squirtle));
                        belt1.Add(new Pokeball(bulbasaur));
                        belt1.Add(new Pokeball(bulbasaur));
                        belt1.Add(new Pokeball(charmander));
                        belt1.Add(new Pokeball(charmander));

                        belt2.Add(new Pokeball(squirtle));
                        belt2.Add(new Pokeball(squirtle));
                        belt2.Add(new Pokeball(bulbasaur));
                        belt2.Add(new Pokeball(bulbasaur));
                        belt2.Add(new Pokeball(charmander));
                        belt2.Add(new Pokeball(charmander));

                        // The user can choose a name for the trainers
                        Console.WriteLine($"Choose a name for trainer 1.");
                        string trainerName1 = Console.ReadLine();

                        Console.WriteLine($"Choose a name for trainer 2.");
                        string trainerName2 = Console.ReadLine();

                        // This creates the trainer with the user's chosen name
                        Trainer trainer1 = new Trainer(trainerName1, belt1);
                        Trainer trainer2 = new Trainer(trainerName2, belt2);

                        // The newly created trainer will be added to the list of trainers 
                        trainersLst.Add(trainer1);
                        trainersLst.Add(trainer2);
                }
                    catch (Exception ex)
                    {
                        // Error message
                        Console.WriteLine($"Error: " + ex.Message);
                    }

                

                
                Battle.battle(trainersLst, RP);

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