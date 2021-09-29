using NUnit.Framework;
using Server.Board.Creature;
using Server.Creature;
using System.Collections.Generic;
using static TddXt.AnyRoot.Root;

namespace ServerTests.Board.Creature
{
    [TestFixture]
    public class CreatureStackTests
    {
        [Test]
        public void ShouldUseDiscardedCardWhenPendingStackIsEmpty()
        {
            //GIVEN
            var card = Any.Instance<ICreature>();
            var pendingCreatures = new List<ICreature>();
            var creaturesPart = new CreatureStack(pendingCreatures);

            //WHEN
            creaturesPart.DiscardCard(card);

            //THEN
            Assert.AreEqual(card, creaturesPart.GetCard());
        }

        [Test]
        public void ShouldGetFirstCardFromPendingStack()
        {
            //GIVEN
            var card = Any.Instance<ICreature>();
            var pendingCreatures = new List<ICreature>{ card, Any.Instance<ICreature>() };
            var creaturesPart = new CreatureStack(pendingCreatures);

            //WHEN
            var resultCard = creaturesPart.GetCard();

            //THEN
            Assert.AreEqual(card, resultCard);
        }
    }
}
