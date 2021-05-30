using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b,c;
            a = "Bilgisayar";
            b = "Programcılığı";
            b = String.Empty;
            c = String.Concat(a,b);
            /*c = String.Concat(a+" "+b); A ve B yi Birbirine ekleme */
            /* b = String.Copy(a); Kopyalayıp içine koyma */
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
