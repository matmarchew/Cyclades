using Server.Creature;

namespace Server.Board.Creature
{
    public class TrackField : ITrackField
    {
        public ICreature Creature { get; set; }

        public bool IsEmpty()
        {
            return Creature == null;
        }
    }
}