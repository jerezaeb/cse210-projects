using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running (new DateOnly(2023, 2, 10), 60, 60);
        Cycling cycling = new Cycling (new DateOnly (2023, 3, 21), 60, 60);
        Swimming swimming = new Swimming (new DateOnly (2023, 3, 27), 60, 60);

        List <Exercise> exercises = new List<Exercise> ();
        exercises.Add (running);
        exercises.Add (cycling);
        exercises.Add (swimming);

        foreach (Exercise exercise in exercises)
        {
            Console.WriteLine ($"{exercise.GetType().Name} {exercise.GetSummary()}");
        }

    }
}