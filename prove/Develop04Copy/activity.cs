using System;
public class Activity

{
private string _beginningMessage = " ";

private int _duration;

private string _activityName = "";

public Activity (string beginningMessage, string activityName, int duration)
    {
        _beginningMessage = beginningMessage;
        _activityName = activityName;
        _duration = duration;
    }

public int setDuration {set => _duration = value;}

public void GetBeginningMessagge()
{
    Console.WriteLine  ("\n" + _beginningMessage);

}

public string GetEndingMessage ()
{
    return $"You have completed another {_duration} seconds of the {_activityName}";
}

public string WellDoneMessage ()
{
    return $"Well Done!";
}
public int GetDuration()
{
Console.WriteLine ($" How long would you like for your session, in seconds?");
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
    currentTime = DateTime.Now;
    endTime = DateTime.Now + _duration;
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