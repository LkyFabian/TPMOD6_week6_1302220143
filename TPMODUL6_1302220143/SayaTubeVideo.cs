using System;

namespace SayaTubeVideo
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public const int maxTitleLength = 100;
        public const int maxPlayCountIncreasePerCall = 10000000;

        public SayaTubeVideo(string title)
        {
            if (string.IsNullOrWhiteSpace(title) || title.Length > maxTitleLength)
                throw new ArgumentException("Title cannot be null, empty, or longer than " + maxTitleLength + " characters.");

            this.id = GenerateRandomId();
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count > maxPlayCountIncreasePerCall)
                throw new ArgumentOutOfRangeException("count", "Must not exceed " + maxPlayCountIncreasePerCall);

            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException ex)
            {
                throw new InvalidOperationException("IncreasePlayCount: Operation generated arithmetic overflow exception", ex);
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video Details: ID=" + id + ", Title=" + title + ", Play Count=" + playCount);
        }

        private int GenerateRandomId()
        {
            Random rand = new Random();
            return rand.Next(10000, 100000);
        }

        public int Id { get => id; }
        public string Title { get => title; }
        public int PlayCount { get => playCount; }
    }
}