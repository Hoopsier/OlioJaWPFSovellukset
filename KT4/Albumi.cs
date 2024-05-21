using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT4
{
    internal class Albumi
    {
        //variables and list
        string artist;
        string title;
        string genre;
        int price;
        List<Kappale> kappaleet = new List<Kappale> { };
        public Albumi(string artist, string title, string genre, int price)// constructor
        {
            this.artist = artist;
            this.title = title;
            this.genre = genre;
            this.price = price;
        }
        public void KappaleAdd(Kappale kappale) //add the items to the list
        {
            kappaleet.Add(kappale);
        }
        public void KappaleetPrint() // the big print
        {
            Console.WriteLine(title + " is "+ genre +" and consists of:");
            foreach (var k in kappaleet) //go through the list
            {
                k.GetData();
            }
            Console.WriteLine("And it costs "+price.ToString("C2") + "."); //console doesn't seem to know the € symbol
        }
    }
}
