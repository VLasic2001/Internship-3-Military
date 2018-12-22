using Military.Interfaces;

namespace Military.Classes
{
    public class Amfibia : Vehicle, IDriveable, ISwimmable
    {
        public double TotalFuelConsumption { get; set; }

        public Amfibia(double weight, int averageSpeed) : base(weight, averageSpeed)
        {
            Capacity = 20;
            FuelConsumption = 70;
        }

        public override string ToString()
        {
            return $"\nAmfibia:{base.ToString()}total fuel used: {TotalFuelConsumption}L";
        }

        public double Move(int distance)
        {
            var tripDistance = distance;
            while (tripDistance >= 10)
            {
                if (RandomNumber.RandomNumberGenerator() < 30)
                {
                    distance += 5;
                    tripDistance += 5;
                }
                tripDistance -= 10;
            }
            return distance;
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
