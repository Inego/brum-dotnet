﻿namespace Inego.Birmingham.Game.Map
{
    public class MerchantReward
    {
        public string Name { get; }

        public MerchantReward(string name)
        {
            Name = name;
        }
    }

    class FreeDevelopReward : MerchantReward
    {
        public FreeDevelopReward() : base("Free develop")
        {
        }
    }

    class VictoryPointsReward : MerchantReward
    {
        public int Vp { get; }

        public VictoryPointsReward(int vp) : base($"{vp} VP")
        {
            Vp = vp;
        }
    }

    class MoneyReward : MerchantReward
    {
        public int Amount { get; }

        public MoneyReward(int amount) : base($"£{amount}")
        {
            Amount = amount;
        }
    }

    class IncomeReward : MerchantReward
    {
        public int Amount { get; }

        public IncomeReward(int amount) : base($"Income +£{amount}")
        {
            Amount = amount;
        }
    }
}