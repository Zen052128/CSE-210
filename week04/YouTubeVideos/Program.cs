using System;

class Program
{
    static void Main(string[] args)
    {
    Video video1 = new Video();
    video1._title = "The Only Phone Review You Need (2026)";
    video1._author = "TechSpecs";
    video1._length = 845; 

    Comment c1_1 = new Comment(); c1_1._name = "Dave_Codes"; c1_1._text = "I literally bought this phone yesterday, the battery life is insane.";
    Comment c1_2 = new Comment(); c1_2._name = "SaraReadz"; c1_2._text = "Great review! You convinced me to upgrade from my ancient model.";
    Comment c1_3 = new Comment(); c1_3._name = "PixelPerfect"; c1_3._text = "Is the camera bump annoying when it sits flat on a desk?";
    Comment c1_4 = new Comment(); c1_4._name = "GamerGuy99"; c1_4._text = "Unboxing part was so satisfying, thanks for the honest review.";

    video1._comments.Add(c1_1);
    video1._comments.Add(c1_2);
    video1._comments.Add(c1_3);
    video1._comments.Add(c1_4);

    Video video2 = new Video();
    video2._title = "Gordon's Ultimate 15-Minute Pasta";
    video2._author = "Chef Gordon";
    video2._length = 920; 

    Comment c2_1 = new Comment(); c2_1._name = "BakerMom"; c2_1._text = "Made this for dinner tonight. Absolutely beautiful and so fast!";
    Comment c2_2 = new Comment(); c2_2._name = "BurntToast"; c2_2._text = "Somehow I still managed to burn the garlic. Send help.";
    Comment c2_3 = new Comment(); c2_3._name = "Foodie_Life"; c2_3._text = "Can I substitute the heavy cream with coconut milk?";

    video2._comments.Add(c2_1);
    video2._comments.Add(c2_2);
    video2._comments.Add(c2_3);

    Video video3 = new Video();
    video3._title = "Lo-Fi Beats to Study/Relax To 🎧";
    video3._author = "ChillVibes Station";
    video3._length = 3600; 

    Comment c3_1 = new Comment(); c3_1._name = "ExamSurvivor"; c3_1._text = "This track list is the only reason I am passing my finals.";
    Comment c3_2 = new Comment(); c3_2._name = "NightOwl"; c3_2._text = "Who else is listening to this at 3:00 AM right now?";
    Comment c3_3 = new Comment(); c3_3._name = "ArtisticSoul"; c3_3._text = "The background animation matches the music perfectly.";

    video3._comments.Add(c3_1);
    video3._comments.Add(c3_2);
    video3._comments.Add(c3_3);

    Video video4 = new Video();
    video4._title = "Solo Backpacking Through Japan (Budget Guide)";
    video4._author = "Wanderlust Chronicles";
    video4._length = 1450; 

    Comment c4_1 = new Comment(); c4_1._name = "TokyoDrifter"; c4_1._text = "That hidden ramen shop in Kyoto looked incredible! Adding to my list.";
    Comment c4_2 = new Comment(); c4_2._name = "PackLight"; c4_2._text = "How much did you spend on train tickets overall?";
    Comment c4_3 = new Comment(); c4_3._name = "Elena_V"; c4_3._text = "Your cinematography is unmatched. Such a beautiful video.";
    Comment c4_4 = new Comment(); c4_4._name = "LostAndFound"; c4_4._text = "This makes me want to quit my job and buy a plane ticket today.";

    video4._comments.Add(c4_1);
    video4._comments.Add(c4_2);
    video4._comments.Add(c4_3);
    video4._comments.Add(c4_4);
    
    List<Video> masterlist = new List<Video>();
    masterlist.Add(video1);
    masterlist.Add(video2);
    masterlist.Add(video3);
    masterlist.Add(video4);

    foreach (Video video in masterlist)
        {
            video.Display();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}