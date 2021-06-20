namespace Inego.Birmingham.Game.Map
{
    class IndustrySlot : IIndustryCount
    {
        public IndustrySlot Slot => this;
        public int Count => 1;
    }

    interface IIndustryCount
    {
        IndustrySlot Slot { get; }
        int Count { get; }
    }

    abstract class Industry : IndustrySlot
    {
        protected Industry(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }

    class DoubleSlot : IndustrySlot
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

        public abstract bool ProvidesCoal();
    }

    /**
     * Any place with build slots (incl. beer breweries without corresponding cards).
     */
    public class Town : Location
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

        public Town(string name, int c2, int c3, int c4) : base(name)
        {
            C2 = c2;
            C3 = c3;
            C4 = c4;
        }

        public override bool ProvidesCoal() => false;
    }

    public class Merchant : Location
    {
        public Merchant(string name) : base(name)
        {
        }

        public override bool ProvidesCoal() => true;
    }
}