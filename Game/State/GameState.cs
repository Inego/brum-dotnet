using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;

namespace Inego.Birmingham.Game.State
{
    public class GameState
    {
        public static readonly ImmutableArray<int> IncomeSteps = IncomeStepsList();

        static GameState()
        {
            
            
            // IncomeSteps = IncomeStepsList().ToArray();
        }

        private static ImmutableArray<int> IncomeStepsList()
        {
            var list = ImmutableArray.CreateBuilder<int>();

            var currentIncome = -10;

            void AddLevels(int numberOfSteps, int numberOfLevels)
            {
                for (var i = 0; i < numberOfLevels; i++)
                {
                    for (var j = 0; j < numberOfSteps; j++)
                    {
                        list.Add(currentIncome);
                    }

                    currentIncome++;
                }
            }
            
            AddLevels(1, 11);
            AddLevels(2, 10);
            AddLevels(3, 10);
            AddLevels(4, 9);
            AddLevels(3, 1);

            return list.ToImmutable();
        }


        public Era Era { get; private set; }
        public int NumberOfPlayers { get; set; }
        public int CurrentPlayerIdx { get; set; }
        public PlayerState[] PlayerOrder { get; set; }
    }
}