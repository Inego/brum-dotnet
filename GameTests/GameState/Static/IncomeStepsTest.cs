using NUnit.Framework;

namespace Inego.Birmingham.Game.Tests.GameState.Static
{
    [TestFixture]
    public class IncomeStepsTest
    {
        [Test]
        public void TestIncomeSteps()
        {
            var incomeSteps = State.GameState.IncomeSteps;

            Assert.AreEqual(100, incomeSteps.Length);
        }
    }
}