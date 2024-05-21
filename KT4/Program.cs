/*
 * Renan Horuz
 */
using KT4;

internal class Program
{
    private static void Main(string[] args)
    {
        //create the instances of the objects
        Kappale kap = new Kappale("3:20","20c pie");
        Kappale kap2 = new Kappale("2:50", "Mr. Applepie");
        Kappale kap3 = new Kappale("3:00", "Sugar Rash, Yikes!");
        Kappale kap4 = new Kappale("4:30", "Salt in the Wound");
        Kappale kap5 = new Kappale("3:45", "Taffy Treats");
        Albumi albumi = new Albumi("Sweeter", "Cravings", "J-Pop", 70);
        //add to the album
        albumi.KappaleAdd(kap);
        albumi.KappaleAdd(kap2);
        albumi.KappaleAdd(kap3);
        albumi.KappaleAdd(kap4);
        albumi.KappaleAdd(kap5);
        //the loop that goes through the list of objects in the album
        albumi.KappaleetPrint();
    }
}