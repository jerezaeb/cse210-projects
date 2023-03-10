using System;

class Program
{
    static void Main(string[] args)
    {
    List<Goals> goals = new List <Goals>();
    int totalPoints = 0;

    while(true)
    {
        Console.WriteLine ("Menu Options:");
        Console.WriteLine ("1. Create New Goal");
        Console.WriteLine ("2. List Goals");
        Console.WriteLine ("3. Save Goals");
        Console.WriteLine ("4. Load Goals");
        Console.WriteLine ("5. Record Event");
        Console.WriteLine ("6. Exit");
        Console.Write ("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice){
            case 1:
                Console.WriteLine ("The type of Goals are :");
                Console.WriteLine ("1. Simple Goal");
                Console.WriteLine ("2. Eternal Goal");
                Console.WriteLine ("3. Checklist Goal");
                int goalType = int.Parse (Console.ReadLine());
                Console.WriteLine ("Enter a goal name:");
                string name = Console.ReadLine ();
                Console.WriteLine ("Enter a goal description:");
                string description = Console.ReadLine ();
                Console.WriteLine  ("Points for goal completed: ");
                int points = int.Parse (Console.ReadLine());
                bool IsCompleted = false;
            
                switch (goalType){
                    case 1:
                        SimpleGoals simpleGoal = new SimpleGoals(name, description, IsCompleted, points);
                        goals.Add(simpleGoal);
                        // checking if it was actually created. Remove when thigns will work good
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("--- Testing goal creation: ---");
                        Console.WriteLine(simpleGoal.GoalsToString());
                        Console.ResetColor();
                        break;
                    case 2:
                        EternalGoals eternalGoal = new EternalGoals (name,description,IsCompleted, points);
                        goals.Add(eternalGoal);
                        // checking if it was actually created. Remove when thigns will work good
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("--- Testing goal creation: ---");
                        Console.WriteLine(eternalGoal.GoalsToString());
                        Console.ResetColor();
                        break;
                    case 3:
                        Console.WriteLine("Enter number of tasks:");
                        int numTasks = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the bonus for completion: ");
                        int bonus = int.Parse(Console.ReadLine());
                        ChecklistGoals checklistGoal = new ChecklistGoals (name, description, IsCompleted, points, bonus, 0, numTasks);
                        goals.Add(checklistGoal);
                        // checking if it was actually created. Remove when thigns will work good
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("--- Testing goal creation: ---");
                        Console.WriteLine(checklistGoal.GoalsToString());   
                        Console.ResetColor();              
                        break;
                    default:
                        Console.WriteLine("Invalid goal type.");
                        break;
                    }
                break;
            case 2:
                //ListGoals();
                // you will most likely make it outside and just call the method here. but...
                // for testing purposes lets display goals here right away
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("--- Testing displaying the goals: ---");
                if (goals.Count == 0) System.Console.WriteLine("!!!!!!!!!! empty !!!!!!!!!!");
                else{
                    int count = 1;
                    foreach(Goals goal in goals){
                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine(count + ". " + goal.GoalsToString());
                        count++;
                    }
                }
                Console.ResetColor();
                break;      
            case 3:
                //SaveGoals();
                // you will most likely make it outside and just call the method here. but...
                // for testing purposes lets save goals to a file from here
                Console.Write("Filename to save to: ");
                string filename = Console.ReadLine();
                using (StreamWriter sw = new StreamWriter(filename, false))
                {
                    sw.WriteLine($"Points: {totalPoints}");
                    foreach (Goals goal in goals)
                    {
                        sw.WriteLine(goal.GoalsToString());
                    }
                }
                break;
            case 4:
                //LoadGoals();   
                // you will most likely make it outside and just call the method here. but...
                // for testing purposes lets load goals from a file here
                Console.Write("Filename to load from: ");
                filename = Console.ReadLine();
                string[] goalsFile = File.ReadAllLines(filename);
                // clearing Goals list so we don't append to exisitng list of goals
                goals.Clear();
                foreach(string line in goalsFile){
                    // splitting the line on separator (in our case it is ; )
                    string[] splitted = line.Split(";");
                    // depending on the goal type create an object of goal and
                    // put it in the list of goals to be displayed later
                    if(splitted[0]=="SimpleGoal"){
                        goals.Add(new SimpleGoals(splitted[1], splitted[2],
                            bool.Parse(splitted[3]), Int32.Parse(splitted[4])));
                    }
                    else if(splitted[0]=="EternalGoal"){
                        goals.Add(new EternalGoals(splitted[1], splitted[2],
                            bool.Parse(splitted[3]), Int32.Parse(splitted[4])));
                    }
                    else if(splitted[0]=="CheckListGoal")
                        goals.Add(new ChecklistGoals(splitted[1], splitted[2],
                            bool.Parse(splitted[3]), Int32.Parse(splitted[4]), 
                            Int32.Parse(splitted[5]), Int32.Parse(splitted[6]), 
                            Int32.Parse(splitted[7])));
                }
                          
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
}
}