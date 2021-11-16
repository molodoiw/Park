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
                Console.WriteLine("1. Нажмите '1' для добавления автобуса на стоянку\n2. Нажмите '2' для просмотра информации об автобусах на стоянке\nНажмите 'X' для выхода");
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
                            PrintPark();

                            break;
                        }
                }

            } while (Button != "X");
        }
    }
}
