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
    
    internal class Kissa : Elain
    {
        //muuttujat
        public string rotu;
        public string nimi;

        //konstruktori
        public Kissa(string _rotu, string _nimi) 
        {
            rotu = _rotu;
            nimi = _nimi;
            MaaraUp();
        }
        //overridattu metodi
        public override void Hauku()
        {
            Console.WriteLine(nimi + " shouts: Meow!");
        }
    }
}
