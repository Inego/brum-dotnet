namespace Inego.Birmingham.Game.State
{
    public class PlayerState
    {
        public int Vp { get; set; }
        public int IncomeStep { get; set; }
        
        public int NextIronIdx { get; set; }
        public int NextCoalIdx { get; set; }
        public int NextBreweryIdx { get; set; }
        public int NextCottonIdx { get; set; }
        public int NextGoodsIdx { get; set; }
        public int NextPotteryIdx { get; set; }
        
        // Also, part of player state is present in industry slots (as industries + resources on them)
    }
}