using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public abstract class Vehicle
    {
        public int Id { get; set; }
        public double Weight { get; set; }
        public double AverageSpeed { get; set; }
        public static int FuelConsumption { get; set; }
        public static int Capacity { get; set; }

        public Vehicle(int id, double weight, double averageSpeed)
        {
            Id = id;
            Weight = weight;
            AverageSpeed = averageSpeed;
        }

        protected virtual void Print()
        {
            Console.WriteLine($"Id: {Id}, weight: {Weight}, average speed: {AverageSpeed}");
        }
    }
}
