using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace projekcik
{
    class Pracownik : Osoba
    {
        public int idPracownika;
        public static int licznik_pracownikow = 0;

        public Pracownik(string imie, string nazwisko, string pesel, int numerTelefonu, int wiek, string email) : base(imie, nazwisko, pesel, numerTelefonu, wiek, email)
        {
            this.idPracownika = ++licznik_pracownikow;
            
        }

        public override string ToString()
        {
            return base.ToString() + ", ID pracownika: " + idPracownika;
        }
    }
}
