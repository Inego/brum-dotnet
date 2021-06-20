namespace Inego.Birmingham.Game.Map
{
    public enum ConnectionType
    {
        Canal,
        Rail,
        Both
    }

    public static class Extensions
    {
        public static bool IsCanal(this ConnectionType connectionType) =>
            connectionType != ConnectionType.Rail;

        public static bool IsRail(this ConnectionType connectionType) =>
            connectionType != ConnectionType.Canal;
    }
}