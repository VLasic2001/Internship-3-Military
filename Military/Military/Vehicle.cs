using System;

namespace Military
{
    public class Vehicle
    {
        public Guid Id { get; set; }
        public double Weight { get; set; }
        public int AverageSpeed { get; set; }
        public int FuelConsumption { get; set; }
        public int Capacity { get; set; }

        public Vehicle(double weight, int averageSpeed)
        {
            Id = Guid.NewGuid();
            Weight = weight;
            AverageSpeed = averageSpeed;
        }

        public string Print()
        {
            return $"\n Id: {Id}, weight: {Weight}, average speed: {AverageSpeed}, fuel consumption: {FuelConsumption}, capacity: {Capacity}, ";
        }

        public int AmountOfTrips(double soldierAmount)
        {
            return (int)Math.Ceiling(soldierAmount / Capacity) * 2 - 1;
        }
    }
}
