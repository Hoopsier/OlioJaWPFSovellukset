﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_2
{
    internal class Opiskelija
    {
        public int OPP;
        public string name;
        public string OID;
        public Opiskelija(int _OPP,string _name,string _OID) 
        {
            OPP = _OPP;
            name = _name;
            OID = _OID;
        }

        public void TulostaData()
        {
            Console.WriteLine(name + " " + OPP + " " + OID);
        }
        public void MuokkaaOPP(int x) 
        {
            OPP = x;
        }
    }
}
