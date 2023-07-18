using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        videos.Add(new Video("Cool new kicks", "Mitchell", 55));
        videos[0].AddComment(new Comment("John", "Cool shoes!"));
        videos[0].AddComment(new Comment("Dave", "Jealous!"));
        videos[0].AddComment(new Comment("Jack", "These are my favorites..."));
        videos[0].AddComment(new Comment("William", "Fresh"));

        videos.Add(new Video("Fresh Enchiladas", "Rordan Gamsay", 300));
        videos[1].AddComment(new Comment("Cameron", "I'm making this RIGHT NOW!"));
        videos[1].AddComment(new Comment("Vaickie", "This was a great video, really good enchiladas"));
        videos[1].AddComment(new Comment("Megan", "Deliscious"));
        videos[1].AddComment(new Comment("Bob", "Rordan Gamsay never ceases to amaze"));

        videos.Add(new Video("Mario Odyssey Review in 10 minutes", "Jumpman 1995", 600));
        videos[2].AddComment(new Comment("ChadCrazy", "Thanks for the review, I'm getting this game"));
        videos[2].AddComment(new Comment("gamerkitten", "This looks so good!"));
        videos[2].AddComment(new Comment("Hatman12", "Can't wait for this game!"));
        videos[2].AddComment(new Comment("Mitchell", "Mario is my brother, Wahooo!"));
        
        foreach (Video video in videos)
        {
            Console.WriteLine($"{video.GetTitle()} by {video.GetAuthor()}.");
            Console.WriteLine($"Video length: {video.GetLength()} seconds.");
            Console.WriteLine($"Comments: {video.NumberOfComments()}");
            video.ListComments();
            Console.WriteLine();
        }


    }
}