using System.Collections.Immutable;

namespace Inego.Birmingham.Game.Map
{
    public static class StandardMap
    {
        #region Towns

        private static Town Belper { get; } =
            new("Belper", 0, 0, 2, Industry.CottonGoods, Industry.CoalMine, Industry.Pottery);

        private static Town Derby { get; } = new("Derby", 0, 0, 3, Industry.CottonBrewery, Industry.CottonGoods,
            Industry.IronWorks);

        private static Town Leek { get; } = new("Leek", 0, 2, 2, Industry.CottonGoods, Industry.CottonCoal);

        private static Town StokeOnTrent { get; } = new("Stoke-on-Trent", 0, 3, 3, Industry.CottonGoods,
            Industry.PotteryIron, Industry.Goods);

        private static Town Stone { get; } = new("Stone", 0, 2, 2, Industry.CottonBrewery, Industry.GoodsCoal);

        private static Town Uttoxeter { get; } =
            new("Uttoxeter", 0, 1, 2, Industry.GoodsBrewery, Industry.CottonBrewery);

        private static Town Stafford { get; } = new("Stafford", 2, 2, 2, Industry.GoodsBrewery, Industry.Pottery);

        private static Town BurtonOnTrent { get; } =
            new("Burton-On-Trent", 2, 2, 2, Industry.GoodsCoal, Industry.Brewery);

        private static Town Cannock { get; } = new("Cannock", 2, 2, 2, Industry.GoodsCoal, Industry.CoalMine);
        private static Town Tamworth { get; } = new("Tamworth", 1, 1, 1, Industry.CottonCoal.Double());
        private static Town Warsall { get; } = new("Warsall", 1, 1, 1, Industry.GoodsIron, Industry.GoodsBrewery);

        private static Town Coalbrookdale { get; } = new("Coalbrookdale", 3, 3, 3, Industry.IronBrewery,
            Industry.IronWorks, Industry.CoalMine);

        private static Town Dudley { get; } = new("Dudley", 2, 2, 2, Industry.CoalMine, Industry.IronWorks);

        private static Town Kidderminster { get; } =
            new("Kidderminster", 2, 2, 2, Industry.CottonCoal, Industry.CottonMill);

        private static Town Wolverhampton { get; } =
            new("Wolverhampton", 2, 2, 2, Industry.Goods, Industry.GoodsCoal);

        private static Town Worcester { get; } = new("Worcester", 2, 2, 2, Industry.CottonMill.Double());

        private static Town Birmingham { get; } = new("Birmingham", 3, 3, 3, Industry.CottonGoods,
            Industry.Goods.Double(), Industry.IronWorks);

        private static Town Coventry { get; } =
            new("Coventry", 3, 3, 3, Industry.Pottery, Industry.GoodsCoal, Industry.GoodsIron);

        private static Town Nuneaton { get; } =
            new("Nuneaton", 1, 1, 1, Industry.GoodsBrewery, Industry.CottonCoal);

        private static Town Redditch { get; } = new("Redditch", 1, 1, 1, Industry.GoodsCoal, Industry.IronWorks);

        public static ImmutableList<Town> Towns { get; } = ImmutableList.Create(
            Belper, Derby,
            Leek, StokeOnTrent, Stone, Uttoxeter,
            Stafford, BurtonOnTrent, Cannock, Tamworth, Warsall,
            Coalbrookdale, Dudley, Kidderminster, Wolverhampton, Worcester,
            Birmingham, Coventry, Nuneaton, Redditch);

        #endregion


        #region Farm breweries

        private static Buildable CannockFarmBrewery { get; } = new("Cannock Farm", Industry.Brewery);

        private static Buildable KidderminsterWorcesterFarmBrewery { get; } =
            new("Worcester/Kidderminster Farm", Industry.Brewery);

        public static ImmutableList<Buildable> FarmBreweries { get; } = ImmutableList.Create(
            CannockFarmBrewery, KidderminsterWorcesterFarmBrewery
        );

        #endregion

        #region Merchants

        private static Merchant Oxford { get; } = new("Oxford", 2, 2, new IncomeReward(2));
        private static Merchant Gloucester { get; } = new("Gloucester", 2, 2, new FreeDevelopReward());
        private static Merchant Shrewsbury { get; } = new("Shrewsbury", 2, 1, new VictoryPointsReward(4));
        private static Merchant Warrington { get; } = new("Warrington", 3, 2, new MoneyReward(5));
        private static Merchant Nottingham { get; } = new("Nottingham", 4, 2, new VictoryPointsReward(3));
        
        public static ImmutableList<Merchant> Merchants { get; } = ImmutableList.Create(Oxford, Gloucester, Shrewsbury, Warrington, Nottingham);

        #endregion
    }
}