using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;
using static HomeworkMargaret.Tools.CT;

namespace HomeworkMargaret.OOP.HW_Pizza
{
    class CraftMenu
    {
        public static Pizza Crafting()
        {
            List<Ingredients> selectedIngredients = new List<Ingredients>();
            //Pizza newPizza = new Pizza();
            int userChoice;
            do
            {
                Print("Start choosing ingredients for your pizza. When you're done, press 0 ");

                if (selectedIngredients.Count > 0)
                {
                    Print("Current ingredients in pizza are: ");
                    foreach (var ingredient in selectedIngredients)
                    {
                        Print($"{ingredient}");
                    }
                }
                else
                {
                    Print("Currently there are 0 ingredients in pizza");
                }

                Print("You can add more ingredients:");
                ShowEnumItems(typeof(Ingredients));

                userChoice = EnterInt("Choose one to add or press 0 to finish choosing the ingredients and choose a sauce: ");
                if (userChoice != 0)
                {
                    Ingredients ingredient = (Ingredients)userChoice - 1;
                    selectedIngredients.Add(ingredient);
                    //newPizza.Ingredients.Add(ingredient);
                }

                Clear();
            } while (userChoice != 0);

            ShowEnumItems(typeof(Sauces));
            userChoice = EnterInt("Choose a sauce to your pizza: ");
            Sauces sauce = (Sauces)userChoice - 1;

            Print("Your pizza has been successfully created;)");

            return new Pizza(selectedIngredients, sauce);
            //return newPizza;
        }

        public static void ShowEnumItems(Type enumType)
        {
            string[] items = Enum.GetNames(enumType); // получаем все имена значений перечисления
            for (int i = 0; i < items.Length; i++)     // проходимся по всем этим именам
            {
                Print($"{i + 1} - {items[i]}");  // и печатаем каждую в консоль
            }
        }
    }
}
