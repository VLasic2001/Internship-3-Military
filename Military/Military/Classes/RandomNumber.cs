using System;

namespace Military.Classes
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
