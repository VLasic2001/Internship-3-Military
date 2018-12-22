using Military.Interfaces;

namespace Military.Classes
{
    public class Tank : Vehicle, IDriveable
    {
        public double TotalFuelConsumption { get; set; }

        public Tank(double weight, int averageSpeed) : base(weight, averageSpeed)
        {
            Capacity = 6;
            FuelConsumption = 30; 
        }

        public override string ToString()
        {
            return $"\nTank:{base.ToString()}total fuel used: {TotalFuelConsumption}L.";
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
    }
}
