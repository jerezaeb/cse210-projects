using System;
class Randomizer
    {
        private static readonly Random Random = new Random();

        public int NextWordIndex(int maxValue)
        {
            return Random.Next(maxValue);
        }
    }