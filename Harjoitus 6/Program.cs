using Harjoitus_6;

internal class Program
{
    private static void Main(string[] args)
    {
        Kissa Miuku = new Kissa("Siamese","Miuku");
        Elain.Maara();
        Koira Musti = new Koira("Shiba", "Musti");
        Console.WriteLine(Miuku.nimi+"n rotu on"+Miuku.rotu);
        Console.WriteLine(Musti.nimi + "n rotu on" + Musti.rotu);
        Elain.Maara();
        Miuku.Hauku();
        Musti.Hauku();
    }
}