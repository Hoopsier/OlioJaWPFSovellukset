/*
 * Renan Horuz EI VIDEOITA KÄYTETTYNÄ TEHTÄVIIN (en jaksa tehä kotitehtäviä JA harjoituksia täysin yksin)
 */
using Harjoitus_6;

internal class Program
{
    private static void Main(string[] args)
    {
        //tee kissa
        Kissa Miuku = new Kissa("Siamese","Miuku");
        //eläin määrä
        Elain.Maara();
        //tee koira
        Koira Musti = new Koira("Shiba", "Musti");
        //tunnista eläimet
        Console.WriteLine(Miuku.nimi+"n rotu on"+Miuku.rotu);
        Console.WriteLine(Musti.nimi + "n rotu on" + Musti.rotu);
        //eläin määrä
        Elain.Maara();
        //eläimet puhuvat
        Miuku.Hauku();
        Musti.Hauku();
    }
}