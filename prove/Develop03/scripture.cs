class Scripture
    {
        private string reference;
        private string text;

        public Scripture(string reference, string text)
        {
            this.reference = reference;
            this.text = text;
        }

        public string Reference
        {
            get { return reference; }
            set { reference = value; }
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        
    }