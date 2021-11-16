using System;
using System.Collections.Generic;

namespace Park
{
    public class BusPark
    {
        public Dictionary<string, (string, string)> ParkBuses = new Dictionary<string, (string, string)>();
        public Dictionary<string, (string, string)> BusesInRout = new Dictionary<string, (string, string)>();


        public void PrintPark()
        {
            foreach(KeyValuePair<string, (string, string)> key in ParkBuses)
            {
                Console.WriteLine("Номер маршрута автобуса: " + key.Key + " ФИО водителя автобуса: " + key.Value.Item1 + " Государственный номер автобуса: " + key.Value.Item2);
            }
        }

        public void PrintBusesInRout()
        {
            Console.WriteLine("Автобусы, находящиеся в пути: ");

            foreach(KeyValuePair<string, (string, string)> key in BusesInRout)
            {
                Console.WriteLine(key.Key);
            }
        }
    }
}
