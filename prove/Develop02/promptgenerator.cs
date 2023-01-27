using System;
class PromptGenerator
{
    private List<string> prompts = new List<string>
    {
        "What did you learn today?",
        "What are you grateful for?",
        "What are your goals for tomorrow?",
        "What challenges did you face today?",
        "What did you accomplish today?",
    };

    public string GetRandomPrompt()
    {
        var random = new Random();
        return prompts[random.Next(prompts.Count)];
    }
}
