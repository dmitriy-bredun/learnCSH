using System;
using System.Collections.Generic;
using System.Text;

using static HomeworkMargaret.Tools.CT;

namespace HomeworkMargaret.OOP.HW_Pizza
{
    class Pizza
    {
        public List<Ingredients> Ingredients { get; private set; }
        public Sauces Sauce { get; private set;}

        public Pizza()
        {
            Ingredients = new List<Ingredients>();
        }

        public Pizza(List<Ingredients> ingredients, Sauces sauce)
        {
            Ingredients = ingredients;
            Sauce = sauce;
        }

        public void PrintToConsole()
        {
            Print("Pizza's info:");
            Print("Ingredients [", false);  

            foreach (var item in Ingredients)
            {
                Print($"{item} ", false);
            }
            Print($"] + sauce: {Sauce}");
        }
    }
}
