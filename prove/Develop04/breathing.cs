public class Breathing : Activity

    public Breathing (string activityName, String beginningMessage, int duration) : base (activityName, beginningMessage, duration)
    {}

    public void PrintActivity()

    {
        ShowAnimation(5)
        {
            DateTime starTime = DateTime.Now;
            DateTime endTime =starTime.AddSeconds (_duration);
            DateTime currentTime = DateTime.Now;
            while (currentTime < endTime) {
                ShowCounter ("in");
                Console.WriteLine();
                ShowCounter ("out");
                Console.WriteLine();
                currentTime = DateTime.Now
            }
            Console.WriteLine (WellDoneMessage());
            ShowAnimation (5);
            
    }