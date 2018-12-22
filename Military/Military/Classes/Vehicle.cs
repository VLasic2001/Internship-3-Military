using System;

namespace Military.Classes
{
    public abstract class Vehicle
    {
        public Guid Id { get; set; }
        public double Weight { get; set; }
        public int AverageSpeed { get; set; }
        public int FuelConsumption { get; set; }
        public int Capacity { get; set; }

        protected Vehicle(double weight, int averageSpeed)
        {
            Id = Guid.NewGuid();
            Weight = weight;
            AverageSpeed = averageSpeed;
        }

        public override string ToString()
        {
            return "\n" +
                   $"Id: {Id},\n" +
                   $"weight: {Weight}kg,\n" +
                   $"average speed: {AverageSpeed}km/h,\n" +
                   $"fuel consumption: {FuelConsumption}L/100km\n" +
                   $"capacity: {Capacity},\n";
        }

        public int AmountOfTrips(double soldierAmount)
        {
            return (int)Math.Ceiling(soldierAmount / Capacity) * 2 - 1;
        }
    }
}
