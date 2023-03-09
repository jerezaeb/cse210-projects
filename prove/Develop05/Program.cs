using System;

class Program
{
    static void Main(string[] args)
    {

            private static List<Goals> goals = new List <Goals>();
            private static int totalPoints = 0;

            while (true)
            {
                Console.WriteLine ("Menu Options:");
                Console.WriteLine ("1. Create New Goal");
                Console.WriteLine ("2. List Goals");
                Console.WriteLine ("3. Save Goals");
                Console.WriteLine ("4. Load Goals");
                Console.WriteLine ("5. Record Event");
                Console.WriteLine ("6. Exit");
                Console.Write ("Select a choice from the menu: ");
                int choice = int.Parse (Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CreateGoals();
                        break;
                    case 2:
                        //ListGoals();
                        break;      
                    case 3:
                        //SaveGoals();
                        break;
                    case 4:
                        //LoadGoals();
                        break;
                    case 5:
                        //RecordEvent();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine ("Invalid option.");
                        break;
                }
                Console.WriteLine ($"Total Points : {totalPoints}");

            }
        
        public static void CreateGoals()
        {
            Console.WriteLine ("The type of Goals are :");
            Console.WriteLine ("1. Simple Goal");
            Console.WriteLine ("2. Eternal Goal");
            Console.WriteLine ("3. Checklist Goal");
            int goalType = int.Parse (Console.ReadLine());

            Console.WriteLine ("Enter a goal name:");
            string name = Console.ReadLine ();
            Console.WriteLine ("Enter a goal descriptio:");
            string description = Console.ReadLine ();
            Console.WriteLine  ("Points for goal completed: ");
            int points = int.Parse (Console.ReadLine());
            bool IsCompleted = false;
            
            
            switch (goalType)
        {
            case 1:
                goals.Add(new SimpleGoals(name, description, IsCompleted, points));
                
                break;
            case 2:
                goals.Add(new EternalGoals (name,description,IsCompleted, points));
                break;
            case 3:

                Console.WriteLine("Enter number of tasks:");
                int numTasks = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoals (name, description, IsCompleted, points, numTasks, 0));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
        }
        
    }
 
}