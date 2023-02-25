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

public string GetDuration()
{


}

}