using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Arraylist_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList rakamlar = new ArrayList();
            rakamlar.Add(8);
            rakamlar.Add(7);
            rakamlar.Add(1);
            rakamlar.Add(4);
            rakamlar.Add(5);
            rakamlar.Add(2);
            rakamlar.Sort();/* Küçükten büyüğe sıralama */
            rakamlar.Reverse();/* Diziyi tersine çevirme */
            for(int i=0;i<=rakamlar.Count-1;i++)
            {
                Console.WriteLine(rakamlar[i]);
            }
            Console.ReadKey();
        }
    }
}
