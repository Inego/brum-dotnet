using System.Collections.Generic;

namespace Inego.Birmingham.Game.Map
{
    public static class StandardMap
    {
        #region Towns

        public static Town Belper { get; } =
            new("Belper", 0, 0, 2, Industry.CottonGoods, Industry.CoalMine, Industry.Pottery);

        public static Town Derby { get; } = new("Derby", 0, 0, 3, Industry.CottonBrewery, Industry.CottonGoods,
            Industry.IronWorks);

        public static Town Leek { get; } = new("Leek", 0, 2, 2, Industry.CottonGoods, Industry.CottonCoal);

        public static Town StokeOnTrent { get; } = new("Stoke-on-Trent", 0, 3, 3, Industry.CottonGoods,
            Industry.PotteryIron, Industry.Goods);

        public static Town Stone { get; } = new("Stone", 0, 2, 2, Industry.CottonBrewery, Industry.GoodsCoal);

        public static Town Uttoxeter { get; } =
            new("Uttoxeter", 0, 1, 2, Industry.GoodsBrewery, Industry.CottonBrewery);

        public static Town Stafford { get; } = new("Stafford", 2, 2, 2, Industry.GoodsBrewery, Industry.Pottery);

        public static Town BurtonOnTrent { get; } =
            new("Burton-On-Trent", 2, 2, 2, Industry.GoodsCoal, Industry.Brewery);

        public static Town Cannock { get; } = new("Cannock", 2, 2, 2, Industry.GoodsCoal, Industry.CoalMine);
        public static Town Tamworth { get; } = new("Tamworth", 1, 1, 1, Industry.CottonCoal.Double());
        public static Town Warsall { get; } = new("Warsall", 1, 1, 1, Industry.GoodsIron, Industry.GoodsBrewery);

        public static Town Coalbrookdale { get; } = new("Coalbrookdale", 3, 3, 3, Industry.IronBrewery,
            Industry.IronWorks, Industry.CoalMine);

        public static Town Dudley { get; } = new("Dudley", 2, 2, 2, Industry.CoalMine, Industry.IronWorks);

        public static Town Kidderminster { get; } =
            new("Kidderminster", 2, 2, 2, Industry.CottonCoal, Industry.CottonMill);

        public static Town Wolverhampton { get; } =
            new("Wolverhampton", 2, 2, 2, Industry.Goods, Industry.GoodsCoal);

        public static Town Worcester { get; } = new("Worcester", 2, 2, 2, Industry.CottonMill.Double());

        public static Town Birmingham { get; } = new("Birmingham", 3, 3, 3, Industry.CottonGoods,
            Industry.Goods.Double(), Industry.IronWorks);

        public static Town Coventry { get; } =
            new("Coventry", 3, 3, 3, Industry.Pottery, Industry.GoodsCoal, Industry.GoodsIron);

        public static Town Nuneaton { get; } =
            new("Nuneaton", 1, 1, 1, Industry.GoodsBrewery, Industry.CottonCoal);

        public static Town Redditch { get; } = new("Redditch", 1, 1, 1, Industry.GoodsCoal, Industry.IronWorks);


        #region Farm breweries

        public static Town CannockFarmBrewery { get; } = new("Cannock Farm", 0, 0, 0, Industry.Brewery);
        public static Town KidderminsterWorcesterFarmBrewery { get; } = new("Worcester/Kidderminster Farm", 0, 0, 0, Industry.Brewery);

        #endregion

        public static List<Town> Towns { get; } = new()
        {
            Belper, Derby,
            Leek, StokeOnTrent, Stone, Uttoxeter,
            Stafford, BurtonOnTrent, Cannock, Tamworth, Warsall,
            Coalbrookdale, Dudley, Kidderminster, Wolverhampton, Worcester,
            Birmingham, Coventry, Nuneaton, Redditch,
            
            CannockFarmBrewery, KidderminsterWorcesterFarmBrewery
        };

        #endregion

        #region Merchants

        #endregion
    }
}