public class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Minecraft Series Part 1", "PewDiePie", 120);
        video1.Comments.Add(new Comment("Lola", "Do not kill Sben"));
        video1.Comments.Add(new Comment("Josue", "You should go defeat the dragon!"));
        video1.Comments.Add(new Comment("Natalia", "No hablo Ingles..."));

        Video video2 = new Video("Cooking With Anna", "Anna Paola", 180);
        video2.Comments.Add(new Comment("Andrew", "Can you pls list all your ingredient brands?"));
        video2.Comments.Add(new Comment("Marlon", "That did not seem tasty..."));

        Video video3 = new Video( "You did not know you can do this with tooth paste!", "5 minutes craft", 230);
        video3.Comments.Add(new Comment("Dolores", "This is trash"));
        video3.Comments.Add(new Comment("Karina", "use me as a visible dislike button"));
        video3.Comments.Add(new Comment("Eduardo", "I'm pretty sure that took longer than 5 minutes.."));


        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}\nAuthor: {video.Author}\nLength (in seconds): {video.LengthInSeconds}\nNumber of comments: {video.GetNumberOfComments()}\nComments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"Comment by {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}