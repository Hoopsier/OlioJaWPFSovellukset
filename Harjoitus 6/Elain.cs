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
        public virtual void Hauku()
        {
            Console.WriteLine("Bark!");
        }
        public void MaaraUp()
        {
            amount++;
        }
        public static void Maara() 
        {
            Console.WriteLine("Eläimiä: " + amount);
        }
    }
}
