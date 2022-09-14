using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkMargaret.OOP.HW_Pizza
{
    class UserOrder
    {
        public List<Pizza> UsersPizza = new List<Pizza>();

        public UserOrder(List<Pizza> pizzas)
        {
            UsersPizza = pizzas;
        }

    }
}
