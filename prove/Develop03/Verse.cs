using System;
class Verse
    
{
    public List<string> Words { get; private set; }

    public Verse(string verse)
        {
            Words = verse.Split(' ').ToList();
        }

    public void RemoveWord(string word)
        {
            Words.Remove(word);
        }

     public override string ToString()
        {
            var result = "";
            var random = new Random();

            foreach (var word in Words)
            {
                var maskedWord = "";
                foreach (var character in word)
                {
                    if (random.Next(0, 2) == 0)
                    {
                        maskedWord += "_";
                    }
                    else
                    {
                        maskedWord += character;
                    }
                }

                result += maskedWord + " ";
            }

            return result;
        }
}

