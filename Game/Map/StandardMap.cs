using System.Collections.Generic;

namespace Inego.Birmingham.Game.Map
{
    public static class StandardMap
    {
        public static Town Belper { get; } =
            new Town("Belper", 0, 0, 2, Industry.CottonGoods, Industry.CoalMine, Industry.Pottery);

        public static Town Derby { get; } = new Town("Derby", 0, 0, 3, Industry.CottonBrewery, Industry.CottonGoods,
            Industry.IronWorks);

        public static Town Leek { get; } = new Town("Leek", 0, 2, 2, Industry.CottonGoods, Industry.CottonCoal);

        public static Town StokeOnTrent { get; } = new Town("Stoke-on-Trent", 0, 3, 3, Industry.CottonGoods,
            Industry.PotteryIron, Industry.Goods);

        public static Town Stone { get; } = new Town("Stone", 0, 2, 2, Industry.CottonBrewery, Industry.GoodsCoal);

        public static Town Uttoxeter { get; } =
            new Town("Uttoxeter", 0, 1, 2, Industry.GoodsBrewery, Industry.CottonBrewery);

        public static Town Stafford { get; } = new Town("Stafford", 2, 2, 2, Industry.GoodsBrewery, Industry.Pottery);

        public static Town BurtonOnTrent { get; } =
            new Town("Burton-On-Trent", 2, 2, 2, Industry.GoodsCoal, Industry.Brewery);

        public static Town Cannock { get; } = new Town("Cannock", 2, 2, 2, Industry.GoodsCoal, Industry.CoalMine);
        public static Town Tamworth { get; } = new Town("Tamworth", 1, 1, 1, Industry.CottonCoal.Double());
        public static Town Warsall { get; } = new Town("Warsall", 1, 1, 1, Industry.GoodsIron, Industry.GoodsBrewery);

        public static Town Coalbrookdale { get; } = new Town("Coalbrookdale", 3, 3, 3, Industry.IronBrewery,
            Industry.IronWorks, Industry.CoalMine);

        public static Town Dudley { get; } = new Town("Dudley", 2, 2, 2, Industry.CoalMine, Industry.IronWorks);

        public static Town Kidderminster { get; } =
            new Town("Kidderminster", 2, 2, 2, Industry.CottonCoal, Industry.CottonMill);

        public static Town Wolverhampton { get; } =
            new Town("Wolverhampton", 2, 2, 2, Industry.Goods, Industry.GoodsCoal);

        public static Town Worcester { get; } = new Town("Worcester", 2, 2, 2, Industry.CottonMill.Double());

        public static Town Birmingham { get; } = new Town("Birmingham", 3, 3, 3, Industry.CottonGoods,
            Industry.Goods.Double(), Industry.IronWorks);

        public static Town Coventry { get; } =
            new Town("Coventry", 3, 3, 3, Industry.Pottery, Industry.GoodsCoal, Industry.GoodsIron);

        public static Town Nuneaton { get; } =
            new Town("Nuneaton", 1, 1, 1, Industry.GoodsBrewery, Industry.CottonCoal);

        public static Town Redditch { get; } = new Town("Redditch", 1, 1, 1, Industry.GoodsCoal, Industry.IronWorks);

        
        public static List<Town> Towns { get; } = new()
        {
            Belper, Derby,
            Leek, StokeOnTrent, Stone, Uttoxeter,
            Stafford, BurtonOnTrent, Cannock, Tamworth, Warsall,
            Coalbrookdale, Dudley, Kidderminster, Wolverhampton, Worcester,
            Birmingham, Coventry, Nuneaton, Redditch
        };
    }
}