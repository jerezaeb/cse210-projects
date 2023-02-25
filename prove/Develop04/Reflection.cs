public class Reflection : Activity

{
    private int _thinkTime;

    private List <string> _prompts = new List<string> ();
    private List <string> _questions = new List<string> ();



    public Reflection ( string activityName, string beginningMessage, int duration, List <string> prompts, List <string> questions, int thinkTime) : base (activityName, beginningMessage, duration)

    {
        _thinkTime = thinkTime;
        _prompts = prompts;
        _questions = questions;
    }
    private string GetRamdomPrompt ()
    {
        Random random = new Random();
        int ind = random.Next (_prompts.Count);
        return (string) _prompts [ind];
    }

    private string GetRandomQuestion ()
    
    {
        Random random = new Random();
        int ind = random.Next (_questions.Count);
        return (string) _questions [ind];
    }

    public void PrintReflection () 
    {
        Console.WriteLine ("Consider the following prompt: ");
        Console.WriteLine ("{GetRamdomPrompt}");
        Console.WriteLine ("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.Write ("Now ponder on each of the following questions as they related to this experience. \n You may begin in: ");
        for (int i= 5; i>0; i--)
        {
            Console.Write (i);
            Thread.Sleep (1000);
            Console.Write ("\b \b");
        }
        DateTime starTime = DateTime.Now;
        DateTime endTime =starTime.AddSeconds (duration);
        DateTime currentTime = DateTime.Now;
        Console.Clear ();

            }
}