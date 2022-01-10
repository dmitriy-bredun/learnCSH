using static HomeworkMargaret.Tools.CT;

namespace HomeworkMargaret.OOP.HW4_Encapsulation.Task2
{
    class Factory
    {
        private Crane _crane;
        private Storage _storage;

        private Ball[] _unstoragedBalls;

        public int CountOfUnstoraged
        {
            get
            {
                return _unstoragedBalls.Length;
            }
        }

        public Factory()
        {
            _crane = new Crane();
            _storage = new Storage();
        }

        public int StartCreatingBalls(int count)
        {
            Ball[] newPart = _crane.CreateBalls(count);

            MoveBallsToUnstoragedArray(newPart);
                       
            return CountOfUnstoraged;
        }

        public bool KeepBallsInStorage(int count)
        {
            if (_unstoragedBalls == null)
            {
                return false;
            }

            if (count > _unstoragedBalls.Length)
            {
                return false;
            }

            _unstoragedBalls = _crane.ThrowBallsToStorage(count, _unstoragedBalls, _storage);
            return true;
        }

        public bool TakeBallsOutOfStorage(int count, Colors color)
        {
            int availableCount = 0;

            switch (color)
            {
                case Colors.Yellow:
                    availableCount = _storage.YellowBallCount;
                    break;

                case Colors.Green:
                    availableCount = _storage.GreenBallCount;
                    break;

                case Colors.Red:
                    availableCount = _storage.RedBallCount;
                    break;

                case Colors.Blue:
                    availableCount = _storage.BlueBallCount;
                    break;
            }

            if (availableCount < count)
            {
                return false;
            }

            Ball[] returnedBalls = _crane.TakeBallsFromStorage(count, color, _storage);

            MoveBallsToUnstoragedArray(returnedBalls);

            return true;
        }

        public string GetUnstoragedInfo()
        {
            string information = "";

            if (_unstoragedBalls == null)
            {
                information += "Common count of unstoraged balls: 0";
            }
            else
            {
                information += $"Common count of unstoraged balls: {_unstoragedBalls.Length} \n";
                foreach (Ball ball in _unstoragedBalls)
                {
                    information += $"  {ball.Color} \n";
                }
            }

            return information;
        }

        public string GetStorageInfo()
        {
            return _storage.GetStorageInfo();
        }

        private void MoveBallsToUnstoragedArray(Ball[] newPart)
        {
            if (_unstoragedBalls == null)
            {
                _unstoragedBalls = newPart;
            }
            else
            {
                int commonLength = newPart.Length + _unstoragedBalls.Length;
                Ball[] commonArray = new Ball[commonLength];

                int commonIndx = 0;

                for (int indx = 0; indx < _unstoragedBalls.Length; indx++, commonIndx++)
                {
                    commonArray[commonIndx] = _unstoragedBalls[indx];
                }

                for (int indx = 0; indx < newPart.Length; indx++, commonIndx++)
                {
                    commonArray[commonIndx] = newPart[indx];
                }

                _unstoragedBalls = commonArray;
            }
        }
    }
}
