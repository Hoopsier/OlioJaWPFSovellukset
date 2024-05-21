using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT4
{
    internal class Kappale
    {
        //variables
        string pituus;
        string nimi;
        public Kappale(string pituus, string nimi)//constructor
        {
            this.pituus = pituus;
            this.nimi = nimi;
        }
        //data on command for easier listing (way easier than getting name externally)
        public void GetData()
        {
            Console.WriteLine("Nimi: "+nimi+" - "+pituus);
        }
    }
}
