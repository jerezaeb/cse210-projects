using System;

class Program

{
    static void Main(string[] args)
    {
    Reception reception = new Reception("Reception Party", "Celebrate the Marriage of Kaitlyne and Justin", new DateOnly (2023, 6, 10), new TimeOnly (18, 0, 0), "143 Grove St, Beachtown CA USA", "guest@wedding.com");

        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine ("Reception Event");
        Console.WriteLine(reception.GetShortDescription());

    Lectures lecture = new Lectures ("Mindfulness Meditation", "Step away from mental chatter, and cultivate steadiness and peace of mind every week.", new DateOnly (2023, 4, 23), new TimeOnly (15, 0, 0), "University of Oxford, Oxford OX1 2JD, UK", "Noelle Lim", 50);
        
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine ("Lecture Event");
        Console.WriteLine(lecture.GetShortDescription());

    Outdoor outdoor = new Outdoor ("Car Fest", "25 Auto Repair shops across the greater San Antonio area to give out \n10 donated cars and repair 25 cars for charity.", new DateOnly (2023, 3, 31), new TimeOnly (18, 0, 0), "3201 E. Houston St. San Antonio, TX 78219", "Mostly Cloudy");

        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine ("Outdoor Event");
        Console.WriteLine(outdoor.GetShortDescription());
    }
}