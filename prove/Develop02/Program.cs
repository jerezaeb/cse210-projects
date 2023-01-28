using System;
class Program
{
    static void Main(string[] args)
    {
        var journal = new Journal();
        var promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Save");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Display");
            Console.WriteLine("5. Exit");
            Console.Write ("What do you want to do? Press the number: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine(promptGenerator.RandomPromptGenerator());
                    var text = Console.ReadLine();
                    journal.AddEntry(text);
                    break;
                case "2":
                    Console.WriteLine("Enter file path:");
                    var fileName = Console.ReadLine();
                    journal.SaveToFile(fileName);
                    break;
                case "3":
                    Console.WriteLine("Enter file path:");
                    fileName = Console.ReadLine();
                    journal.LoadFromFile(fileName);
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
