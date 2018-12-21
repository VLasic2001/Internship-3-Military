using System;

namespace Military
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter shortest distance for a tank: ");
            var tankDistance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter shortest distance for a warship: ");
            var warshipDistance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter straight land distance for amfibia: ");
            var amfibiaLandDistance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter straight water distance for amfibia: ");
            var amfibiaWaterDistance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of soldiers: ");
            var soldierAmount = int.Parse(Console.ReadLine());

            var tank = new Tank(600, 30);
            var warship = new Warship(1000, 20);
            var amfibia = new Amfibia(400, 150);

            Console.WriteLine(tank.Print(soldierAmount, tankDistance));
            Console.WriteLine(warship.Print(soldierAmount, warshipDistance));
            Console.WriteLine(amfibia.Print(soldierAmount, amfibiaLandDistance, amfibiaWaterDistance));

            Console.WriteLine(OptimalVehicle.OptimalVehicleCalculator(tank, warship, amfibia));
        }
    }
}
