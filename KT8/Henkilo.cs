using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT8
{
    abstract class Henkilo
    {
        string? name;
        string? workplace;
        int salary;

        public void Salary()
        {
            Console.WriteLine(name + " gets " + salary + " per month working at " + workplace);
        }
    }
    
}
