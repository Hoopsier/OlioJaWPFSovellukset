/*
 * Renan Horuz & help of gpt
 * EI VIDEOITA KÄYTETTYNÄ TEHTÄVIIN (en jaksa tehä kotitehtäviä JA harjoituksia täysin yksin)
 * tää tehtävä on varmasti huomattavan erillainen videosta
 */
using Harjoitus_11;
using System.Collections;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        bool x = false;
        Dictionary<string, Opiskelija> opiskelijaSanakirja = new Dictionary<string, Opiskelija>();
        Opiskelija Matti = new Opiskelija("Matti", "Mykkä", "RAT25","1");
        opiskelijaSanakirja.Add(Matti.opID, Matti);
        //guidance
        Console.WriteLine("Please input a new student in this format: fName + enter + lName + enter + group + enter + studentID");



        Opiskelija Matti1 = new Opiskelija(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(),null);
        while (!x)
        {
            try
            {
                Matti1.opID = Console.ReadLine();
                //opiskelijaSanakirja.Add(Matti1.opID, Matti1); Tämä lisäisi indexin vaikka siinä olisi samanlainen avain, täysin rikkoo tämän.
                //this portion was assisted by gpt. However, it didn't follow guidelines.
                if (opiskelijaSanakirja.ContainsKey(Matti1.opID)) //error check
                {
                    throw new MyException("ID has already been assigned. Try again please.");
                }
                else
                {
                    opiskelijaSanakirja.Add(Matti1.opID, Matti1);
                    x = true; // Set x to true to end the loop
                }
            }
            catch (Exception)
            {
                Console.WriteLine("That ID is already in use! Try again please.");
            }
        }

        Console.WriteLine(Matti.etunimi+" id: "+Matti.opID
            +"\n"+Matti1.etunimi+" id: "+Matti1.opID);

    }
}