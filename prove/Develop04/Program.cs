using System;

class Program
{
    static void Main(string[] args)
    {
        List <string> activityItems = new List<string> 
        {
            "Start breathing activity",
            "Start reflecting activity",
            "Start listing activity",
            "Quit"
        };

        object [,] activityNameDesc = new object [3,2]
        {
            {"Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly.Clear your mind and focus on your breathing."},
            {"Reflection Activity" , "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."},
            {"Listing Activity" , "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."}
        };

        List <string> reflectioPrompts = new List<string>

        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };

        List <string>  reflectionQuestions = new List<string>
        {

            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",        
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };

        List <string> listingPrompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?", 
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };

    int duration = 0;
    
        Console.WriteLine("Welcome to Mindfulness Activity. Please select what you would like to do?");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.Write ("What do you want to do? Press the number:  ");
        var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    Activity activity1 = new Activity ((string) activityNameDesc [0,0], (string) activityNameDesc [0,1], duration);
                    activity1.GetBeginningMessagge ();
                    duration = activity1.GetDuration ();
                    activity1.SetDuration = duration;
                    Console.Clear();
                    Console.WriteLine ("Get Ready!");
                    Breathing breathing = new Breathing ((string) activityNameDesc [0,0], (string) activityNameDesc [0,1], duration);
                    breathing.PrintActivity ();
                    Console.WriteLine (activity1.GetEndingMessage());
                    activity1.ShowAnimation(5);
                    break;
                case "2":
                    Console.Clear();
                    Activity activity2 = new Activity ((string) activityNameDesc [1,0], (string) activityNameDesc [1,1], duration);
                    activity2.GetBeginningMessagge ();
                    duration = activity2.GetDuration ();
                    activity2.SetDuration = duration;
                    Console.Clear();
                    Console.WriteLine ("Get Ready!");
                    Reflection reflection = new Reflection ((string) activityNameDesc [1,0], (string) activityNameDesc [1,1], duration);
                    reflection.PrintReflection ();
                    Console.WriteLine (activity2.GetEndingMessage());
                    activity2.ShowAnimation(5);
                    break;
                case "3":
                    Console.Clear();
                    Activity activity3 = new Activity ((string) activityNameDesc [2,0], (string) activityNameDesc [2,1], duration);
                    activity3.GetBeginningMessagge ();
                    duration = activity3.GetDuration ();
                    activity3.SetDuration = duration;
                    Console.Clear();
                    Console.WriteLine ("Get Ready!");
                    Listing listing = new Listing ((string) activityNameDesc [1,0], (string) activityNameDesc [1,1], duration);
                    listing.PrintListing ();
                    Console.WriteLine (activity3.GetEndingMessage());
                    activity3.ShowAnimation(5);
                    break;
                case "4":
                    return;
            }
        

    
    }
}
