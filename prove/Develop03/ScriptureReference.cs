using System;

class ScriptureReference
    {
        private List<string> verses = new List<string>()
        {
            "Love the Lord your God with all your heart and with all your soul and with all your mind",
            "Trust in the Lord with all your heart and lean not on your own understanding",
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life",
            "Blessed are the peacemakers, for they will be called children of God"
        };

        public List<string> GetVerses()
        {
            return verses;
        }
    }