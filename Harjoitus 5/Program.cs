/*
 * Renan Horuz
 */
internal class Program
{
    private static void Main(string[] args)
    {
        int lasku;  //Mikä lasku 1-4
        int x;      //Ensimmäinen numero
        int y;      //Toinen numero
        int z = 0;      //Vastaus

        //Ohjaus
        Console.WriteLine("1 = Summa\n2 = Erotus\n3 = Tulo\n4 = Osamäärä");
        Console.Write("Valitsemasi lasku: ");
        lasku = Convert.ToInt32(Console.ReadLine());

        Console.Write("Seuraavaksi ensimmäinen luku:");
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Viimeiseksi toinen luku:");
        y = Convert.ToInt32(Console.ReadLine());

        switch (lasku)
        {
            case 1: //Summa
                Console.Write(x + " + " + y + " = ");
                z = x + y;

            break; 
            
            case 2: //Erotus
                Console.Write(x + " - " + y + " = ");
                z = x - y;

            break; 
            
            case 3: //Tulo
                Console.Write(x + " * " + y + " = ");
                z = x * y;

                break; 
            
            case 4: //Osamäärä
                Console.Write(x + " / " + y + " = ");
                z = x / y; 

            break;
        }
        Console.WriteLine(z);   //Vastaus tekstinä
    }
}