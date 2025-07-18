using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<string> videos = new List<string>();
	    Video video1 = new Video("Assassin's Creed Walkthrough part 1","AssassinsCreedBro","00:20:50");
	    Video video2 = new Video("Minecraft Playthrough part 1","MineCraftJunkie","00:32:20");
	    Video video3 = new Video("Reaction to BorderLands4 trailer","celljr76","00:25:15");
	    videos.Add(video1.GetVideo());
	    videos.Add(video2.GetVideo());
	    videos.Add(video3.GetVideo());
	    Comment comment1 = new Comment("gammer5000","I love the Assassin's creed series.");
	    Comment comment2 = new Comment("Smalls123","How did you get through the first level?");
	    Comment comment3 = new Comment("CombatEnthusiast","The Assassin's creed series combat doesn't have the best combat in it.");
	    Comment comment4 = new Comment("MinecraftEnthusiast","Why did you steal the structure for you base? You should have built your base yourself.");
	    Comment comment5 = new Comment("MinecraftHater","Minecraft is the worse sandbox game ever. You should try Roblox instead.");
        Comment comment6 = new Comment("MinecraftMods", "You should try Minecraft with mods. It is so much better this way, I promise.");
	    Comment comment7 = new Comment("LoverBoy12","I hope this Borderlands game will be better than the past 2 games they made.");
	    Comment comment8 = new Comment("Christangirl55","I heard Borderlands4 isn't going to be good.");
	    Comment comment9 = new Comment("Sheriffkid96","I can't wait either for this game to come out. It's going to be so good.");
	    video1.comments.Add(comment1.GetComment());
	    video1.comments.Add(comment2.GetComment());
	    video1.comments.Add(comment3.GetComment());
	    video2.comments.Add(comment4.GetComment());
	    video2.comments.Add(comment5.GetComment());
	    video2.comments.Add(comment6.GetComment());
	    video3.comments.Add(comment7.GetComment());
	    video3.comments.Add(comment8.GetComment());
	    video3.comments.Add(comment9.GetComment());
        Console.WriteLine(videos[0]);
        Console.WriteLine();
	    foreach (string i in video1.comments)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
        Console.WriteLine(videos[1]);
        Console.WriteLine();
	    foreach (string i in video2.comments)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
        Console.WriteLine(videos[2]);
        Console.WriteLine();
	    foreach (string i in video3.comments)
        {
            Console.WriteLine(i);
        }
    }
}