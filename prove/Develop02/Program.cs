using System;
class Program
{
    static void Main(string[] args)
    {
        var journal = new Journal();
        var promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("1. Write an entry");
            Console.WriteLine("2. Save to file");
            Console.WriteLine("3. Load from file");
            Console.WriteLine("4. Display entries");
            Console.WriteLine("5. Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine(promptGenerator.GetRandomPrompt());
                    var text = Console.ReadLine();
                    journal.AddEntry(text);
                    break;
                case "2":
                    Console.WriteLine("Enter file path:");
                    var path = Console.ReadLine();
                    journal.SaveToFile(path);
                    break;
                case "3":
                    Console.WriteLine("Enter file path:");
                    path = Console.ReadLine();
                    journal.LoadFromFile(path);
                    break;
                case "4":
                    journal.DisplayEntries();
                    break;
                case "5":
                    return;
            }
        }
    }
}
