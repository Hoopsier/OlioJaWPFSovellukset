using KT3;
/*
 * Renan Horuz
 */
internal class Program
{
    private static void Main(string[] args)
    {
        Kiuas kiuas = new Kiuas(20, 0, false);
        Console.WriteLine("Kiuas on poissa päältä. pistääksesi sen päälle, kirjoita y");
        
        while (true)
        {
            var x = Console.ReadLine();
            if (x == "y")
            {
                kiuas.ToggleKiuas();
                
                break;
            }
           else
            {
                Console.WriteLine("Vastaus ei ollut y. Jos haluat laittaa kiukaan päälle, kirjoita y");
            }
        }
        Console.WriteLine("Seuraavaksi minkä haluat asettaa (l)ämpötilan vai (K)osteuden?");
        var a = false;
        while (!a)
        {

            var x = Console.ReadLine();
            if (x == "k")
            {
                Console.WriteLine("Minkä kosteuden haluat asettaa? 0-100 %.");
                while (true) //varmistaa että saa tuloksen
                {
                    var y = Console.ReadLine();
                    if (int.TryParse(y, out int z))
                    {
                        z = Math.Clamp(z, 0, 100);
                        Console.WriteLine("Kosteus on nyt " + z + " %.");
                        kiuas.moist = z;
                        Console.WriteLine("Oletko tämä sopiva? (y)");
                        var b = Console.ReadLine();
                        if (b == "y") { break; }
                    }
                    else
                    {
                        Console.WriteLine("Vain numeroita kiitos!");
                    }
                    
                }
                
            }
            else if (x == "l")
            {
                Console.WriteLine("Minkä lämmön haluat asettaa? 30-70 astetta.");
                while (true) //varmistaa että saa tuloksen
                {
                    var y = Console.ReadLine();
                    if (int.TryParse(y, out int z))
                    {
                        z = Math.Clamp(z, 30, 70);
                        Console.WriteLine("Lämpö on nyt " + z + " astetta.");
                        kiuas.temp = z;
                        Console.WriteLine("Oletko tämä sopiva? (y)");
                        var b = Console.ReadLine();
                        if (b == "y") { break; }
                    }
                    else
                    {
                        Console.WriteLine("Vain numeroita kiitos!");
                    }
                }
            }
            Console.WriteLine("Oletko valmis? (y)"); //(haluatko lopettaa sovelluksen)
            var c = Console.ReadLine();
            if (c == "y") { a = true; Console.WriteLine("Lämpötila on " + kiuas.temp + " astetta ja kosteus on " + kiuas.moist + "%."); }
            else
            {
                Console.WriteLine("Minkä haluat asettaa (l)ämpötilan vai (K)osteuden?");
            }
        }
    }
}