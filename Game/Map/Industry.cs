namespace Inego.Birmingham.Game.Map
{
    public class Industry : IndustrySlot
    {
        private Industry(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public static Industry IronWorks { get; } = new Industry("Iron works");
        public static Industry CoalMine { get; } = new Industry("Coal mine");
        public static Industry Brewery { get; } = new Industry("Brewery");
        public static Industry CottonMill { get; } = new Industry("Cotton mill");
        public static Industry Goods { get; } = new Industry("Mfg. goods");
        public static Industry Pottery { get; } = new Industry("Pottery");

        public static DoubleSlot CottonGoods { get; } = new DoubleSlot(CottonMill, Goods);
        public static DoubleSlot CottonBrewery { get; } = new DoubleSlot(CottonMill, Brewery);
        public static DoubleSlot CottonCoal { get; } = new DoubleSlot(CottonMill, CoalMine);
        public static DoubleSlot PotteryIron { get; } = new DoubleSlot(Pottery, IronWorks);
        public static DoubleSlot GoodsCoal { get; } = new DoubleSlot(Goods, CoalMine);
        public static DoubleSlot GoodsIron { get; } = new DoubleSlot(Goods, IronWorks);
        public static DoubleSlot GoodsBrewery { get; } = new DoubleSlot(Goods, Brewery);
        public static DoubleSlot IronBrewery { get; } = new DoubleSlot(IronWorks, Brewery);
    }
}