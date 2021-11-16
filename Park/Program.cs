using System;

namespace Park
{
    class Program : Menu
    {
        static void Main(string[] args)
        {
            Menu menu = new();
            menu.ShowMenu();
        }
    }
}
