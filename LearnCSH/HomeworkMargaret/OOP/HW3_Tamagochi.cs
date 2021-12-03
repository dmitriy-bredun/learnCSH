using HomeworkMargaret.Tools;
using System;
using static System.Console;

namespace HomeworkMargaret.OOP
{
    enum Toys
    {
        Ball,
        CandyWrapper,
        Laser,
        Box,
        Mouse,
        Ribbon
    }

    enum Food
    {
        Feed,
        Jelly,
        Tuna,
        Salmon,
        Grass,
        Chicken
    }

    class Cat
    {
        public string name;
        public double levelOfHunger;
        public double levelOfHappiness;
        public double levelOfTiredness;
        public Toys faveToy;
        public Food faveFood;
        public Food dislikedFood;

        public Cat(string name, Toys faveToy, Food faveFood, Food dislikedFood)
        {
            this.name = name;
            this.faveToy = faveToy;
            this.faveFood = faveFood;
            this.dislikedFood = dislikedFood;

            levelOfHunger = 30;
            levelOfHappiness = 100;
            levelOfTiredness = 10;
        }

        public void PlayGame(Toys toy)
        {
            if (toy == faveToy)
            {
                levelOfHappiness = 100;
                levelOfTiredness += 25;
                levelOfHunger += 30;
            }
            else
            {
                levelOfHappiness += 50;
                levelOfTiredness += 40;
                levelOfHunger += 30;
            }
        }

        public void EatFood(Food food)
        {
            if (food == faveFood)
            {
                levelOfHunger -= 75;
                levelOfHappiness += 25;
            }
            else if (food == dislikedFood)
            {
                levelOfHunger -= 30;
                levelOfHappiness -= 20;
            }
            else
            {
                levelOfHunger -= 50;
            }
        }

        public void Pet()
        {
            CT.Print("Prrrr");
            levelOfHappiness += 30;
        }
        public void Sleep()
        {
            CT.Print("*yawning* Meeeeow");
            levelOfTiredness = 0;
            levelOfHunger = +60;
        }

        public void ShowInfo()
        {
            CT.Print("\tPet info:");
            CT.Print($"Name: \t{name}");
            PrintStatus("Happiness", levelOfHappiness);
            PrintStatus("Hunger", levelOfHunger);
            PrintStatus("Tiredness", levelOfTiredness);
        }

        private void PrintStatus(string msg, double critetia)
        { 
            CT.Print($"{msg}: \t[", false);

            int count = (int)critetia / 10;
            for (int i = 0; i < 10; i++)
            {
                if (count > i)
                {
                    CT.Print("*", false);
                }
                else
                {
                    CT.Print("-", false);
                }
            }
            CT.Print("]");
        }
    }

    class HW3_Tamagochi
    {
        public static Cat pet;

        public static void Start()
        {
            PetCreation();

            ForegroundColor = ConsoleColor.DarkMagenta;
            Clear();

            RunGame();
        }

        // Метод, в котором создается питомец
        public static void PetCreation()
        {
            // заполнение полей, как описано в первом состоянии
            string name = CT.EnterString("Name your cat: ");
            WriteLine();
            CT.Print("Choose fave toy: ");
            Toys chosenToy = (Toys)CT.EnumMenu(typeof(Toys));
            WriteLine();
            CT.Print("Choose fave food: ");
            Food chosenFood = (Food)CT.EnumMenu(typeof(Food));
            WriteLine();
            CT.Print("Choose disliked food: ");
            Food dislikedFood = (Food)CT.EnumMenu(typeof(Food));

            pet = new Cat(name, chosenToy, chosenFood, dislikedFood);
        }

        // Метод, в котором начинается игра
        public static void RunGame()
        {
            CT.Print("Game on!");
            CT.Print("Choose what you wanna do with your cat: ");
            WriteLine();
            int userChoice;
            do
            {
                pet.ShowInfo();

                userChoice = CT.Menu(
                "Play with the cat",
                "Feed the cat",
                "Pet the cat",
                "Send him to sleep");
                CT.Space();

                switch (userChoice)
                {
                    case 1:
                        PlayWithPet();
                        break;

                    case 2:
                        FeedPet();
                        break;

                    case 3:
                        pet.Pet();
                        break;

                    case 4:
                        pet.Sleep();
                        break;

                    case 0:
                        CT.Print("Good Bye");
                        break;

                    default:
                        CT.ErrorMsg("Incorrect choice");
                        break;
                };
                ReadLine();
                Clear();
            } while (userChoice != 0);
        }

        public static void PlayWithPet()
        {
            CT.Print("Choose a toy");
            Toys toy = (Toys)CT.EnumMenu(typeof(Toys));
            pet.PlayGame(toy);
        }
        public static void FeedPet()
        {
            CT.Print("Choose food to feed: ");
            Food food = (Food)CT.EnumMenu(typeof(Food));

            pet.EatFood(food);
        }
    }
}
