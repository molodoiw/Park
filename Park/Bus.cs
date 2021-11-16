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
            //BusesInRout.Add();
        }
    }
}
