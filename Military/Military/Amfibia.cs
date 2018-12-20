using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    class Amfibia : Vehicle
    {
        public Amfibia(Guid id, double weight, double averageSpeed) : base(id, weight, averageSpeed)
        {
            Capacity = 20;
            FuelConsumption = 70;
        }

        public override void Print()
        {
            Console.WriteLine($"total fuel used: ");
        }
    }
}
