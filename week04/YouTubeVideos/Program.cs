using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       // Create a list to hold the videos
        List<Video> videos = new List<Video>();

        // Create first video
        Video video1 = new Video("Ninja Detect Kitchen System Unboxing: Power Blender and Processor Pro!", "JoesPhenomenal", 806);
        video1.AddComment(new Comment("0mrclrn", "Standard cabinet height is 18, The blender makes 17 inch 3/4"));
        video1.AddComment(new Comment("sean321a", "Looks interesting. Will be looking forward to your review."));
        video1.AddComment(new Comment("timophay", "Why Ninja don't have 10 speed motor in this model. Its can be so useful."));
        videos.Add(video1);

        // Create second video
        Video video2 = new Video("Bose QC Ultra Headphones Review: New ANC King?", "CNET", 562);
        video2.AddComment(new Comment("dlcvta", "i just got a pair today. i like them. very light weight. good sound quality. solid build"));
        video2.AddComment(new Comment("ChichingClips", "Got mine last week.  Absolutely love them."));
        video2.AddComment(new Comment("mikalkielli3351", "I’m going to get a pair of these early next year"));
        videos.Add(video2);

        // Create third video
        Video video3 = new Video("The Most AMAZING Vanilla Cake Recipe", "Preppy Kitchen", 394);
        video3.AddComment(new Comment("m.mehdbhatti2338", "The kid at the end was sooo cute i wanna give him a hug"));
        video3.AddComment(new Comment("TatyanasEverydayFood", "Always eyeing that AMAZING stove! And all the copper! :)"));
        video3.AddComment(new Comment("MilkyWhite1", "I wasn't prepared for all the cuteness at the end. He is adorable."));
        videos.Add(video3);

        // Display info for each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($" * {comment._commenterName}: {comment._text}");
            }
            Console.WriteLine(); // Add a blank line between videos
        }
    }
}