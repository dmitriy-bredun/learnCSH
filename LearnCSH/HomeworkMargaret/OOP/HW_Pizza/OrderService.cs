using System;
using System.Collections.Generic;
using System.Text;
using static HomeworkMargaret.Tools.CT;

namespace HomeworkMargaret.OOP.HW_Pizza
{
    class OrderService
    {
        public static void MakeOrder()
        {
            int userChoice;
            Print("Great! Choose, what you wanna do: ");
            do
            {
                userChoice = Menu(
                    " make a new pizza; ",
                    " remove pizza from the order ");

                switch(userChoice)
                {
                    case 1:
                        MakeAPizza();
                        break;

                    case 2:
                        RemovePizza();
                        break;

                    default:
                        break;
                }

            } while (userChoice != 0);
        }

        private static void MakeAPizza()
        {
            List<Ingridients> newPizza = new List<Ingridients>();
            CraftMenu.ShowIngridients();

        }

        private static void RemovePizza()
        {

        }
    }
}
