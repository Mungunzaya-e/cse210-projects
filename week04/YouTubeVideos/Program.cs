using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.\n");

        List<Video> videoList = new List<Video>();

        Video video1 = new Video("Anti-Hero (Official Music Video)", "Taylor Swift", 310);

        video1.AddCommentToList(new Comment("polyester8844", "It's so crystal clear how this song's so personal"));
        video1.AddCommentToList(new Comment("emmam9389", "The fact people made her feel bad enough to delete the scale scene is ridiculous."));
        video1.AddCommentToList(new Comment("megwelborn", "Please don’t change this video just because some people do not understand."));

        videoList.Add(video1);


        Video video2 = new Video("Moms Try Each Other's Cheesecakes", "Cocoa Butter", (8*60+14));

        video2.AddCommentToList(new Comment("lavendersunsets7066", "Daena seems like a very sophisticated lady. She has a very professional aura about her."));
        video2.AddCommentToList(new Comment("acatnamedjimmy8060", "'That’s LIQUOR! THATS LIQUOR!' made me die. I love her."));
        video2.AddCommentToList(new Comment("raijordan3736", "Been patiently waiting FOREVER for a new 'try each other's dish' video...thank you!!!!"));
        video2.AddCommentToList(new Comment("TaytheScorpio", "The lady who scored the other lady’s a 9.5 is so real"));
        video2.AddCommentToList(new Comment("Pinkdjinandtonic", "I wanna see this but their kids judge blindfolded"));

        videoList.Add(video2);


        Video video3 = new Video("'Squid Game' Cast Take a Friendship Test", "Glamour", (12*60+30));

        video3.AddCommentToList(new Comment("Omega124", "These interviews fr be healing us after traumatizing us in s3"));
        video3.AddCommentToList(new Comment("Robloxgamingpapa", "Jo yuri calling Yim Siwan pretty made my day"));
        video3.AddCommentToList(new Comment("celinlin999", "I just love the way Lee Jungjae sincerely poured his thoughts into those compliments"));
        video3.AddCommentToList(new Comment("Uraniika", "All this happy content is healing us after the traumatic experience of season 3"));

        videoList.Add(video3);
       
        

        int i = 0;
        foreach (Video video in videoList)
        {
            Console.WriteLine($"{i + 1}. {video._title}");
            Console.WriteLine($"\tAuthor: {video._author}\n\tLength: {video._length}s");
            Console.WriteLine($"\tNumber of comments: {video._comments.Count}");
            Console.WriteLine("\tComments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"\t- @{comment._commentorName}: {comment._commentText}");
            }

            Console.WriteLine();
            Console.WriteLine(new string('-', 75));
            Console.WriteLine();
            i++;
        }


    }
}