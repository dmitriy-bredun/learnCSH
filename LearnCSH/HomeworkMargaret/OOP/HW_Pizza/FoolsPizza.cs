using System;
using System.Collections.Generic;
using System.Text;

using static HomeworkMargaret.Tools.CT;

namespace HomeworkMargaret.OOP.HW_Pizza
{
    class FoolsPizza
    {
        static OrderService OrderService = new OrderService();

        public static void Start()
        {
            Print("Hi! We're happy to see you in our Fool's Pizza!");
            int userChoice;
            do
            {
                userChoice = Menu(
                    " make an order ",
                    " check the order ",
                    " find your destiny... oops, pay the bill ");

                switch (userChoice)
                {
                    case 1:
                        MakeOrder();
                        break;

                    case 2:
                        CheckTheOrder();
                        break;

                    case 3:
                        GiveTheBill();
                        break;

                    default:
                        break;
                }


            } while (userChoice != 0);
        }

        private static void MakeOrder()
        {
            OrderService.MakeOrder();
        }

        private static void CheckTheOrder()
        {
            throw new NotImplementedException();
        }

        private static void GiveTheBill()
        {
            throw new NotImplementedException();
        }
    }
}
