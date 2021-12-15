namespace Lessons.Practice.ClassesRelationship
{
    class Factory
    {
        private Crane _crane;
        private Storage _storage;

        private int _unstoragedCount;
        private Ball[] _unstoragedBalls;

        public int CountOfUnstoraged
        {
            private set
            {
                _unstoragedCount = value;
            }
            get
            {
                return _unstoragedCount;
            }
        }

        public Factory()
        {
            _crane = new Crane();
            _storage = new Storage();
        }

        public void StartCreatingBalls(int count)
        {
            // Со случайным цветом
            _unstoragedBalls = _crane.CreateBalls(count);

            CountOfUnstoraged = count;
        }
    }
}
