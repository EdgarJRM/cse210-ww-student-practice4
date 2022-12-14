using System;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YouTube Video Tracker");

            Video video1 = new Video();
            video1._tittle = "Guns N' Roses - November Rain (2022 Version)";
            video1._author = "Guns N' Roses";
            video1._timeSeconds = 512;
            video1._listComment = new Comment();
            video1._listComment._author1 = "deanpiazza1099";
            video1._listComment._comment1 = "Awesome song that will go on forever!!!";
            video1._listComment._author2 = "rogerroberto1948";
            video1._listComment._comment2 = "Acredito que essa musica jamais será esquecida, é um clássico.";
            video1._listComment._author3 = "dianaandreacardonapena3195";
            video1._listComment._comment3 = "My favorite song of all times!!";
            video1.getInfoVideo();

            Video video2 = new Video();
            video2._tittle = "Legends Never Die (ft. Against The Current) | Worlds 2017 ";
            video2._author = "League of Legends";
            video2._timeSeconds = 178;
            video2._listComment = new Comment();
            video2._listComment._author1 = "TheRealGuywithoutaMustache";
            video2._listComment._comment1 = "Even people who haven't played League can appreciate how good the music is.";
            video2._listComment._author2 = "audriehope5013";
            video2._listComment._comment2 = "Let's hope future generations don't let this song die out.";
            video2._listComment._author3 = "orfunde779";
            video2._listComment._comment3 = "I feel the nostalgia so hard";
            video2.getInfoVideo();

            Video video3 = new Video();
            video3._tittle = "Learn Unity in 17 MINUTES!";
            video3._author = "Code Monkey";
            video3._timeSeconds = 1047;
            video3._listComment = new Comment();
            video3._listComment._author1 = "larrygaming25";
            video3._listComment._comment1 = "Watched in 2x speed, learned unity in less than 10 minutes.";
            video3._listComment._author2 = "tostpl8258";
            video3._listComment._comment2 = "Programming is half remembering something,half googling it, and half watching code monkey because he's examples are the most practical and I really appreciate his content :)";
            video3._listComment._author3 = "yuehaowu";
            video3._listComment._comment3 = "Finally. A tutorial that isn’t 2 hours and only contains 1 minute of useful info";
            video3.getInfoVideo();
        }
    }
}
