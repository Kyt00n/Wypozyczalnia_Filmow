using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace projekcik
{
    abstract class Osoba
    {
        string imie;
        string nazwisko;
        string pesel;
        int numerTelefonu;
        int wiek;
        string email;

        public Osoba()
        {
        }

        public Osoba(string imie, string nazwisko, string pesel, int numerTelefonu, int wiek, string email) : this()
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            if (SprawdzPesel(pesel))
            {
                this.pesel = pesel;
            }
            this.numerTelefonu = numerTelefonu;
            this.wiek = wiek;
            this.email = email;
        }

        public bool SprawdzPesel(string pesel)
        {
            // 11 liczb
            if (!Regex.IsMatch(pesel, @"^1?(\d{11})"))
                throw new BlednyPeselException();

            return Regex.IsMatch(pesel, @"^1?(\d{11})");
        }

        public override string ToString()
        {
            return $"{imie} {nazwisko}, PESEL: {pesel}, tel.: {numerTelefonu}, lat: {wiek}, e-mail: {email}";
        }
    }
}
