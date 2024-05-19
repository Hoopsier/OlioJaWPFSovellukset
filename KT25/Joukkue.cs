using System.Collections.Generic;
using System.Linq;

namespace KT25
{
    public class Joukkue
    {
        //variables
        public string Nimi { get; set; }
        public string Kotikaupunki { get; set; }
        public Dictionary<int, Pelaaja> Pelaajat { get; set; }

        public Joukkue(string nimi, string kotikaupunki) //constructor for team objects
        {
            Nimi = nimi;
            Kotikaupunki = kotikaupunki;
            Pelaajat = new Dictionary<int, Pelaaja>();
        }

        public Pelaaja HaePelaaja(int pelaajaNumero) // get specific players from the team
        {
            Pelaajat.TryGetValue(pelaajaNumero, out var pelaaja);
            return pelaaja;
        }

        public void LisääPelaaja(Pelaaja pelaaja) // add a player to the team
        {
            Pelaajat[pelaaja.PelaajaNumero] = pelaaja;
        }

        public void PoistaPelaaja(int pelaajaNumero) // remove a player from the team
        {
            Pelaajat.Remove(pelaajaNumero);
        }

        public List<Pelaaja> HaePelaajat() // get all players as their values to a list for the datagrid
        {
            return Pelaajat.Values.ToList();
        }
    }
}
