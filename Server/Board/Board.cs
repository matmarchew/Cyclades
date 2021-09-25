using Server.Board.Creature;

namespace Server.Board
{
    public class Board
    {
        private readonly ICreaturesPart _creaturesPart;

        public Board(ICreaturesPart creaturesPart)
        {
            _creaturesPart = creaturesPart;
        }
    }
}
