using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

using HomeworkMargaret.Tools;

namespace HomeworkMargaret.OOP
{
    class Cat
    {
        public string name;
        public double levelOfHunger;
        public double levelOfHappiness;
        public double levelOfTiredness;
        public string toy;
        public string faveToy;
        public string food;
        public string faveFood;

        public Cat()
        {
            
        }

        enum Toys
        {
            Ball,
            Mouse,
            CandyWrapper,
            Ribbon,
            Laser,
            Box
        }

        enum Food
        {
            Feed,
            Jelly,
            Chicken,
            Tuna,
            Salmon,
            Grass
        }
    }

    class Tamagotchi
    {
        Cat cat = new Cat();       
        public static void Start()
        {
            
        }
        
        public static void PlayWithaToy()
        {
              
        }

        public static void Eat()
        {
            int faveToy;
            // if(faveFood)
            {
              
            }
            else
            {

            }

            //if (levelOfTiredness > 60)
            {
                CT.Print("Thank you for the game! I've had a lot of fun! But now I need to have some rest.");
            }
        }

        public static void Sleep()
        {

        }

        public static void ShowCurrentValues()
        {
            
        }
    }
}
