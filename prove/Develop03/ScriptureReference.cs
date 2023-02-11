using System;
class ScriptureReference
    {
        private List<string> verses = new List<string>
        {
            "Doctrine and Covenants 58:27 Verily I say, men should be aanxiously engaged in a good cause, and do many things of their own free will, and bring to pass much righteousness; 28 For the power is in them, wherein they are aagents unto themselves. And inasmuch as men do good they shall in nowise lose their breward.",
            "Proverbs 3: 5 Trust in the Lord with all thine bheart; and lean not unto thine cown dunderstanding. 6 In all thy ways aacknowledge him, and he shall bdirect thy cpaths."
        };

       public string GetVerse()
        {
            var random = new Random();
            var index = random.Next(0, verses.Count);

            return verses[index];
        }
    }