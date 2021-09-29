using Server.Creature;

namespace Server.Board.Creature
{
    public interface ICreatureStack
    {
        void DiscardCard(ICreature creature);
        ICreature GetCard();
    }
}