using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkMargaret.OOP.HW_Pizza
{
    [Flags]
    enum Ingridients
    {
        Tomato = 0,
        Onions = 2,
        Mushrooms = 4,
        YellowCheese = 8,
        BlueCheese = 16,
        Mozarella = 32,
        Chedder = 64,
        Parmesan = 128,
        Olives = 256,
        Sausages = 512,
        Chicken = 1024,
        Bacon = 2048,
        Pineapple = 4096,
        Cucumbers = 8192,
        Melon = 16384,
        Basil = 32768,
        Avocado = 65536,
        Spinach = 131072
    }
    
}
