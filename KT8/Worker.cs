using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT8
{
    internal class Worker : Henkilo
    {
        //variables
        public int salary;
        public string name;
        string workplace;
        int hoursPD; //PD = per day
        public Worker(int salary, string name, string workplace, int hoursPD) //constructor
        {
            this.salary = salary;
            this.name = name;
            this.workplace = workplace;
            this.hoursPD = hoursPD;
        }
        public void Tunnit() 
        {
            var hPW = hoursPD * 5;
            Console.WriteLine(name + " työskentelee " + hoursPD + " tuntia päivässä eli " + hPW + " tuntia viikossa.");
        }
    }
}
