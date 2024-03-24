using System;

namespace SayaTubeVideo
{
    class Program
    {
        static void Main(string[] args)
        {
            // F. Panggil method tersebut pada fungsi/method utama dengan membuat sebuah video dengan judul “Tutorial Design By Contract – Jeremy Mathew Fabian Sitepu”
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Jeremy Mathew Fabian Sitepu");
            video.PrintVideoDetails();
            video.IncreasePlayCount(10);
            video.PrintVideoDetails();

            Console.ReadLine();
        }
    }
}