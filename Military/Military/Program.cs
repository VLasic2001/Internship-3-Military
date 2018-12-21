using System;

namespace Military
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine(RandomNumber.RandomNumberGenerator());
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



        }
    }
}
