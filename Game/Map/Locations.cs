namespace Inego.Birmingham.Game.Map
{
    public class IndustrySlot : IIndustryCount
    {
        public IndustrySlot Slot => this;
        public int Count => 1;

        public DoubleIndustrySlot Double() => new (this);
    }

    public class DoubleIndustrySlot : IIndustryCount
    {
        public DoubleIndustrySlot(IndustrySlot slot)
        {
            Slot = slot;
        }

        public IndustrySlot Slot { get; }
        public int Count => 2;
    }

    public interface IIndustryCount
    {
        IndustrySlot Slot { get; }
        int Count { get; }
    }


    public class DoubleSlot : IndustrySlot
    {
        public Industry Industry1 { get; }
        public Industry Industry2 { get; }

        public DoubleSlot(Industry industry1, Industry industry2)
        {
            Industry1 = industry1;
            Industry2 = industry2;
        }
    }

    public abstract class Location
    {
        protected Location(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract bool IsMerchant();
    }

    public class Buildable : Location
    {
        public IIndustryCount[] Slots { get; }
        
        public Buildable(string name, params IIndustryCount[] slots) : base(name)
        {
            Slots = slots;
        }
        
        public sealed override bool IsMerchant() => false;
    }

    /**
     * Any place with build slots (incl. beer breweries without corresponding cards).
     */
    public class Town : Buildable, ICardStats
    {
        /**
         * Count of this card in the 2-player deck.
         */
        public int C2 { get; }

        /**
         * Count of this card in the 3-player deck.
         */
        public int C3 { get; }

        /**
         * Count of this card in the 4-player deck.
         */
        public int C4 { get; }

        public Town(string name, int c2, int c3, int c4, params IIndustryCount[] slots) : base(name, slots)
        {
            C2 = c2;
            C3 = c3;
            C4 = c4;
        }
    }

    public class Merchant : Location
    {
        public int SincePlayerCount { get; }
        
        public int SlotCount { get; }
        
        public MerchantReward Reward { get; }

        public Merchant(string name, int sincePlayerCount, int slotCount, MerchantReward reward) : base(name)
        {
            SincePlayerCount = sincePlayerCount;
            SlotCount = slotCount;
            Reward = reward;
        }

        public override bool IsMerchant() => true;
    }
}