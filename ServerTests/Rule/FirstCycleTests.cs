using NSubstitute;
using NUnit.Framework;
using Server.Board.Creature;
using Server.Creature;
using Server.Rule;
using System.Collections.Generic;
using static TddXt.AnyRoot.Root;

namespace ServerTests.Rule
{
    [TestFixture]
    public class FirstCycleTests
    {
        [Test]
        public void ShouldReturnOneElementList()
        {
            //GIVEN
            var card = Any.Instance<ICreature>();
            var creatureStack = Substitute.For<ICreatureStack>();
            creatureStack.GetCard().Returns(card);
            var firstCycle = new FirstCycle();

            //WHEN
            var result = firstCycle.GetUpdatedCreatureTrack(new List<ICreature>(), creatureStack);

            //THEN
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(card, result[0]);
        }
    }
}
