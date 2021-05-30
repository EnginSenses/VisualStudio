using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Arraylist_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList diller = new ArrayList();
            diller.Add("VB.Net");
            diller.Add("C#");
            diller.Add("ASP.Net");
            ArrayList digerdiller = new ArrayList();
            digerdiller.Add("Pyhton");
            digerdiller.Add("F#");
            digerdiller.Add("C++");
            /*diller.RemoveRange(0,2); Girilen indeksten kaç adet silineceğini söyler */
            /*diller.InsertRange(1,digerdiller); Belirtilen indeks numarasından sonra eklemek için  */
            /*diller.AddRange(digerdiller); Listenin sonunda ekleme */
            /*digerdiller = diller.GetRange(0,2);   Listeden listeye ekleme */
            foreach (string eleman in diller)
            {
                Console.WriteLine(eleman);
            }
            Console.ReadKey();
        }
    }
}
