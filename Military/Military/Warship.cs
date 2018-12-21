using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    class Warship : Vehicle, ISwimmable
    {
        public Warship(double weight, int averageSpeed) : base(weight, averageSpeed)
        {
            Capacity = 50;
            FuelConsumption = 200;
        }

        public override void Print()
        {
            Console.WriteLine($"total fuel used: ");
        }

        public double Swim(int soldierAmount, int waterDistance)
        {
            var tenMinuteDistance = AverageSpeed / 6;
            var amountOfTrips = AmountOfTrips(soldierAmount);
            var singleTripDistance = waterDistance;

            for (var i = 0; i < amountOfTrips; i++)
            {
                var tripDistance = singleTripDistance;
                while (tripDistance >= tenMinuteDistance)
                {
                    if (RandomNumber.RandomNumberGenerator() < 50)
                    {
                        tripDistance += 3;
                        waterDistance += 3;
                    }

                    tripDistance -= tenMinuteDistance;
                }
            }

            return waterDistance;
        }
    }
}
