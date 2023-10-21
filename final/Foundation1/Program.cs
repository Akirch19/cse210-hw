using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");
        List<Video> videosList = new List<Video>();

        Video video1 = new Video();
        video1._title = "We Bought EVERYTHING in this Mom & Pop Computer Store";
        video1._length = "2063";
        video1._author = "Linus Tech Tips";
        Comment video1Comment1 = new Comment();
        video1Comment1._name = "ZstormVR";
        video1Comment1._commentText = "Please run to more Mom and Pop shops like this and help them out by buying EVERYTHING they have! This is such an entertaining fun blast from the past!";
        Comment video1Comment2 = new Comment();
        video1Comment2._name = "Slevin";
        video1Comment2._commentText = "As someone who owns a small shop like this: maaaaaaan I know how much you made this dude's whole life. Thank you for being you, LTT!";
        Comment video1Comment3 = new Comment();
        video1Comment3._name = "Goomakers";
        video1Comment3._commentText = "Do it again, so much fun to watch and helping a vanishing repair shop makes me want to buy your store products Linus. So I will.";
        Comment video1Comment4 = new Comment();
        video1Comment4._name ="Mohammad";
        video1Comment4._commentText ="This was a great episode. Fun, wholesome. Not to mention I love these places. I hope they don't all disappear. This guy works really well with you all. He could be a regular for all the old tech haha.";

        Video video2 = new Video();
        video2._title = "Exploring Strange Dead Games";
        video2._length = "1143";
        video2._author = "Rye Games";
        Comment video2Comment1 = new Comment();
        video2Comment1._name = "Madman";
        video2Comment1._commentText = "I love Intruder, I used to play it constantly and just had way to much fun on it. The community at the time was some of the funniest individuals I had ever been around.";
        Comment video2Comment2 = new Comment();
        video2Comment2._name = "Cherry";
        video2Comment2._commentText = "Intruder is actually insanely fun with friends";
        Comment video2Comment3 = new Comment();
        video2Comment3._name = "Tanker";
        video2Comment3._commentText = "I got unreasonably excited when Airport Simulator 2014 popped up. Watching NerdCubed play that almost a decade ago was brilliant.";
        Comment video2Comment4 = new Comment();
        video2Comment4._name ="Rylie";
        video2Comment4._commentText ="I really wish intruder had a bigger playerbase because its so silly and fun";

        Video video3 = new Video();
        video3._title = "Times Referees RUINED The NFL";
        video3._length = "978";
        video3._author = "FieldFlix";
        Comment video3Comment1 = new Comment();
        video3Comment1._name = "Steves";
        video3Comment1._commentText = "Dont forget the lions and cowboys playoff game from the 2010s bs call reversing the call";
        Comment video3Comment2 = new Comment();
        video3Comment2._name = "Ghost";
        video3Comment2._commentText = "I remember when the ref became the quarterback in the middle of a game";
        Comment video3Comment3 = new Comment();
        video3Comment3._name = "gama";
        video3Comment3._commentText = "Bettis called heads and tails in the Lions Game.";
        Comment video3Comment4 = new Comment();
        video3Comment4._name = "Sullivan";
        video3Comment4._commentText = "Jalen fumbling costed the eagles that game thats it";

        video1._commentList.Add(video1Comment1);
        video1._commentList.Add(video1Comment2);
        video1._commentList.Add(video1Comment3);
        video1._commentList.Add(video1Comment4);


        video2._commentList.Add(video2Comment1);
        video2._commentList.Add(video2Comment2);
        video2._commentList.Add(video2Comment3);
        video2._commentList.Add(video2Comment4);


        video3._commentList.Add(video3Comment1);
        video3._commentList.Add(video3Comment2);
        video3._commentList.Add(video3Comment3);
        video3._commentList.Add(video3Comment4);

        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }

    }
}