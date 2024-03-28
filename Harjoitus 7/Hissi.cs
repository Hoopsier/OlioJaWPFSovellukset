using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_7
{
    internal class Hissi
    {
        public static int kerros {get; set;}
        public static bool done = false;
        public static void KerrosSiirto()
        {
            Console.WriteLine("Valitse kerros (1-6)");
            

            while (Hissi.done == false)
            {
                kerros = int.Parse(Console.ReadLine());
                if (kerros < 1 || kerros > 6)
                {
                    Console.WriteLine("Ei sopiva kerros, valitse näistä (1-6)");
                    break;
                }
                else
                {
                    Console.WriteLine("Hissi on " + kerros + ". kerroksessa.");
                    
                }
            }
        }
    }
}
