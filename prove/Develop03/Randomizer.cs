using System;
class Randomizer
    {
        public string GetRandomWord(List<string> words)
        {
            var random = new Random();
            var index = random.Next(0, words.Count);

            return words[index];
        }
    }