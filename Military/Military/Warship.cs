﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    class Warship : Vehicle
    {
        public Warship(Guid id, double weight, double averageSpeed) : base(id, weight, averageSpeed)
        {
            Capacity = 50;
            FuelConsumption = 200;
        }

        public override void Print()
        {
            Console.WriteLine($"total fuel used: ");
        }
    }
}
