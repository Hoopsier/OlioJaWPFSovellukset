using Harjoitus_7;

internal class Program
{
    private static void Main(string[] args)
    {
        Hissi hissi = new Hissi();
        while (!Hissi.done)
        {
            Hissi.KerrosSiirto();
        }

    }
}