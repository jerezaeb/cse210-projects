using System;
  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scripture Memorization Tool");
            Console.WriteLine("Enter a verse to start memorizing: ");
            string verse = Console.ReadLine();

            VerseScripture scripture = new VerseScripture(verse);
            Randomizer randomizer = new Randomizer();

            while (true)
            {
                Console.WriteLine("Press enter to remove a word, type 'quit' to exit: ");
                string input = Console.ReadLine();

                if (input == "quit")
                {
                    break;
                }

                scripture.RemoveWord(randomizer.GetRandomIndex(scripture.GetWords().Count));
                Console.WriteLine(scripture.GetScripture());
            }
        }
    }
