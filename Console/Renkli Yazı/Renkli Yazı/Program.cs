using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renkli_Yazı
{
    class Program
    {
        static void Main(string[] args)
        {
            string karakter;
            Console.Write("Kelimeyi Giriniz :");
            karakter = Console.ReadLine();
            Console.Clear();
            for(int i=1;i<=2;i++)
            {
                if(i==2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                for(int j=0;j<=karakter.Length-1;j++)
                {
                    Console.Write(karakter[j]);
                    System.Threading.Thread.Sleep(200);
                }
                Console.Clear();
                if(i==2)i = 0;
            }
        }
    }
}
