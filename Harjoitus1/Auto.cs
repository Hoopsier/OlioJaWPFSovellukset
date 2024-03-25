/*
 * Renan Horuz
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus1
{
    
    internal class Car
    {
        //Muuttujat
        public int? speed;  //saa olla null
        public string brand;
        public string model;

        //Tehdään auto konstruktori
        public Car(int? _speed,string _brand,string _model) 
        {
            speed = _speed;
            brand = _brand;
            model = _model;
            Console.WriteLine(brand + " " + model + " " + speed + " " + "km/h");   
        }
    }
}
