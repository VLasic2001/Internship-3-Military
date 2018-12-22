using System;
using Military.Classes;

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

            var simulationTank = new Tank(62000, 30);
            var simulationWarship = new Warship(35000, 100);
            var simulationAmfibia = new Amfibia(29100, 40);
            TripSetup.SetupTank(ref simulationTank, soldierAmount, tankDistance);
            TripSetup.SetupWarship(ref simulationWarship, soldierAmount, warshipDistance);
            TripSetup.SetupAmfibia(ref simulationAmfibia, soldierAmount, amfibiaLandDistance, amfibiaWaterDistance);
            Console.WriteLine(simulationTank.ToString());
            Console.WriteLine(simulationWarship.ToString());
            Console.WriteLine(simulationAmfibia.ToString());

            Console.WriteLine(OptimalVehicle.OptimalVehicleCalculator(simulationTank, simulationWarship, simulationAmfibia));
        }
    }
}
