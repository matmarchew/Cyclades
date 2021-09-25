using Server.Creature;

namespace Server.Board.Creature
{
    public interface ICreaturesPart
    {
        void DiscardCard(ICreature creature);
        ICreature GetCard();
    }
}