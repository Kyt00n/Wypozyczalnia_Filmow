using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekcik
{
    class Wypozyczalnia
    {
        List<Wypozyczenie> wypozyczenia;
        List<Pracownik> pracownicy;
        string nazwa;
        double oplata_podstawowa;
        double oplata_dodatkowa;

        public Wypozyczalnia()
        {
            wypozyczenia = new List<Wypozyczenie>();
            pracownicy = new List<Pracownik>();
        }

        public void UmiescPracownikow(Pracownik t)
        {
            pracownicy.Add(t);
        }

        public void UmiescWypozyczenia(Wypozyczenie x)
        {
            wypozyczenia.Add(x);
        }

        public Wypozyczalnia(string nazwa, double oplata_podstawowa, double oplata_dodatkowa) : this()
        {
            this.nazwa = nazwa;
            this.oplata_podstawowa = oplata_podstawowa;
            this.oplata_dodatkowa = oplata_dodatkowa;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder1 = new StringBuilder();
            foreach (Pracownik t in pracownicy)
            {
                stringBuilder1.AppendLine(t.ToString());
            }
            StringBuilder stringBuilder2 = new StringBuilder();
            foreach (Wypozyczenie x in wypozyczenia)
            {
                stringBuilder2.AppendLine(x.ToString());
            }
            return "Nazwa wypożyczalni: " + nazwa + "\nOpłata podstawowa: " + oplata_podstawowa + "zł\nOpłata dodatkowa: " + oplata_dodatkowa +
                "zł\nLista pracowników:\n" + stringBuilder1.ToString() + "\nLista wypożyczonych filmów:\n" + stringBuilder2.ToString();
        }
    }
}
