using Server.Creature;
using Server.Extension;
using System.Collections.Generic;

namespace Server.Board.Creature
{
    public class CreatureStack : ICreatureStack
    {
        private readonly IList<ICreature> _pendingCreatures;
        private readonly IList<ICreature> _discardedCreatures;

        public CreatureStack(IList<ICreature> pendingCreatures)
        {
            _pendingCreatures = pendingCreatures;
            _discardedCreatures = new List<ICreature>();
        }

        public void DiscardCard(ICreature creature)
        {
            _discardedCreatures.Add(creature);
        }

        public ICreature GetCard()
        {
            if (_pendingCreatures.Count == 0)
            {
                UseDiscardedCards();
            }

            return _pendingCreatures.GetAndRemove(0);
        }

        private void UseDiscardedCards()
        {
            _discardedCreatures.Shuffle();
            _pendingCreatures.AppendAll(_discardedCreatures);
            _discardedCreatures.Clear();
        }
    }
}
