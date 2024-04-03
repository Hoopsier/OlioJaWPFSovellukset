/*
 * Renan Horuz EI VIDEOITA KÄYTETTYNÄ TEHTÄVIIN (en jaksa tehä kotitehtäviä JA harjoituksia täysin yksin)
 */
using Harjoitus_7;

internal class Program
{
    private static void Main(string[] args)
    {
        //tee hissi
        Hissi hissi = new Hissi();

        //looppaa loputtomasti, koska ei tarvitse muuta
        while (!Hissi.done)
        {
            Hissi.KerrosSiirto();
        }

    }
}