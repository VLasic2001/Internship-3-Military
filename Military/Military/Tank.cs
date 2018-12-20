using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public class Tank : Vehicle
    {
        public Tank(Guid id, double weight, double averageSpeed) : base(id, weight, averageSpeed)
        {
            Capacity = 6;
            FuelConsumption = 30;
        }

        public override void Print()
        {
            Console.WriteLine($"total fuel used: ");
        }

    }
}
