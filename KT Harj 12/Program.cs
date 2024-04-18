/*
 * Renan Horuz assisted by anonymous Stack Overflow user
 * (Täst edes pelkästään KT)
 */
using KT_Harj_12;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        //create a new list for the cards
        var kortit = new List<Kortit>();
        //create cards
        for (int i = 1; i < 14; i++) 
        {
            kortit.Add(new Kortit("hertta", i));
            kortit.Add(new Kortit("pata", i));
            kortit.Add(new Kortit("ruutu", i));
            kortit.Add(new Kortit("risti", i));
        }
        //randomize
        var rng = new Random();
        rng.Shuffle(kortit);

        //write the cards in that shuffled order
        for (int i = 0; i < kortit.Count; i++)
        {
            if (kortit[i].kuva != null) //check if the card has an image
            {
                Console.WriteLine(kortit[i].Muoto);
            }
            else
            {
                Console.WriteLine(kortit[i].Muoto);
            }
        }
        //final message
        //Console.WriteLine("\nKortteja on siis "+kortit.Count+"\n\n");
    }
}