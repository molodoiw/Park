using System;
using System.Collections.Generic;

namespace Park
{
    public class Menu : Bus
    {
        private string Button;
        //Menu test = new();

        public void ShowMenu()
        {
            do
            {
                Console.WriteLine("Нажмите '1' для добавления автобуса на стоянку\nНажмите '2' для отправления автобуса с парковки в путь\nНажмите '3' для просмотра информации об автобусах на стоянке\nНажмите '4' для просмотра информации об автобусах, находящихся в пути\n\nНажмите 'X' для выхода");
                Button = Console.ReadLine();

                switch(Button)
                {
                    case "1":
                        {
                            GetInfo();
                            InputToPark();

                            break;
                        }

                    case "2":
                        {
                            InputToRout();

                            break;
                        }

                    case "3":
                        {
                            PrintPark();

                            break;
                        }

                    case "4":
                        {
                            PrintBusesInRout();

                            break;
                        }
                }

            } while (Button != "X");
        }
    }
}
