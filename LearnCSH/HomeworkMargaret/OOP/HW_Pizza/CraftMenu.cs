using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;
using static HomeworkMargaret.Tools.CT;

namespace HomeworkMargaret.OOP.HW_Pizza
{
    class CraftMenu
    {
        
        
        public static void Crafting()
        {
            List<Ingridients> newPizza = new List<Ingridients>();
            int userChoice;
            do
            {
                userChoice = EnterInt("Please, choose ingredietns for your pizza: ");
                for (int i = 0; i < newPizza.Count; i++)
                {
                    
                }
                   
            } while (userChoice != 0);
            
        }

        public static Ingridients ShowIngridients()
        {
            Print("Choose ingridients");
            string[] ingridients = Enum.GetNames(typeof(Ingridients)); // получаем все имена значений перечисления
            for (int i = 0; i < ingridients.Length; i++)     // проходимся по всем этим именам
            {
                Print($"{i} - {ingridients[i]}");  // и печатаем каждую в консоль
            }

            EnterString ("---> ");
            int ingrValue = Convert.ToInt32(ReadLine());
            Ingridients ingrid = (Ingridients)ingrValue;

            return ingrid;  
        }
    }

}
