using System;
class Scripture
{
    private string _verse;
    private List<string> _removedWords;

    public string Verse
    {
        get { return _verse; }
        set { _verse = value; }
    }

    public List<string> RemovedWords
    {
        get { return _removedWords; }
    }

    public Scripture(string verse)
    {
        _verse = verse;
        _removedWords = new List<string>();
    }

    public void RemoveRandomWord()
    {
        string[] words = _verse.Split(' ');
        Random rand = new Random();
        int wordIndex = rand.Next(0, words.Length);
        string removedWord = words[wordIndex];
        _removedWords.Add(removedWord);
        words[wordIndex] = new string('_', removedWord.Length);
        _verse = string.Join(' ', words);
    }
}