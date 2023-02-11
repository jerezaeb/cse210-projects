class ScriptureVerse : Scripture
    {
        private string[] words;

        public ScriptureVerse(string reference, string text) : base(reference, text)
        {
            words = text.Split(' ');
        }

        public string[] Words
        {
            get { return words; }
            set { words = value; }
        }
    }