namespace Server.Board.Creature
{
    public class CreatureTrack : ICreatureTrack
    {
        private readonly ICreatureStack _creatureStack;
        private ITrackField _firstTrackField;
        private ITrackField _secondTrackField;
        private ITrackField _thirdTrackField;

        public CreatureTrack(ICreatureStack creatureStack)
        {
            _creatureStack = creatureStack;
            _firstTrackField = new TrackField();
            _secondTrackField = new TrackField();
            _thirdTrackField = new TrackField();
        }

        public void Update()
        {
            throw new System.NotImplementedException();
        }
    }
}
