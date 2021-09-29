using Server.Board.Creature;
using Server.Creature;
using System.Collections.Generic;

namespace Server.Rule
{
    public class FirstCycle : ICycle
    {
        public IList<ICreature> GetUpdatedCreatureTrack(IList<ICreature> actualCreatureTrack, ICreatureStack creatureStack)
        {
            var card = creatureStack.GetCard();
            return new List<ICreature> { card };
        }
    }
}
