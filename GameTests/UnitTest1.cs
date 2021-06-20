using Inego.Birmingham.Game.Map;
using NUnit.Framework;

namespace Inego.Birmingham.Game.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConnectionTypeBothCanal()
        {
            Assert.True(ConnectionType.Both.IsCanal());
        }
    }
}