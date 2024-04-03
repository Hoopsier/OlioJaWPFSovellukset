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
    internal class Koira : Elain
    {
        //muuttujat (sama kuin kissa)
        public string rotu;
        public string nimi;

        //konstruktori
        public Koira(string _rotu, string _nimi)
        {
            rotu = _rotu;
            nimi = _nimi;
            MaaraUp();
        }
        //ei muokattu override
        public override void Hauku()
        {
            Console.WriteLine(nimi + " shouts: Bark!");
        }
    }
}
