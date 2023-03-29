using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running (new DateOnly(2023, 2, 10), 30, 5);
        Cycling cycling = new Cycling (new DateOnly (2023, 3, 21), 30, 9.7);
        Swimming swimming = new Swimming (new DateOnly (2023, 3, 27), 30, 10);

        List <Exercise> exercises = new List<Exercise> ();
        exercises.Add (running);
        exercises.Add (cycling);
        exercises.Add (swimming);

        foreach (Exercise exercise in exercises)
        {
            Console.WriteLine (exercise.GetSummary());
        }

    }
}