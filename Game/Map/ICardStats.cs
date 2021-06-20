namespace Inego.Birmingham.Game.Map
{
    public interface ICardStats
    {
        /**
         * Count of this card in the 2-player deck.
         */
        int C2 { get; }

        /**
         * Count of this card in the 3-player deck.
         */
        int C3 { get; }

        /**
         * Count of this card in the 4-player deck.
         */
        int C4 { get; }
    }
}