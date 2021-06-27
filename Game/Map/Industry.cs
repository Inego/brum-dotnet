namespace Inego.Birmingham.Game.Map
{
    public class Industry : IndustrySlot
    {
        private Industry(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public static Industry IronWorks { get; } = new("Iron works");
        public static Industry CoalMine { get; } = new("Coal mine");
        public static Industry Brewery { get; } = new("Brewery");
        public static Industry CottonMill { get; } = new("Cotton mill");
        public static Industry Goods { get; } = new("Mfg. goods");
        public static Industry Pottery { get; } = new("Pottery");

        public static DoubleSlot CottonGoods { get; } = new(CottonMill, Goods);
        public static DoubleSlot CottonBrewery { get; } = new(CottonMill, Brewery);
        public static DoubleSlot CottonCoal { get; } = new(CottonMill, CoalMine);
        public static DoubleSlot PotteryIron { get; } = new(Pottery, IronWorks);
        public static DoubleSlot GoodsCoal { get; } = new(Goods, CoalMine);
        public static DoubleSlot GoodsIron { get; } = new(Goods, IronWorks);
        public static DoubleSlot GoodsBrewery { get; } = new(Goods, Brewery);
        public static DoubleSlot IronBrewery { get; } = new(IronWorks, Brewery);
    }
}