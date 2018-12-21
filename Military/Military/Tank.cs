using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Military
{
    public class Tank : Vehicle, IDriveable
    {
        public Tank(double weight, int averageSpeed) : base(weight, averageSpeed)
        {
            Capacity = 6;
            FuelConsumption = 30;
        }

        public void Print(int soldierAmount, int tankDistance)
        {
            Console.WriteLine($"Total fuel used: {Move(soldierAmount, tankDistance)*FuelConsumption}");
        }

        public double Move(int soldierAmount, int landDistance)
        {
            var amountOfTrips = AmountOfTrips(soldierAmount);
            var singleTripDistance = landDistance;

            for (var i = 0; i < amountOfTrips; i++)
            {
                var tripDistance = singleTripDistance;
                while (tripDistance >= 10)
                {
                    if (RandomNumber.RandomNumberGenerator() < 30)
                    {
                        tripDistance += 5;
                        landDistance += 5;
                    }

                    tripDistance -= 10;
                }
            }

            return landDistance;
        }
    }
}
