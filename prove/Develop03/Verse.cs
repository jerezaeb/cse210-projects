using System;
class VerseScripture
    {
        private string scripture;
        private List<string> words;

        public VerseScripture(string scripture)
        {
            this.scripture = scripture;
            words = new List<string>(scripture.Split(" "));
        }

        public string GetScripture()
        {
            return scripture;
        }

        public List<string> GetWords()
        {
            return words;
        }

        public void RemoveWord(int index)
        {
            string word = words[index];
            words.RemoveAt(index);
            scripture = scripture.Replace(word, new string('_', word.Length));
        }
    }