using System;
class Verse
    
    {
        public string[] Words { get; set; }
        public bool AllWordsRemoved { get; set; }
        public bool ShouldQuit { get; set; }

        public Verse(string verse)
        {
            Words = verse.Split(' ');
            AllWordsRemoved = false;
            ShouldQuit = false;
        }

        public void RemoveWord(int index)
        {
            if (index >= 0 && index < Words.Length)
            {
                Words[index] = string.Join("", Enumerable.Repeat("_", Words[index].Length));
                AllWordsRemoved = !Words.Any(word => word != "_");
            }
        }

        public override string ToString()
        {
            return string.Join(" ", Words);
        }
    }