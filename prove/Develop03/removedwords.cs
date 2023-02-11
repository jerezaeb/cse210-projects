class ScriptureManager
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Scripture Memorization Program\n");

            // Create a scripture verse
            ScriptureVerse verse = new ScriptureVerse("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

            // Display the verse
            Console.WriteLine("Scripture Verse:\n" + verse.Text + "\n");

            // Remove words randomly
            Random rand = new Random();
            while (verse.Words.Length > 0)
            {
                Console.WriteLine("Press Enter to remove a word...");
                Console.ReadLine();

                int index = rand.Next(verse.Words.Length);
                string[] newWords = new string[verse.Words.Length - 1];
                for (int i = 0, j = 0; i < verse.Words.Length; i++)
                {
                    if (i != index)
                    {
                        newWords[j++] = verse.Words[i];
                    }
                }
                verse.Words = newWords;

                Console.WriteLine("\n" + string.Join(" ", verse.Words) + "\n");
            }

            Console.WriteLine("You have successfully memorized the verse!");
            Console.ReadLine();
        }
    }