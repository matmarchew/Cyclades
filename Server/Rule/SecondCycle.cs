using Server.Board.Creature;
using Server.Creature;
using System.Collections.Generic;

namespace Server.Rule
{
    public class SecondCycle : ICycle
    {
        public IList<ICreature> GetUpdatedCreatureTrack(IList<ICreature> actualCreatureTrack, ICreatureStack creatureStack)
        {
            if (actualCreatureTrack.Count == 1)
            {
                return new List<ICreature>
                {
                    creatureStack.GetCard(),
                    actualCreatureTrack[0]
                };
            }

            return new List<ICreature>
            {
                creatureStack.GetCard(),
                creatureStack.GetCard()
            };
        }
    }
}
