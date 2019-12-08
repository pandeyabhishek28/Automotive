using Automotive.Model;
using System;

namespace Automotive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            var honkCount = 300;

            var car1 = new Car("Škoda Fabia S2000", honkCount);
            var car2 = new Car("Škoda Octavia", honkCount);

            var truck1 = new Truck("Tatra 815-7", honkCount);
            var truck2 = new Truck("Praga V3S", honkCount);


            truck1.HonkOn(truck2);

            Console.ReadLine();
        }
    }
}
