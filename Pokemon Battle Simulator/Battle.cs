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
        public List<Trainer> trainersLst;

        public Battle(List<Trainer> trainersLst)
        {
            this.trainersLst = trainersLst;
            Battle.battle(trainersLst);
        }

        public static void battle(List<Trainer> trainersLst)
        {
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

                Console.WriteLine($"Current round: {Arena.roundsAddUp()}");

                // Trainer 1 recall
                Console.WriteLine($"Trainer {trainersLst[0].name} recalls {i + 1}. {trainersLst[0].belt[i].pokemon.pokemon}!");
                trainersLst[0].belt[i].Close();

                // Trainer 2 recall
                Console.WriteLine($"Trainer {trainersLst[1].name} recalls {i + 1}. {trainersLst[1].belt[i].pokemon.pokemon}!");
                trainersLst[1].belt[i].Close();

                Console.WriteLine($"Current battle round: {Arena.battlesAddUp()}");
            }
        }
    }
}
