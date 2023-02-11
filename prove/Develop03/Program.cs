using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scripture Memorization Program");
            Console.WriteLine("=============================");

            var reference = new ScriptureReference();
            var randomizer = new Randomizer();
            var verse = new Verse(reference.GetVerse());
            string input;

            do
            {
                Console.WriteLine(verse.ToString());
                Console.WriteLine("Press Enter to remove a word or type 'quit' to exit the program.");
                input = Console.ReadLine();

                if (input != "quit")
                {
                    verse.RemoveWord(randomizer.GetRandomWord(verse.Words));
                }
            } while (input != "quit" && verse.Words.Count > 0);

            Console.WriteLine("Program finished. Goodbye!");
        }
    }
}