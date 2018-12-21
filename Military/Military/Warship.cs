using System;

namespace Military
{
    public class Warship : Vehicle, ISwimmable
    {
        public double TotalFuelConsumption { get; set; }

        public Warship(double weight, int averageSpeed) : base(weight, averageSpeed)
        {
            Capacity = 50;
            FuelConsumption = 200;
        }

        public string Print(int soldierAmount, int warshipDistance)
        {

            TotalFuelConsumption = Swim(soldierAmount, warshipDistance) * FuelConsumption / 100;

            return base.Print() + $"total fuel used: {TotalFuelConsumption}";
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
