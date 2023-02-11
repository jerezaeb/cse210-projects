using System;
class Randomizer
    {
        private Random random = new Random();

        public int GetRandomIndex(int count)
        {
            return random.Next(0, count);
        }
    }