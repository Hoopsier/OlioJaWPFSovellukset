using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT26_Finale
{
    public interface IOstokset //here only because it has to be
    {
        string Name { get; set; }
        double Price { get; set; }
        int Quantity { get; set; }
    }
}
