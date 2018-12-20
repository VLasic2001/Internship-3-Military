using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public abstract class Vehicle
    {
        public Guid Id { get; set; }
        public double Weight { get; set; }
        public double AverageSpeed { get; set; }
        public static int FuelConsumption { get; set; }
        public static int Capacity { get; set; }

        public Vehicle(Guid id, double weight, double averageSpeed)
        {
            Id = id;
            Weight = weight;
            AverageSpeed = averageSpeed;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Id: {Id}, weight: {Weight}, average speed: {AverageSpeed},fuel consumption: {FuelConsumption}, capcaity: {Capacity}, ");
        }
    }
}
