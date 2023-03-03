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
        Console.WriteLine ("\nConsider the following prompt: ");
        Console.WriteLine ($"\n{GetRamdomPrompt()} \n");
        Console.Write ("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine ("\nNow ponder on each of the following questions as they related to this experience. \nYou may begin in: ");
        for (int i= 5; i>0; i--)
        {
            Console.Write (i);
            Thread.Sleep (1000);
            Console.Write ("\b \b");
        }
        DateTime starTime = DateTime.Now;
        DateTime endTime =starTime.AddSeconds (_duration);
        DateTime currentTime = DateTime.Now;
        Console.Clear ();

        while (currentTime < endTime)
        {
            Console.Write ("\n" + GetRandomQuestion() + "");
            ShowAnimation (_thinkTime);
            currentTime = DateTime.Now;
        }
        Console.WriteLine ("\n");
        Console.WriteLine (WellDoneMessage());


    }
}