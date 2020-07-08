using System;

namespace Collectibles
{
    class Program
    {
        static void Main(string[] args)
        {
            var cards = new GarbagePailKids
            {
                Name = "Karate Kate",
                Manufacturer = "Topps",
                Series = 3
            };
            Console.WriteLine("New card created named " + cards.Name);
            Console.WriteLine("Made by: " + cards.Manufacturer);
            Console.WriteLine("In Series: " + cards.Series);
        }
    }
}
