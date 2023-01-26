using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("1. Add entry");
            Console.WriteLine("2. Save journal");
            Console.WriteLine("3. Load journal");
            Console.WriteLine("4. Display journal entries");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter your journal entry: ");
                    string entry = Console.ReadLine();
                    journal.AddEntry(entry);
                    break;
                case 2:
                    Console.Write("Enter file path to save journal: ");
                    string filePath = Console.ReadLine();
                    journal.Save(filePath);
                    break;
                case 3:
                    Console.Write("Enter file path to load journal: ");
                    filePath = Console.ReadLine();
                    journal.Load(filePath);
                    break;
                case 4:
                    journal.DisplayEntries();
                    break;
                case 5:
                    return;
            }
        }
    }
}
