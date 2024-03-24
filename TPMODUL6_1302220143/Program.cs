using System;

namespace SayaTubeVideo
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Jeremy Mathew Fabian Sitepu");

            Console.WriteLine("Initial video details:");
            video.PrintVideoDetails();

            Console.WriteLine("\nIncreasing play count...");

            for (int i = 0; i < 100; i++)
            {
                video.IncreasePlayCount(10000001);
            }

            Console.WriteLine("\nVideo details after increasing play count:");
            video.PrintVideoDetails();

            Console.ReadLine();
        }
    }
}