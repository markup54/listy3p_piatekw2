using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfListy3Ppiatek
{
    public class Produkt
    {
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public double Cena { get; set; }
        public bool Dostepny { get; set; }
        public string Kategoria { get; set; }

        public Produkt(string nazwa, string opis, double cena, bool dostepny, string kategoria)
        {
            Nazwa = nazwa;
            Opis = opis;
            Cena = cena;
            Dostepny = dostepny;
            Kategoria = kategoria;
        }
    }
}
