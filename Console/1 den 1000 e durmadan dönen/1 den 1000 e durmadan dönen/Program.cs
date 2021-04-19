using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_den_1000_e_durmadan_dönen
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1;i<=10000;i++)
            {
                Console.WriteLine(i);
                if(Console.KeyAvailable==false)
                {
                   
                }
                else
                {
                    break;
                }
                if(i==10000)
                {
                    i = 0;
                }
            }
            Console.ReadKey();
        }
    }
}
