using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_6
{
    internal class Koira : Elain
    {
        public string rotu;
        public string nimi;

        public Koira(string _rotu, string _nimi)
        {
            rotu = _rotu;
            nimi = _nimi;
            MaaraUp();
        }
        public override void Hauku()
        {
            Console.WriteLine(nimi + " shouts: Bark!");
        }
    }
}
