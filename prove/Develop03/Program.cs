using System;
using System.Collections.Generic;

namespace ScriptureMemorization
{
    class Program
    {
        static void Main(string[] args)
        {
            ScriptureReference scriptureReference = new ScriptureReference();
            Randomizer randomizer = new Randomizer();
            Verse verse = new Verse();

            List<string> verses = scriptureReference.GetVerses();
            Console.WriteLine("Select a verse to memorize:");
            for (int i = 0; i < verses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {verses[i]}");
            }
            Console.Write("Enter your selection: ");
            int selection = Convert.ToInt32(Console.ReadLine());
            string selectedVerse = verses[selection - 1];
            verse.SetVerse(selectedVerse);
            string[] words = verse.GetWords();
            string maskedVerse = verse.MaskWords(words);

            while (maskedVerse.Contains("_"))
            {
                Console.WriteLine(maskedVerse);
                Console.WriteLine("Press enter to remove a word or type 'quit' to stop:");
                string input = Console.ReadLine();
                if (input == "quit")
                {
                    break;
                }
                int index = randomizer.GetRandomIndex(words.Length);
                words[index] = "";
                maskedVerse = verse.MaskWords(words);
            }
            Console.WriteLine("Well done- you have memorized the scripture");
        }
    }