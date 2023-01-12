using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userInput;
        int sum = 0;
        int highest = int.MinValue;

        Console.WriteLine("Enter number, enter 0 to stop:");
        userInput = int.Parse(Console.ReadLine());

        while (userInput != 0)
        {
            numbers.Add(userInput);
            userInput = int.Parse(Console.ReadLine());
        }

        numbers.Sort();
        Console.WriteLine("Numbers entered and sorted: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
            sum += number;
            highest = Math.Max(highest, number);
        }
        double average = sum / (double)numbers.Count;
        Console.WriteLine("Sum of all numbers: " + sum);
        Console.WriteLine("Average of all numbers: " + average);
        Console.WriteLine("The highest number is: " + highest);
    }

    
    
}