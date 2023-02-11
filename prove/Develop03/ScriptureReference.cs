using System;
class ScriptureReference
 {
        public List<string> Verses { get; set; }

        public ScriptureReference()
        {
            Verses = new List<string>()
            {
                "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.",
                "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.",
                "Do not be anxious about anything, but in every situation, by prayer and petition, with thanksgiving, present your requests to God.",
                "For I know the plans I have for you, declares the Lord, plans to prosper you and not to harm you, plans to give you hope and a future."
            };
        }
    }
