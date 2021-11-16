using System;
using System.Collections.Generic;

namespace Park
{
    public class Bus : BusPark
    {
        private string BusRoutNumber; 
        private string BusNspDriver; // NSP - Name Surname Patronymic
        private string BusNumber;
        (string, string) BusInfo;

        public void GetInfo()
        {
            Console.Write("Введите номер маршрута автобуса: ");
            BusRoutNumber = Console.ReadLine();

            Console.Write("Введите ФИО водителя автобуса: ");
            BusNspDriver = Console.ReadLine();

            Console.Write("Введите государственный номер автобуса: ");
            BusNumber = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            BusInfo = (BusNspDriver, BusNumber);
        }

        public void InputToPark()
        {
            ParkBuses.Add(BusRoutNumber, BusInfo);
        }

        public void InputToRout()
        {
            Console.WriteLine("Введите номер маршрута автобуса: ");
            string num = Console.ReadLine();
            
            foreach(KeyValuePair<string, (string, string)> number in ParkBuses)
            {
                if (number.Key == num)
                {
                    BusesInRout.Add(num, (number.Value.Item1, number.Value.Item2));
                    ParkBuses.Remove(num);
                }
            }
        }
    }
}
