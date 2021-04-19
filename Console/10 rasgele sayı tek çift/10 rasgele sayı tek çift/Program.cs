using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_rasgele_sayı_tek_çift
{
    class Program
    {
        static void Main(string[] args)
        {
            int tek=0, cift=0,sayi,i=1;
            Random rasgele = new Random();
            while(i<=10)
            {
                sayi = rasgele.Next(1,100);
                Console.WriteLine(sayi);
                if(sayi % 2==0)
                {
                    cift++;
                }
                else
                {
                    tek++;
                }
                i++;
            }
            Console.WriteLine($"Çift Sayıların Adedi :{cift}");
            Console.WriteLine($"Tek Sayıların Adedi  :{tek}");
            Console.ReadKey();
        }
    }
}
