using System;
using System.Collections.Generic;

using static System.Console;

namespace Lessons.Tools
{
    public delegate void Act();

    class DynamicMenu
    {
        private readonly string MenuName;
        private Dictionary<string, Act> MethodsDictionary;

        public DynamicMenu(string menuName = "")
        {
            MethodsDictionary = new Dictionary<string, Act>();
            MenuName = menuName;
        }

        public void AddMenuItem(string methodName, Act method)
        {
            if (string.IsNullOrEmpty(methodName))
            {
                throw new ArgumentException("MethodName is null or empty");
            }

            if (method == null)
            {
                throw new ArgumentNullException("method is null");
            }

            MethodsDictionary.TryAdd(methodName, method);
        }
        public void UpdateMethod(string methodName, Act method)
        { }
        public void RemoveMethod(string methodName)
        { }


        public int CallMenu()
        {
            int indx = 1;
            var menuItems = new List<string>(MethodsDictionary.Keys);

            WriteLine($"   М Е Н Ю : {MenuName}");

            foreach (var item in menuItems)
            {
                WriteLine($"{indx++} --- {item}");
            }

            WriteLine("0 --- Выход");

            var userChoice = CT.EnterInt("---> ");
            WriteLine();

            if (userChoice == 0)
            {
                return userChoice;
            }

            if (0 > userChoice || userChoice > menuItems.Count)
            {
                CT.ErrorMsg("Идиот, что ли?");
                return userChoice;
            }

            CallMethod(GetMenuItemKeyByNumber(userChoice - 1));
            return userChoice;

        }

        /// <summary>
        /// Запускает метод из предложенных в меню.
        /// </summary>
        /// <param name="methodkey"></param>
        private void CallMethod(string methodkey)
        {
            if (string.IsNullOrEmpty(methodkey))
            {
                throw new ArgumentException("MethodName is null or empty");
            }

            if (!MethodsDictionary.ContainsKey(methodkey))
            {
                throw new ArgumentException($"Method {methodkey} does not found");
            }

            bool isSuccess = MethodsDictionary.TryGetValue(methodkey, out Act method);
            if (isSuccess)
            {
                method();
            }
        }

        private string GetMenuItemKeyByNumber(int number)
        {
            var menuItems = new List<string>(MethodsDictionary.Keys);

            var arrayMenuItems = menuItems.ToArray();

            var choicedMenuItem = arrayMenuItems[number];

            return choicedMenuItem;
        }
    }
}
