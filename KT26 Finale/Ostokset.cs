using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KT26_Finale
{
    public class Ostokset : IOstokset
    {
        //variables for the object from the interface
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        //constructor for new products
        public Ostokset(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity; 
            
        }
    }
}
