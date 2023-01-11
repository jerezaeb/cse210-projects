using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is the magic number? ");
        string number = Console.ReadLine ();
        int magicNumber =  int.Parse(number); 
        int guess = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess =  int.Parse (Console.ReadLine();
            
            if (guess < magicNumber)
            {
                Console.Write ("Higher");
            }

            else if (guess > magicNumber)
            {
                Console.Write ("Lower");
            }
            else
            {
                Console.Write ("You guessed it");
            }
        }

    }
}