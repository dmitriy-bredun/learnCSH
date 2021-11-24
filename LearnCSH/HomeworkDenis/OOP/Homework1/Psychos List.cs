using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static HomeworkDenis.Tools.CH;

namespace HomeworkDenis.OOP.Homework1
{
    internal class Psychos_List
    {
        private List<Psycho_Of_Pandora> _psychos;
        public int Number_Of_Psychos { get { return _psychos.Count; } }

        public Psychos_List()
        {
            _psychos = new List<Psycho_Of_Pandora>();
        }

        public void Register_A_New_Psycho()
        {
            Write("Пожалуйста, введите данные этого сказочного долбаёба: ");
            string name = EnterString("\nИмя: ");
            int reward = 0;
            do
            {
                reward = EnterInt("Награда за голову(не меньше 100): ");
            } while (reward < 100);
            string location = EnterString("Локация: ");
            string profession = EnterString("Профессия: ");

            Status status = 0;
            int choice = 0;
            do
            {
                choice = StatusMenu();
                switch (choice)
                {
                    case 1:
                        status = Status.DEAD;
                        break;

                    case 2:
                        status = Status.ALIVE;
                        break;

                    default:
                        ErrorMsg("Baka! Выбери что-то одно из списка! ;N");
                        Print2Space();
                        break;
                }
            } while (choice != 1 && choice != 2);

            _psychos.Add(new Psycho_Of_Pandora(name, reward, location, profession, status));
            Write("Ебанатик успешно зарегистрирован =3\n\n");
        }
        private int StatusMenu()
        {
            int choice = 0;
            WriteLine("Выберите состояние сказочного долбоёба =3: ");
            WriteLine("1) Дохляк");
            WriteLine("2) Я КОНДУКТОР КАКА-ПОЕЗДАААА XXXDDDDXDD");
            choice = EnterInt("Состояние: ");
            WriteLine();
            return choice;
        }

        public void Show_All_Psychos()
        {
            if(_psychos.Count != 0)
            {
                foreach (var psycho in _psychos)
                {
                    WriteLine($"ID: {psycho.ID}; Имя: {psycho.Name}; Награда: {psycho.Reward}; Локация: {psycho.Location}; Профессия: {psycho.Profession}; Status: {psycho.Status}");
                }
            }
            else
            {
                Write("В вашем списке нету ещё ни одного сказочного долбоёба =3");
            }
            WriteLine();
        }

        public void Change_The_Status_Of_The_Psycho()
        {
            if (_psychos.Count != 0)
            {
                int id = EnterInt("Пожалуйста, введите айди этого ебанатика =3: ");

                var neededPsycho = _psychos.Find(x => x.ID == id);

                //foreach (var psycho in _psychos)
                //{
                //    if (id == psycho.ID)
                //    {
                //        neededPsycho = psycho;
                //    }
                //}
                if (neededPsycho == null)
                {
                    WriteLine("\nДанного ебанатика нету в базе данных =3");
                }
                else
                {
                    Status status = 0;
                    int choice = 0;
                    do
                    {
                        choice = StatusMenu();
                        switch (choice)
                        {
                            case 1:
                                status = Status.DEAD;
                                break;

                            case 2:
                                status = Status.ALIVE;
                                break;

                            default:
                                ErrorMsg("Baka! Выбери что-то одно из списка! ;N");
                                Print2Space();
                                break;
                        }
                    } while (choice != 1 && choice != 2);
                    neededPsycho.Status = status;
                }
            }
            else
            {
                Write("В вашем списке нету ещё ни одного сказочного долбоёба =3");
            }
        }
    }
}
