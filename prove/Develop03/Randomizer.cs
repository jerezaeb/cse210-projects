using System;
class Randomizer
    {
        private static Random random = new Random();

        public int GetRandomIndex(int max)
        {
            return random.Next(max);
        }
    }