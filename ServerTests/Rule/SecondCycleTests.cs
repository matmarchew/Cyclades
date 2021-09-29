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
    public class NextCycleTests
    {
        [Test]
        public void ShouldReturnFirstCreatureInActualTrackOnSecondPlaceInNewTrack()
        {
            //GIVEN
            var cardInActualTrack = Any.Instance<ICreature>();
            var cardInNewTrack = Any.Instance<ICreature>();
            var creatureStack = Substitute.For<ICreatureStack>();
            creatureStack.GetCard().Returns(cardInNewTrack);
            var secondCycle = new SecondCycle();

            //WHEN
            var result = secondCycle.GetUpdatedCreatureTrack(new List<ICreature> { cardInActualTrack }, creatureStack);

            //THEN
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(cardInNewTrack, result[0]);
            Assert.AreEqual(cardInActualTrack, result[1]);
        }

        [Test]
        public void ShouldReturnTwoCreaturesListWhenActualTrackIsEmpty()
        {
            //GIVEN
            var firstCreature = Any.Instance<ICreature>();
            var secondCreature = Any.Instance<ICreature>();
            var creatureStack = Substitute.For<ICreatureStack>();
            creatureStack.GetCard().Returns(_ => firstCreature, _=> secondCreature);
            var secondCycle = new SecondCycle();

            //WHEN
            var result = secondCycle.GetUpdatedCreatureTrack(new List<ICreature>(), creatureStack);

            //THEN
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(firstCreature, result[0]);
            Assert.AreEqual(secondCreature, result[1]);
        }
    }
}
