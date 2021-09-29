using Server.Creature;

namespace Server.Board.Creature
{
    public interface ITrackField
    {
        ICreature Creature { get; set; }
        bool IsEmpty();
    }
}
