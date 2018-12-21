using System;

namespace Military
{
    public class Tank : Vehicle, IDriveable
    {
        public double TotalFuelConsumption { get; set; }

        public Tank(double weight, int averageSpeed) : base(weight, averageSpeed)
        {
            Capacity = 6;
            FuelConsumption = 30; 
        }

        public string Print(int soldierAmount, int tankDistance)
        {

            TotalFuelConsumption = Move(soldierAmount, tankDistance) * FuelConsumption / 100;

            return base.Print() + $"total fuel used: {TotalFuelConsumption}.";
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
