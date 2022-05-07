using System;

namespace structkavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen1 = new Dikdortgen();
            dikdortgen1.KisaKenar = 3;
            dikdortgen1.UzunKenar = 4;
            Console.WriteLine("Class Dikdörtgenin Alanı: {0}", dikdortgen1.AlanHesapla());

            Dikdortgen_Struct dikdortgen_struct = new Dikdortgen_Struct();

            dikdortgen_struct.KisaKenar = 3;
            dikdortgen_struct.UzunKenar = 4;

            Console.WriteLine("Struct Dikdörtgenin Alanı: {0}", dikdortgen1.AlanHesapla());

        }
    }

    class Dikdortgen
    {
        public int KisaKenar;

        public int UzunKenar;

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }

    struct Dikdortgen_Struct
    {
        public int KisaKenar;

        public int UzunKenar;

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
}

