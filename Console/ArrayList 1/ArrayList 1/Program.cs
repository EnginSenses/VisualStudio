using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList isimler = new ArrayList();
            isimler.Add("Engin");
            isimler.Add("Ahmet");
            isimler.Add("Mehmet");
            isimler.Add(123);
            /*isimler.RemoveAt(1);    Silmek istediğin indeksi */
            /*isimler.Remove("Engin");   Silmek (Parantez içindeki neyse)*/
            /*isimler.Insert(0,"Ayşe");  Ekleme(Konum , İçerik)*/
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.ReadKey();
        }
    }
}
