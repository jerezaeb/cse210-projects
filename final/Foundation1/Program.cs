public class Program
{
    public static void Main(string[] args)
    {
        List <Video> videos = new List <Video>();

        Video video1 = new Video();
        video1._title = "Is This Asia’s Most Underrated Food? PHILIPPINES";
        video1._author= "Drew Binsky";
        video1._length = 698;
        video1.Comments = new List <Comment>();
        video1.Comments.Add (new Comment {_commenterName="ShadowTheHedgehog2000",  _comment = "Who else loves the Philippines? Raise your hand"});
        video1.Comments.Add (new Comment {_commenterName="BLACK Rose",  _comment = "Finally someone said it! Filipino foods are so UNDERRATED!"});
        video1.Comments.Add (new Comment {_commenterName="divina leoncio",  _comment = "Thank you for appreciating the food from our country. The food from Philippines are really amazing."});
        video1.Comments.Add (new Comment {_commenterName="Simon Verhoeve",  _comment = "It's always a delight to discover new cuisines."});
        videos.Add (video1);


        Video video2 = new Video();
        video2._title = "Easy Chicken Biryani at home";
        video2._author= "Kukmandu";
        video2._length = 678;
        video2.Comments = new List <Comment>();
        video2.Comments.Add (new Comment {_commenterName="George Seden",  _comment = "Looks great.  Great techniques and good ingredients. Rice is perfectly cooked."});
        video2.Comments.Add (new Comment {_commenterName="Shatakshi Srivastava",  _comment = "I tried the recipe and it’s super awesome"});
        video2.Comments.Add (new Comment {_commenterName="Jen",  _comment = "Looks delicious!"});
        videos.Add (video2);

        Video video3 = new Video();
        video3._title = "CHICKEN TERIYAKI";
        video3._author= "Chef RV";
        video3._length = 1103;
        video3.Comments = new List <Comment>();
        video3.Comments.Add (new Comment {_commenterName="Batang Henyo",  _comment = "You are very pleasant to watch. Keep cooking and teaching, Chef!"});
        video3.Comments.Add (new Comment {_commenterName="Helen Alcantara",  _comment = "Thanks chef RV.. Love your all your shared recipes. I will cook it soon"});
        video3.Comments.Add (new Comment {_commenterName="Rachell Opes",  _comment = "I love how you explain and give option of what you cook. More cooking vlogs. God bless"});
        videos.Add (video3);

        foreach (Video video in videos)
        {
            Console.WriteLine();
            Console.WriteLine ("Title: {0}",video._title);
            Console.WriteLine ("Author: {0}", video._author);
            Console.WriteLine ("Length: {0} seconds", video._length);
            Console.WriteLine ("Number of Comments: {0}", video.GetNumberOfComments());
            foreach (Comment _comment in video.Comments)
            {
                Console.WriteLine ("Comment from {0}:{1}", _comment._commenterName, _comment._comment);
            }
            Console.WriteLine();
        }

    }
}