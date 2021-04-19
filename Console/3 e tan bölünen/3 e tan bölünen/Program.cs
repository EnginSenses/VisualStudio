using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_e_tan_bölünen
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, toplam = 0, adet = 0,i=1;
            Console.Write("Sayıyı Giriniz :");
            sayi = Convert.ToInt32(Console.ReadLine());
            while(i<=sayi)
            {
                if(i%3==0)
                {
                    toplam += i;
                    adet++;
                    Console.Write("  "+i);
                }
                i++;
            }
            Console.Write("\n3 E tam Bölünenlerin Toplamı :"+toplam);
            Console.Write("\n3 E tam bölünenlerin Adedi :"+ adet);
            Console.ReadKey();
        }
    }
}
