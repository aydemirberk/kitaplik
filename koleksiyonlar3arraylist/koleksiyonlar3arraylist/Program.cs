using System;
using System.Collections;
using System.Collections.Generic;

namespace koleksiyonlar3arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            ///liste.Add("Berk");
            ///liste.Add('A');
            ///liste.Add(13);
            ///liste.Add(true);

            //içerisinde verilere erişim
            ///Console.WriteLine(liste[0]);

            ///foreach (var veri in liste)
            ///    Console.WriteLine(veri);

            Console.WriteLine("******Add Range******");
            //string[] renkler = { "kırmızı", "sarı", "yeşil" };
            List<int> sayilar = new List<int>() { 1,21,7,42,17,22,45,3};
            //liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var veri in liste)
                Console.WriteLine(veri);

            //Sort
            Console.WriteLine("******Sort*******");
            liste.Sort();
            foreach (var veri in liste)
                Console.WriteLine(veri);

            //Binary Search
            Console.WriteLine("******Binary Search*******");
            Console.WriteLine(liste.BinarySearch(4));

            //Reverse
            Console.WriteLine("******Reverse*******");
            liste.Reverse();

            foreach (var sayi in liste)
            Console.WriteLine(sayi);

            //Clear
            Console.WriteLine("******Clear*******");
            liste.Clear();
            foreach (var sayi in liste)
                Console.WriteLine(sayi);
        }
    }
}

