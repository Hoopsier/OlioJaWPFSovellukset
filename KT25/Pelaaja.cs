using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace KT25
{
    public class Pelaaja
    {
        //variables
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int PelaajaNumero { get; set; }
        public string Joukkue { get; set; }

        public Pelaaja(string etunimi, string sukunimi, int pelaajaNumero, string joukkue)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            PelaajaNumero = pelaajaNumero;
            Joukkue = joukkue;
        }
    }
}
