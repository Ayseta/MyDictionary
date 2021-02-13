using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Bir Sayı Tut Çıkan Şarkı Sana Gelsin :) ");
            
            Dictionary<int, string> sarki = new Dictionary<int, string>();

            sarki.Add(1, "Daha İyi-Hande Ünsal");
            sarki.Add(2, "Yas-Tuğba Yurt");
            sarki.Add(3, "Gidiyorum-Sezen Aksu");
            sarki.Add(4, "Her Mevsim Yazım-Zeynep Bastık");
            sarki.Add(5, "Aşkın Olayım-Simge");
            sarki.Add(6, "Hasret Nagmesi-Nigar Muharrem");
            sarki.Add(7, "Sığınak-Tuğba Yurt");
            sarki.Add(8, "Hepsi Geçiyor-Oğuzhan Koç");
            sarki.Add(9, "Yok Yok- Feride Hilal Akın");
            sarki.Add(0, "Hançer-İlyas Yalçıntaş");

          tekrar:
            Console.WriteLine("\r Bir sayı gir:");
            int no = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(sarki[no]);
            }
            catch 
            {

                Console.WriteLine("\a 0'dan 9'a bir rakam seçerek Tekrar Dene veya Tüm Listeyi Gör");
               
            }
            
            Console.WriteLine("\n\n\nTüm Listeyi görmek için herhangi bir tuşa basınız");
            char tus = char.Parse(Console.ReadLine());

            Dictionary<int, string>.ValueCollection sarkiListesi = sarki.Values;
            foreach (string deger in sarkiListesi)
            {
                Console.WriteLine(deger);
            }
            Console.ReadKey();
            goto tekrar;

            
            
        }
    }
}
