using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public abstract class Vehicle
    {
        public Guid Id { get; set; }
        public double Weight { get; set; }
        public int AverageSpeed { get; set; }
        public static int FuelConsumption { get; set; }
        public static int Capacity { get; set; }

        public Vehicle(double weight, int averageSpeed)
        {
            Id = Guid.NewGuid();
            Weight = weight;
            AverageSpeed = averageSpeed;
        }

        public virtual void Print()
        {
            Console.Write($"Id: {Id}, weight: {Weight}, average speed: {AverageSpeed}, fuel consumption: {FuelConsumption}, capacity: {Capacity}, ");
        }

        public int AmountOfTrips(double soldierAmount)
        {
            return (int)Math.Ceiling(soldierAmount / Capacity) * 2 - 1;
        }


    }
}
