using System.Collections.Generic;
using Server.Board.Creature;
using Server.Creature;

namespace Server.Rule
{
    public interface ICycle
    {
        IList<ICreature> GetUpdatedCreatureTrack(IList<ICreature> actualCreatureTrack, ICreatureStack creatureStack);
    }
}
