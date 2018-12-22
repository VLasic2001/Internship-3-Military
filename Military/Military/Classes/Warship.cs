using Military.Interfaces;

namespace Military.Classes
{
    public class Warship : Vehicle, ISwimmable
    {
        public double TotalFuelConsumption { get; set; }

        public Warship(double weight, int averageSpeed) : base(weight, averageSpeed)
        {
            Capacity = 50;
            FuelConsumption = 200;
        }

        public override string ToString()
        {
             return "\n" +
                   $"Warship:{base.ToString()}total fuel used: {TotalFuelConsumption}L.";
        }

        public double Swim(double distance)
        {
            var tripDistance = distance;
            var tenMinuteDistance = AverageSpeed / 6;
            while (tripDistance >= tenMinuteDistance)
            {
                if (RandomNumber.RandomNumberGenerator() < 50)
                {
                        distance += 3;
                        tripDistance += 3;
                }
                    tripDistance -= tenMinuteDistance;
            }
            return distance;
        }
    }
}
