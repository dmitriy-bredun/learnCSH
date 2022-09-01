using System;
using System.Collections.Generic;
using System.Text;
using static HomeworkMargaret.Tools.CT;

namespace HomeworkMargaret.OOP.HW_Pizza
{
    class OrderService
    {
        public List<Pizza> PizzasInOrder
        {
            get; private set;
        }


        public OrderService()
        {
            PizzasInOrder = new List<Pizza>();
        }

        public void MakeOrder()
        {
            int userChoice;
            Print("Great! Choose, what you wanna do: ");
            do
            {
                userChoice = Menu(
                    " make a new pizza; ",
                    " remove pizza from the order ",
                    " show all pizzas");

                switch(userChoice)
                {
                    case 1:
                        MakePizza();
                        break;

                    case 2:
                        RemovePizza();
                        break;

                    case 3:
                        ShowAllPizzas();
                        break;

                    default:
                        break;
                }

            } while (userChoice != 0);
        }

        private void MakePizza()
        {
            
            Pizza newPizza = CraftMenu.Crafting();
            PizzasInOrder.Add(newPizza);

        }

        private void RemovePizza()
        {
            ShowAllPizzas();
            int removedPizza = EnterInt("Choose a pizza to remove: ");
            PizzasInOrder.RemoveAt(removedPizza);
        }

        public void ShowAllPizzas()
        {
            int indx = 0;
            foreach (Pizza item in PizzasInOrder)
            {
                Print($"Pizza № {indx++}");
                item.PrintToConsole();
            }
        }
    }
}
