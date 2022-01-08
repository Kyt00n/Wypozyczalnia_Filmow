using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace projekcik
{
    [Serializable]
    public class Pracownik : Osoba
    {
        private int idPracownika;
        private static int licznik_pracownikow = 0;

        public int IdPracownika { get => idPracownika; set => idPracownika = value; }
        public static int Licznik_pracownikow { get => licznik_pracownikow; set => licznik_pracownikow = value; }

        public Pracownik()
        {
            this.idPracownika = ++licznik_pracownikow;
        }

        public Pracownik(string imie, string nazwisko, string pesel, string numerTelefonu, int wiek, string email) : this()
        {
            
            Imie = imie;
            Nazwisko = nazwisko;
            Pesel = pesel;
            NumerTelefonu = numerTelefonu;
            Wiek = wiek;
            Email = email;
        }

        public override string ToString()
        {
            return base.ToString() + ", ID pracownika: " + idPracownika;
        }
    }
}
