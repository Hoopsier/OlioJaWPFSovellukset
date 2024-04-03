/*
 * Renan Horuz EI VIDEOITA KÄYTETTYNÄ TEHTÄVIIN (en jaksa tehä kotitehtäviä JA harjoituksia täysin yksin)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_6
{
    internal class Elain
    {
        static int amount;
        public virtual void Hauku() // overridattava metodi
        {
            Console.WriteLine("Bark!");
        }
        public void MaaraUp() //nostaa amounttia aina kun kutsutaan
        {
            amount++;
        }
        public static void Maara() //näyttää eläinten määrän
        {
            Console.WriteLine("Eläimiä: " + amount);
        }
    }
}
