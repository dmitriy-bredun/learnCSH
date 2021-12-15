using Lessons.Practice.ClassesRelationship;
using Lessons.Tools;

namespace Lessons.General.ClassesRelationship
{
    class Practice6_ClassesRelationship
    {
        private static Factory _factory;
        
        private static DynamicMenu _menu = new DynamicMenu();

        public static void Start()
        {
            _factory = new Factory();

            _menu.AddMenuItem("Создать мячики (создает краном мячики и оставляет их у вас на руках)", CreateBalls);
            _menu.AddMenuItem("Переместить мячи в хранилище", KeepBalls);
            _menu.AddMenuItem("Забрать мячи из хранилища", GetBalls);
        }

        public static void CreateBalls()
        {
            int countToCreate = CT.EnterInt("Сколько мячей вы хотите создать?");
            _factory.StartCreatingBalls(countToCreate);
        }

        public static void KeepBalls()
        {

        }

        public static void GetBalls()
        {

        }
    }
}