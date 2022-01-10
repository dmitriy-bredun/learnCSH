using static HomeworkMargaret.Tools.CT;

namespace HomeworkMargaret.OOP.HW4_Encapsulation.Task2
{
    class Game
    {
        private static Factory _factory;

        public static void Start()
        {
            _factory = new Factory();

            FactoryMenu();
        }

        public static void FactoryMenu()
        {
            int userChoice;

            do
            {
                userChoice = Menu(
                    "Create Balls",
                "Put balls into storage",
                "Put balls out of storage",
                "Show unstoraged balls",
                "Show storage");

                switch(userChoice)
                {
                    case 1:
                        CreateBalls();
                        break;

                    case 2:
                        KeepBalls();
                        break;

                    case 3:
                        GetBalls();
                        break;

                    case 4:
                        ShowUnstoragedBalls();
                        break;

                    case 5:
                        ShowStorageInfo();
                        break;

                    case 0:
                        break;

                    default:
                        ErrorMsg("Incorrect number!");
                        break;
                }

            } while (userChoice != 0);
        }

        public static void CreateBalls()
        {
            int countToCreate = EnterInt("How many balls do you wanna create: ");
            int createdBalls = _factory.StartCreatingBalls(countToCreate);

            Print($"{createdBalls} balls were created.");
        }

        public static void KeepBalls()
        {
            int countToKeep = EnterInt("Amount of balls you wanna put into the storage: ");
            bool isSuccess = _factory.KeepBallsInStorage(countToKeep);
            
            if (isSuccess)
            {
                Print("Balls were put into the storage.");
            }
            else
            {
                ErrorMsg("You're trying to save more balls than you have");
            }
        }

        public static void GetBalls()
        {
            int amount = EnterInt("Enter the amount of balls you wanna take out of the storage: ");
            Colors color = (Colors)EnumMenu(typeof(Colors));

            bool isSuccess = _factory.TakeBallsOutOfStorage(amount, color);

            if (isSuccess)
            {
                Print("Balls were taken out of the storage");
            }
            else
            {
                ErrorMsg("Not enough balls in the storage");
            }
        }

        public static void ShowUnstoragedBalls()
        {
            Print(_factory.GetUnstoragedInfo());
        }

        public static void ShowStorageInfo()
        {
            Print(_factory.GetStorageInfo());
        }
    }
}
