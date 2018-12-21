using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public static class RandomNumber
    {
        public static int RandomNumberGenerator()
        {
            var random = new Random();
            return random.Next(0, 100);
        }
    }
}
