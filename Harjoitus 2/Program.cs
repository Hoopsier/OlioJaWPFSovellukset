using Harjoitus_2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Opiskelija Aatu = new Opiskelija(160,"Aatu","0165");

        Aatu.TulostaData();
        Aatu.MuokkaaOPP(165);
        Aatu.TulostaData();
    }
}