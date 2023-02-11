using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Scripture Memory program!");
            Console.WriteLine("Here is a list of available scriptures:");

            ScriptureReference scriptureReference = new ScriptureReference();
            foreach (string verse in scriptureReference.Verses)
            {
                Console.WriteLine(verse);
            }

            Console.WriteLine("\nPlease select a verse to memorize:");
            string selectedVerse = Console.ReadLine();

            Console.WriteLine("\nMemorize the following verse:");
            Verse verseToMemorize = new Verse(selectedVerse);
            Randomizer randomizer = new Randomizer();

            while (!verseToMemorize.AllWordsRemoved && !verseToMemorize.ShouldQuit)
            {
                Console.WriteLine(verseToMemorize.ToString());
                Console.ReadLine();

                verseToMemorize.RemoveWord(randomizer.NextWordIndex(verseToMemorize.Words.Count));
            }

            Console.WriteLine("\nYou have completed memorizing the verse.");
            Console.WriteLine("The verse was: " + selectedVerse);
        }
    }
}
