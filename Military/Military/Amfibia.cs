using System;

namespace Military
{
    public class Amfibia : Vehicle, IDriveable, ISwimmable
    {
        public double TotalFuelConsumption { get; set; }

        public Amfibia(double weight, int averageSpeed) : base(weight, averageSpeed)
        {
            Capacity = 20;
            FuelConsumption = 70;
        }

        public string Print(int soldierAmount, int amfibiaLandDistance, int amfibiaWaterDistance)
        {
            TotalFuelConsumption = (Move(soldierAmount, amfibiaLandDistance) + Swim(soldierAmount, amfibiaWaterDistance)) * FuelConsumption / 100;

            return base.Print() + $"total fuel used: {TotalFuelConsumption}";
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
