using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator
{
    class Battle
    {
        public List<Trainer> trainersLst { get; private set; }
        public Random RP = new Random();

        public Battle(List<Trainer> trainersLst)
        {
            this.trainersLst = trainersLst;
            Battle.battle(trainersLst, RP);
        }

        public static Pokemon ThrowBall(Trainer trainer, Random RP)
        {
            int RPI = RP.Next(0, trainer.Belt.Count); // Picking a random pokeball

            // If its already used it will search for another one
            while (trainer.Belt[RPI].Used)
            {
                RPI = RP.Next(0, trainer.Belt.Count);
            }

            // Mark the Pokeball as used
            trainer.Belt[RPI].used = true;

            // Returning the Pokemon
            return trainer.Belt[RPI].PokemonName;
        }

        public static void battle(List<Trainer> trainersLst, Random RP)
        {
            Console.WriteLine("test");
            // Displaying all pokemons
            trainersLst[0].Call();
            trainersLst[1].Call();
            int round = 1;
            string winner = "";

            Console.WriteLine(round);
            // Trainer 1 Turn
            Pokemon trainer1Pokemon = ThrowBall(trainersLst[0], RP);
            Console.WriteLine($"Trainer {trainersLst[0].Name} throws {round}. {trainer1Pokemon.PokemonName}");
            trainersLst[0].Belt[round - 1].Open();
            trainer1Pokemon.battleCry();

            // Trainer 2 Turn
            Pokemon trainer2Pokemon = ThrowBall(trainersLst[1], RP);
            Console.WriteLine($"Trainer {trainersLst[1].Name} throws {round}. {trainer2Pokemon.PokemonName}");
            trainersLst[1].Belt[round - 1].Open();
            trainer2Pokemon.battleCry();

            while (!trainersLst[0].Belt.All(p => p.Used) == !trainersLst[1].Belt.All(p => p.Used))
            {
                if (winner == trainersLst[0].Name)
                {
                    trainer1Pokemon = ThrowBall(trainersLst[0], RP);
                    Console.WriteLine($"Trainer {trainersLst[0].Name} throws {round}. {trainer1Pokemon.PokemonName}");
                    // trainersLst[0].belt[round - 1].Open();
                    trainer1Pokemon.battleCry();

                    trainer2Pokemon.battleCry();
                } else
                {
                    trainer2Pokemon = ThrowBall(trainersLst[1], RP);
                    Console.WriteLine($"Trainer {trainersLst[1].Name} throws {round}. {trainer2Pokemon.PokemonName}");
                    // trainersLst[1].belt[round - 1].Open();
                    trainer2Pokemon.battleCry();

                    trainer1Pokemon.battleCry();
                }

                Console.WriteLine($"Current round: {Arena.roundsAddUp()}");

                // Check if any trainer has run out of Pokémon
                if ((trainer1Pokemon.PokemonType == PokemonType.Fire && trainer2Pokemon.PokemonType == PokemonType.Grass) ||
                    (trainer1Pokemon.PokemonType == PokemonType.Grass && trainer2Pokemon.PokemonType == PokemonType.Water) ||
                    (trainer1Pokemon.PokemonType == PokemonType.Water && trainer2Pokemon.PokemonType == PokemonType.Fire))
                {
                    Console.WriteLine(trainersLst[0].Name + " wins the battle!");
                    winner = trainersLst[0].Name;

                    // Trainer 2 recall
                    Console.WriteLine($"Trainer {trainersLst[1].Name} recalls {trainer2Pokemon.PokemonName}!");
                    // trainersLst[1].belt[round - 1].Close();
                }
                else if ((trainer2Pokemon.PokemonType == PokemonType.Fire && trainer1Pokemon.PokemonType == PokemonType.Grass) ||
                        (trainer2Pokemon.PokemonType == PokemonType.Grass && trainer1Pokemon.PokemonType == PokemonType.Water) ||
                        (trainer2Pokemon.PokemonType == PokemonType.Water && trainer1Pokemon.PokemonType == PokemonType.Fire))
                {
                    Console.WriteLine(trainersLst[1].Name + " wins the battle!");
                    winner = trainersLst[1].Name;

                    // Trainer 1 recall
                    Console.WriteLine($"Trainer {trainersLst[0].Name} recalls {trainer1Pokemon.PokemonName}!");
                    // trainersLst[0].belt[round - 1].Close();
                }
                else
                {
                    Console.WriteLine("It's a tie! No one wins the battle.");
                }

                Console.WriteLine($"Current battle round: {Arena.battlesAddUp()}");
                round++;
            }
        }

    }
}
