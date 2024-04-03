using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_11
{
    internal class Opiskelija
    {
        //opiskelijan muuttujat
        public string etunimi;
        public string sukunimi;
        public string ryhmatunnus;
        public string opID { get; set; }
        //opiskelija konstruktori
        public Opiskelija(string _enimi, string _snimi, string _rtunnus, string? _opID)
        {
            etunimi = _enimi;
            sukunimi = _snimi;
            ryhmatunnus = _rtunnus;
            opID = _opID;
        }
    }
}
