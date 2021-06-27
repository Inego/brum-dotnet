using System;
using System.Linq;
using Inego.Birmingham.Game.State;

namespace Polygon
{
    internal static class Program
    {
        public static void Main()
        {
            foreach (var (idx, income) in GameState.IncomeSteps.Select((income, idx) => ( idx, income )))
            {
                Console.Out.WriteLine($"{idx}:{income}");
            }
        }
    }
}