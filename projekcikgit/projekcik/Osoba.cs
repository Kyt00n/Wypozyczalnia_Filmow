using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace projekcik
{/// <summary>
/// Klasa Osoba stanowi podstawę dla wielu klas obecnych w naszym projekcie
/// </summary>
    public abstract class Osoba
    {
        string imie;
        string nazwisko;
        string pesel;
        string numerTelefonu;
        int wiek;
        string email;
        /// <summary>
        /// Konstruktor nieparametryczny
        /// </summary>
        public Osoba()
        {
        }
        /// <summary>
        /// Konstruktor parametryczny
        /// </summary>
       
        public Osoba(string imie, string nazwisko, string pesel, string numerTelefonu, int wiek, string email) : this()
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
        /// <summary>
        /// Hermetyzacja Imienia
        /// </summary>
        public string Imie { get => imie; set => imie = value; }
        /// <summary>
        /// Hermetyzacja Nazwiska
        /// </summary>
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
      /// <summary>
      /// Hermetyzacja Peselu
      /// </summary>
        public string Pesel { get => pesel; set => pesel = value; }
       /// <summary>
       /// Hermetyzacja Numeru Telefonu
       /// </summary>
        public string NumerTelefonu { get => numerTelefonu; set => numerTelefonu = value; }
      /// <summary>
      /// Hermetyzacja Wieku
      /// </summary>
        public int Wiek { get => wiek; set => wiek = value; }
       /// <summary>
       /// Hermetyzacja maila
       /// </summary>
        public string Email { get => email; set => email = value; }
        /// <summary>
        /// Funkcja sprawdza czy dany pesel jest poprawny
        /// </summary>
        /// <param name="pesel">Paramter to po prostu pesel</param>
        /// <returns>Zwarca true lub rzuca błędem w zależności od wyniku sprawdzenia</returns>
        public bool SprawdzPesel(string pesel)
        {
            // 11 liczb
            if (!Regex.IsMatch(pesel, @"^1?(\d{11})"))
                throw new BlednyPeselException();

            return Regex.IsMatch(pesel, @"^1?(\d{11})");
        }
        /// <summary>
        /// Funkcja dostarcza informacji o Osobie
        /// </summary>
        /// <returns>Zawarca napis z danymi o Osobie</returns>
        public override string ToString()
        {
            return $"{imie} {nazwisko}, PESEL: {pesel}, tel.: {numerTelefonu}, lat: {wiek}, e-mail: {email}";
        }
    }
}
