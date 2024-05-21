/*
 * Renan Horuz
 */
using KT8;

internal class Program
{
    private static void Main(string[] args)
    {
        // create the workers
        Boss pomo = new Boss("Jappe","ITT",5000,"Lambo");
        Worker tyontekija = new Worker(4500,"Dappe","ITT",6);
        //use all possible methods
        pomo.Salary();
        tyontekija.Salary();
        tyontekija.Tunnit();
        pomo.Bonus(tyontekija.name,tyontekija.salary);
        pomo.Car();
    }
}
