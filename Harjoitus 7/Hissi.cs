/*
 * Renan Horuz EI VIDEOITA KÄYTETTYNÄ TEHTÄVIIN (en jaksa tehä kotitehtäviä JA harjoituksia täysin yksin)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_7
{
    internal class Hissi
    {
        //muuttujat
        public static int kerros {get; set;}
        public static bool done = false;
        //hissin toimivuus
        public static void KerrosSiirto()
        {
            Console.WriteLine("Valitse kerros (1-6)");
            
            //looppi että hissi saa oikean inputin
            while (Hissi.done == false)
            {
                kerros = int.Parse(Console.ReadLine());
                if (kerros < 1 || kerros > 6)
                {
                    //väärä kerros
                    Console.WriteLine("Ei sopiva kerros, valitse näistä (1-6)");
                    break;
                }
                else
                {
                    //oikea
                    Console.WriteLine("Hissi on " + kerros + ". kerroksessa.");
                    
                }
            }
        }
    }
}
