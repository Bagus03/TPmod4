using System;

namespace TPmod4
{
    class Program
    {
        static void Main()
        {
            KodePos kodePos = new KodePos();

            // Meminta input dari user
            Console.Write("Masukkan nama kelurahan: ");
            string kelurahan = Console.ReadLine();

            // Mendapatkan kode pos dari kelurahan
            int? kodePosResult = kodePos.GetKodePos(kelurahan);

            // Menampilkan hasilnya
            if (kodePosResult != null)
            {
                Console.WriteLine($"Kode pos untuk {kelurahan} adalah: {kodePosResult}");
            }
            else
            {
                Console.WriteLine("Kelurahan tidak ditemukan.");
            }
        }
    }
}
