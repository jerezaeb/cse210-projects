using System;
class ScriptureRepository
{
    private List<Scripture> _scriptures;

    public List<Scripture> Scriptures
    {
        get { return _scriptures; }
    }

    public ScriptureRepository()
    {
        _scriptures = new List<Scripture>();
    }

    public void AddScripture(Scripture scripture)
    {
        _scriptures.Add(scripture);
    }
}
