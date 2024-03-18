using System;
using System.Collections.Generic;

namespace Pokemon_Battle_Simulator
{
    internal class Program
    {
        enum UserChoice
        {
            Quit,
            Restart,
            Invalid
        }

        static void Main(string[] args)
        {
            bool gameStart = true;

            while (gameStart)
            {
                List<Trainer> trainers = InitializeTrainers();

                Battle.battle(trainers, new Random());

                switch (GetUserDecision())
                {
                    case UserChoice.Quit:
                        gameStart = false;
                        break;
                    case UserChoice.Restart:
                        // Automatically restarts
                        break;
                    case UserChoice.Invalid:
                        Console.WriteLine("That is not a valid answer.");
                        break;
                }
            }
        }

        static List<Trainer> InitializeTrainers()
        {
            var trainers = new List<Trainer>();

            var squirtle = new Squirtle("Waterman");
            var bulbasaur = new Bulbasaur("Grassman");
            var charmander = new Charmander("Fireman");

            var belt1 = InitializeBelt(squirtle, bulbasaur, charmander);
            var belt2 = InitializeBelt(squirtle, bulbasaur, charmander);

            Console.WriteLine($"Choose a name for trainer 1.");
            string trainerName1 = Console.ReadLine();
            Console.WriteLine($"Choose a name for trainer 2.");
            string trainerName2 = Console.ReadLine();

            trainers.Add(new Trainer(trainerName1, belt1));
            trainers.Add(new Trainer(trainerName2, belt2));

            return trainers;
        }

        static List<Pokeball> InitializeBelt(Squirtle squirtle, Bulbasaur bulbasaur, Charmander charmander)
        {
            return new List<Pokeball>
            {
                new Pokeball(squirtle), new Pokeball(squirtle),
                new Pokeball(bulbasaur), new Pokeball(bulbasaur),
                new Pokeball(charmander), new Pokeball(charmander)
            };
        }

        static UserChoice GetUserDecision()
        {
            Console.WriteLine("Do you want to quit or restart?");
            string answer = Console.ReadLine().ToLower();

            return answer switch
            {
                "quit" => UserChoice.Quit,
                "restart" => UserChoice.Restart,
                _ => UserChoice.Invalid,
            };
        }
    }
}
