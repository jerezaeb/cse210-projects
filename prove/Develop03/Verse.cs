using System;
class Verse
    {
        private string verse;

        public void SetVerse(string verse)
        {
            this.verse = verse;
        }

        public string[] GetWords()
        {
            return verse.Split(' ');
        }

        public string MaskWords(string[] words)
        {
            string maskedVerse = "";
            foreach (string word in words)
            {
                if (word != "")
                {
                    maskedVerse += word + " ";
                }
                else
                {
                    maskedVerse += new string('_', word.Length) + " ";
                }
            }
            return maskedVerse;
        }
    }