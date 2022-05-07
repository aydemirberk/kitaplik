﻿using System;

namespace enumdersi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            Console.WriteLine("Hava kaç santigrat derece?");
            int sıcaklık = int.Parse(Console.ReadLine());

            if (sıcaklık < (int)HavaDurumu.Normal && sıcaklık > (int)HavaDurumu.Soguk)
                Console.WriteLine("Hava {0} Derece. Dışarı çıkmak için biraz serin.", sıcaklık);
            else if (sıcaklık >= (int)HavaDurumu.Normal && sıcaklık <= (int)HavaDurumu.Sıcak)
                Console.WriteLine("Hava {0} Derece. Dışarı çıkmak için mükemmel.", sıcaklık);
            else if (sıcaklık >= (int)HavaDurumu.Sıcak && sıcaklık <= (int)HavaDurumu.CokSıcak)
                Console.WriteLine("Hava {0} Derece. Dışarı çıkmak için biraz sıcak.", sıcaklık);
            else
                Console.WriteLine("Hava {0} Derece. Bu havada dışarı çıkılmaz!", sıcaklık);
        }
    }

    enum Gunler
    {
        Pazartesi=1,

        Salı,

        Çarşamba,

        Perşembe,

        Cuma=23,

        Cumartesi,

        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sıcak = 30,
        CokSıcak = 35
    }
     
}

