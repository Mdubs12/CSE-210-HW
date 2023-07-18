using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        videos.Add(new Video("World Record for Longest Nap", "Jaschon", 323));
        videos[0].AddComment(new Comment("Kobi", "Great video!"));
        videos[0].AddComment(new Comment("Diego", "That's crazy."));
        videos[0].AddComment(new Comment("Jacob", "Wow!"));
        videos[0].AddComment(new Comment("Isaac", "Nice!"));

        videos.Add(new Video("How to Make Tacos", "Mr. Chef", 467));
        videos[1].AddComment(new Comment("Angelica", "Looks delicious!"));
        videos[1].AddComment(new Comment("Valerie", "I love this recipie!"));
        videos[1].AddComment(new Comment("Chayenne", "Yummy!"));
        videos[1].AddComment(new Comment("Brighton", "Best tacos ever."));

        videos.Add(new Video("Minecraft Let's Play Episode 3", "Roboman", 832));
        videos[2].AddComment(new Comment("Natalie", "I love your content!"));
        videos[2].AddComment(new Comment("Izzy", "First!"));
        videos[2].AddComment(new Comment("Becky", "You are awesome"));
        videos[2].AddComment(new Comment("McKenzie", "So cool."));
        
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