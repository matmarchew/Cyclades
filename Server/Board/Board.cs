using Server.Board.Creature;

namespace Server.Board
{
    public class Board
    {
        private readonly ICreatureStack _creatureStack;

        public Board(ICreatureStack creatureStack)
        {
            _creatureStack = creatureStack;
        }
    }
}
