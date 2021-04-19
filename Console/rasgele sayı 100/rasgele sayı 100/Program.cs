using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rasgele_sayı_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int tekadet=0,sayi,topadet=0;
            Random rasgele = new Random();
            while(true)
            {
                sayi = rasgele.Next(1,150);
                topadet++;
                if (sayi == 100) break;
                if (sayi % 2 == 0)continue;
                Console.WriteLine("Tek "+sayi);
                tekadet++;
            }
            Console.WriteLine("Üretilen Sayıların Adedi :"+topadet);
            Console.WriteLine("Tek Sayıların Adedi :"+tekadet);
            Console.ReadKey();
        }
    }
}
