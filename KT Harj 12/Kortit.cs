using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_Harj_12
{
    internal class Kortit
    {
        //variables
        public string Muoto;
        public int Numero;
        public string? kuva;

        //constructor
        public Kortit (string muoto, int numero)
        {
            //set variables (too lazy to use _ as it auto filled the whole constructor without it)
            Muoto = muoto;
            Numero = numero;
            //picture cards
            if (numero == 1) { kuva = "ässä"; }
            if (numero == 11) { kuva = "jätkä"; }
            if (numero == 12) { kuva = "kuningatar"; }
            if (numero == 13) { kuva = "kuningas"; }
        }
    }
    
}
