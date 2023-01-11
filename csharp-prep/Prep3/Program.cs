using System;

class Program
{
    static void Main(string[] args)
    {   string game= "";
        while (game == "yes")
        {  
        Console.Write("Do you want to play? ");
        game = Console.ReadLine();

            Random rnd = new Random();
            int magicNumber =  rnd.Next(100);
            int guess = 0;

            while (guess != magicNumber)
            {
                
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                if (guess < magicNumber)    
                {
                    Console.WriteLine ("Higher");
                }

                else if (guess > magicNumber)
                {
                    Console.WriteLine ("Lower");
                }
                else
                {
                    Console.WriteLine ("You guessed it");
                }
            }
        }
    }
}