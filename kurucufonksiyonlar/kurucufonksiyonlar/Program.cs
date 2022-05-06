using System;

namespace kurucufonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Berk", "Aydemir", 64842, "Avukat");

            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan("Kamil", "Yılmaz", 12354, "Genel Müdür");

            calisan2.CalisanBilgileri();

        }
    }

    class Calisan
    {

        public string Ad;

        public string Soyad;

        public int No;

        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            No = no;
            Departman = departman;

        }


        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalınaşın Adı: {0}", Ad);
            Console.WriteLine("Çalınaşın Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}", No);
            Console.WriteLine("Çalınaşın Departmanı: {0}", Departman);

        }
    }
}

