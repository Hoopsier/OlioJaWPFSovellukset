/*
 * Renan Horuz
 */
internal class Program
{
    private static void Main(string[] args)
    {
        int lasku;  //Mikä lasku 1-4
        float x;    //Ensimmäinen numero
        float y;    //Toinen numero
        Console.WriteLine("1 = Summa\n2 = Erotus\n3 = Tulo\n4 = Osamäärä");
        Console.Write("Valitsemasi lasku: ");
        lasku = Convert.ToInt(Console.ReadLine());

        Console.Write("Seuraavaksi ensimmäinen luku:");
        x = Convert.ToFloat(Console.ReadLine());

        Console.Write("Viimeiseksi toinen luku:");
        y = Convert.ToFloat(Console.ReadLine());

        switch (lasku)
        {
            case 1: //Summa
                Console.Write(x + " + " + y + " = ");
                Console.WriteLine(x + y);
            break; 
            
            case 2: //Erotus
                Console.Write(x + " - " + y + " = ");
                Console.WriteLine(x - y);
            break; 
            
            case 3: //Tulo
                Console.Write(x + " * " + y + " = ");
                Console.WriteLine(x * y);
            break; 
            
            case 4: //Osamäärä
                Console.Write(x + " / " + y + " = ");
                Console.WriteLine(x / y);
            break;
        }
    }
}