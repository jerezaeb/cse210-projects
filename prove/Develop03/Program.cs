using System;
class Program
{
    static void Main(string[] args)
    {
        ScriptureRepository repository = new ScriptureRepository();
        repository.AddScripture(new Scripture("For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
        repository.AddScripture(new Scripture("Love the Lord your God with all your heart and with all your soul and with all your mind."));
        repository.AddScripture(new Scripture("Do unto others as you would have them do unto you."));

        Console.WriteLine("Welcome to the Scripture Memorization Program!");
        Console.WriteLine("Press Enter to remove a word from the verse. Type 'quit' to exit the program.");

        while (true)
        {
            Console.WriteLine();
            Random rand = new Random();
            int scriptureIndex = rand.Next(0, repository.Scriptures.Count);
            Scripture scripture = repository.Scriptures[scriptureIndex];
            Console.WriteLine(scripture.Verse);
            Console.WriteLine();
            Console.WriteLine("Removed words: " + string.Join(", ", scripture.RemovedWords));

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.RemoveRandomWord();
        }
    }
}


