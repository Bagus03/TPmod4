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


using System;

namespace TPmod4
{
    class Program
    {
        static void Main()
        {
            DoorMachine door = new DoorMachine(); // Pintu dalam keadaan terkunci

            Console.WriteLine("\nSimulasi perubahan state pintu:");
            door.BukaPintu(); // Membuka pintu
            door.KunciPintu(); // Mengunci pintu kembali
            door.BukaPintu(); // Membuka pintu lagi
            door.BukaPintu(); // Mencoba membuka pintu yang sudah terbuka
            door.KunciPintu(); // Mengunci pintu lagi
            door.KunciPintu(); // Mencoba mengunci pintu yang sudah terkunci
        }
    }
}
