using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT3
{
    public class Kiuas
    {
        //variables
        public int temp;
        public int moist;
        public bool on;
        public Kiuas(int _temp, int _moist, bool _on) //constructor
        {
            this.temp = _temp;
            this.moist = _moist;
            on = _on;
        }
        public void ToggleKiuas()
        {
            on = !on; // the toggle
            if (on == true) // toggle's effects
            {
                Console.WriteLine("Kiuas on päällä.");
                
            }
            else
            {
                temp = 20;
                moist = 0;
                Console.WriteLine("Kiuas on pos päältä.");
            }
        }


    }
}
