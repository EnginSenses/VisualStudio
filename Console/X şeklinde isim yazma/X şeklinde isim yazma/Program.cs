using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_şeklinde_isim_yazma
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime;
            int i;
            Console.Write("Kelimeyi Giriniz :");
            kelime = Console.ReadLine();
            Console.Clear();
            for(i =1;i<=20;i++)
            {
                Console.SetCursorPosition(i+25,i);
                Console.Write(kelime);
                Console.SetCursorPosition(45-i , i);
                Console.Write(kelime);
            }
            Console.ReadKey();
        }
    }
}
