public class Listing : Activity

{
    private int _items = 0;

    private List <string> _prompts = new List <string> ();

    public Listing (string activityName, string beginningMessage, int duration, List <string>  prompts) : base (activityName, beginningMessage, duration)
 {
    _prompts = prompts;

 }
 private string GetRamdomPrompt ()
 {
     Random random = new Random();
        int ind = random.Next (_prompts.Count);
        return (string) _prompts [ind];
 }

 public void PrintListing () {
    Console.WriteLine ("\nList as many responses you can to the following prompt: \n");
    Console.WriteLine ($"{GetRamdomPrompt()}\n");
    Console.WriteLine ("\nYou may begin in:");

    for (int i= 5; i>0; i--)
        {
            Console.Write (i);
            Thread.Sleep (1000);
            Console.Write ("\b \b");
        }
        DateTime starTime = DateTime.Now;
        DateTime endTime =starTime.AddSeconds (_duration);
        DateTime currentTime = DateTime.Now;
        Console.WriteLine ();
        while (currentTime < endTime)
        {
            Console.Write ("> ");
            Console.ReadLine ();
            currentTime = DateTime.Now;
            _items ++;
        }
        Console.WriteLine ($"\nYou listed {_items} items! \n");
        Console.WriteLine (WellDoneMessage());
    
 }

}