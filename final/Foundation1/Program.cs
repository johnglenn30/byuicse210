using System;
using System.Collections.Generic;

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}

class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // create videos
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Basics Tutorial", "Bob", 600);
        video1.Comments.Add(new Comment("Alice", "Thanks for the video! It was very helpful."));
        video1.Comments.Add(new Comment("Charlie", "I didn't understand the part about classes. Can you explain it more?"));
        video1.Comments.Add(new Comment("Dave", "Great tutorial! Looking forward to more videos."));

        Video video2 = new Video("JavaScript Advanced Tutorial", "Alice", 1200);
        video2.Comments.Add(new Comment("Bob", "This is awesome! Thanks for making it."));
        video2.Comments.Add(new Comment("Charlie", "I learned so much from this video. Can't wait for the next one."));
        video2.Comments.Add(new Comment("Eve", "The part about closures was a bit confusing. Can you explain it more?"));

        Video video3 = new Video("Python for Data Science Tutorial", "Charlie", 1800);
        video3.Comments.Add(new Comment("Dave", "Excellent tutorial. Thanks for sharing."));
        video3.Comments.Add(new Comment("Eve", "I'm new to Python but this was very easy to follow."));
        video3.Comments.Add(new Comment("Alice", "This is exactly what I was looking for. Can you make more videos like this?"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // iterate through the list of videos and display their details
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length (seconds): " + video.LengthInSeconds);
            Console.WriteLine("Number of comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("- " + comment.Name + ": " + comment.Text);
            }
            Console.WriteLine();
        }
    }
}

//from ChatGPT