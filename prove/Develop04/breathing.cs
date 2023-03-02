using System;

public class Breathing : Activity
{
    public Breathing (string activityName, string beginningMessage, int duration) : base (activityName,beginningMessage, duration)
    {
    }

    public void PrintActivity() 
    {        
            ShowAnimation(5);
            DateTime starTime = DateTime.Now;
            DateTime endTime = starTime.AddSeconds (_duration);
            DateTime currentTime = DateTime.Now;
            while (currentTime < endTime) {
            
                ShowCounter ("in");
                Console.WriteLine();
                ShowCounter ("out");
                Console.WriteLine("\n");
                currentTime = DateTime.Now;
             }
            Console.WriteLine (WellDoneMessage());
            ShowAnimation (5);

        }
    static void ShowCounter (string inOut)
    {
        string message;
        int i;
        if (inOut == "in")
        {
            message = $"Breathe in....";
            i = 4;
        }
        else
        {
            message = $"Breathe out....";
            i = 6;
        }
        Console.Write (message);
        for (; i > 0; --i )
        {
            Console.Write (i);
            Thread.Sleep (1000);
            Console.Write ("\b \b");

        }
    }
}