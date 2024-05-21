using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT8
{

    internal class Boss : Henkilo
    {
        //variables
        string name;
        string workplace;
        int salary;
        string car;
        static int i = 0;

        public Boss(string name, string workplace, int salary, string car) //constructor
        {
            if (i == 0)
            {
                this.name = name;
                this.workplace = workplace;
                this.salary = salary;
                this.car = car;
                i++;
            }
            else
            {
                throw new Exception("Only 1 boss!"); //actually works | code to test here:  Boss pomo2 = new Boss("as", "asd", 123, "asd");
            }
        }
        public void Bonus(string workerName,int workerSalary) // compare the 2 salaries
        {
            var i = salary - workerSalary;
            Console.WriteLine(name + " as the boss gets " + i + " as bonus compared to " + workerName + " at " + workplace);
        }
        public void Car() // big flex
        {
            Console.WriteLine(name + " drives a " + car + " to work.");
        }
    }
}
