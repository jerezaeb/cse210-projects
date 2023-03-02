using System;
public class Activity

{
protected string _beginningMessage;

protected int _duration;

protected string _activityName = "";

public Activity (string activityName,string beginningMessage, int duration)
    {  
        _activityName = activityName;
        _beginningMessage = beginningMessage;
        _duration = duration;
    }

public int setDuration {set => _duration = value;}

public void GetBeginningMessagge()
{
    Console.WriteLine  ($"Welcome to the {_activityName}");
    Console.WriteLine ("\n" + _beginningMessage + "\n");


}

public string GetEndingMessage ()
{
    return $"You have completed another {_duration} seconds of the {_activityName}";
}

public string WellDoneMessage ()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    return $"Well Done!" ;
}
public int GetDuration()
{
Console.Write ($"How long would you like for your session, in seconds? ");
string userDuration = Console.ReadLine ();

if (int.TryParse (userDuration, out _duration))
    {
        return int.Parse (userDuration);
    }

else  
    {
        _duration = 30;
        Console.WriteLine ("Error, not an integer");
        Console.Write ("Press any key to continue");
        Console.ReadKey();
        return _duration;
    }
}

public void ShowAnimation (int period)
{
    DateTime currentTime = DateTime.Now;
    DateTime endTime = DateTime.Now.AddSeconds (period);
    DateTime startTime = DateTime.Now;
    while (currentTime < endTime)

    {
        List <string> chars = new List<string> () {"\\","|","/", "-"};
        foreach (string sign in chars)
        {
            Console.Write (sign);
            Thread.Sleep (150);
            Console.Write ("\b \b");
        }
        currentTime = DateTime.Now;
    }
}
}