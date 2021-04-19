using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_girdiği_sürece_toplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam=0, sayi,i=1;
            char harf;
            while(true)
            {
                Console.Write($"{i}. Sayiyi Giriniz :");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
                Console.WriteLine("Sayıları toplamaya devam etmek için E veye e ye basın !");
                harf = Convert.ToChar(Console.ReadLine());
                if (harf != 'e' && harf != 'E') break;
                i++;
            }
            Console.WriteLine($"Sayıların toplamı :{toplam}");
            Console.ReadKey();
        }
    }
}
