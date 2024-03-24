using System;

namespace SayaTubeVideo
{
    public class SayaTubeVideo
    {
        // B. Struktur dari class tersebut dapat dilihat pada gambar di bawah ini :
        // SayaTubeVideo
        // - id : int
        // - title : string
        // - play Count : int

        // C. Konstruktor pada kelas tersebut menerima dua parameter yaitu judul video.
        // Pada saat objek dibuat, nilai “id” akan di-generate secara random sepanjang 5 digit
        // (bisa coba gunakan class Random bawaan bahasa pemrograman yang digunakan)
        // dan nilai “playCount” akan diisi dengan 0.
        public SayaTubeVideo(string title)
        {
            Random rand = new Random();
            id = rand.Next(10000, 100000); // generates a random 5-digit number
            this.title = title;
            playCount = 0;
        }

        // D. Pada class tersebut, tambahkan sebuah method dengan nama “IncreasePlayCount”
        // yang menerima jumlah angka yang akan ditambahkan ke “playCount”.
        public void IncreasePlayCount(int count)
        {
            playCount += count;
        }

        // E. Class tersebut juga mempunyai method “PrintVideoDetails” yang melakukan print
        // baik dari id, title dan playCount dengan format bebas.
        public void PrintVideoDetails()
        {
            Console.WriteLine($"Video Details: ID={id}, Title={title}, Play Count={playCount}");
        }

        // private variables
        private int id;
        private string title;
        private int playCount;
    }
}