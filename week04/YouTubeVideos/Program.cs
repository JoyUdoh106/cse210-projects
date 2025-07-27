class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Video video1 = new Video("How to Bake a Perfect Cake", "BakingWithBrenda", 480);
        video1.AddComment("Alice", "This recipe was amazing! My cake turned out perfectly.");
        video1.AddComment("Bob", "Great video, but my cake was a bit dry. Any tips?");
        video1.AddComment("Charlie", "I love your channel! Thanks for the clear instructions.");

        videoList.Add(video1);

        Video video2 = new Video("Introduction to C# Programming", "CodeMaster", 1200);
        video2.AddComment("David", "Finally, a tutorial that makes sense!");
        video2.AddComment("Eve", "Could you do a video on classes and objects next?");
        video2.AddComment("Frank", "Thank you! This helped me pass my exam.");
        video2.AddComment("Grace", "The audio is a little quiet, but the content is gold.");

        videoList.Add(video2);

        Video video3 = new Video("10 Minute Home Workout", "FitLife", 600);
        video3.AddComment("Heidi", "Short, sweet, and effective. I'm sweating!");
        video3.AddComment("Ivan", "Great workout for a busy schedule.");
        video3.AddComment("Judy", "Can't wait for more videos like this!");
        
        videoList.Add(video3);

        Console.WriteLine("--- YouTube Video and Comment Tracker ---");
        Console.WriteLine();

        foreach (Video video in videoList)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            
            Console.WriteLine("Comments:");
            if (video.GetNumberOfComments() > 0)
            {
                foreach (Comment comment in video._comments)
                {
                    Console.WriteLine($"- {comment._commenterName}: \"{comment._commentText}\"");
                }
            }
            else
            {
                Console.WriteLine("- No comments yet.");
            }

            Console.WriteLine();
        }
    }
}