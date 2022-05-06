using System;

namespace patikasinifnedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ahmet";
            calisan1.Soyad = "Ham";
            calisan1.No = 123141;
            calisan1.Departman = "Ön büro";

            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Mehmet";
            calisan2.Soyad = "Süreyya";
            calisan2.No = 156565;
            calisan2.Departman = "Evrak Kayıt";

            calisan2.CalisanBilgileri();



        }
    }

    class Calisan
    {
        public string Ad;

        public string Soyad;

        public int No;

        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calışanın Adı:{0}", Ad);
            Console.WriteLine("Calışanın Soyadı:{0}", Soyad);
            Console.WriteLine("Calışanın Numarası:{0}", No );
            Console.WriteLine("Calışanın Departmanı:{0}", Departman);
        }
    }
}

