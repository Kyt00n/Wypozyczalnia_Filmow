using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace projekcik
{/// <summary>
/// Klient dziedziczy po klasie Osoba i opisuje Klienta naszej Wypożyczalni
/// </summary>
    [Serializable]
    public class Klient : Osoba, IComparable<Klient>
    {
        int idKlienta;
        /// <summary>
        /// Licznik klientów wypożyczalni
        /// </summary>
        public static int licznik_klientow = 0;
        int do_Zaplaty;
        /// <summary>
        /// Konstruktor nieparametryczny
        /// </summary>
        public Klient()
        {
            
        }
        /// <summary>
        /// Konstruktor parametryczny
        /// </summary>
        
        public Klient(string imie, string nazwisko, string pesel, string numerTelefonu, int wiek, string email, int do_Zaplaty) : base(imie, nazwisko, pesel, numerTelefonu, wiek, email)
        {
            this.idKlienta = ++licznik_klientow;
            this.do_Zaplaty = do_Zaplaty;
            Imie = imie;
            Nazwisko = nazwisko;
            Pesel = pesel;
            NumerTelefonu = numerTelefonu;
            Wiek = wiek;
            Email = email;
            
        }
        /// <summary>
        /// Funkcja dostracza danych o kliencie
        /// </summary>
        /// <returns>Zwraca napis z danymi kilenta</returns>
        public override string ToString()
        {
            return base.ToString() + ", ID klienta: " + idKlienta + ", należności: " + do_Zaplaty + "zł";
        }
        /// <summary>
        /// Funkcja porównuje dwóch klientów
        /// </summary>
        /// <param name="other">Parametr to po prostu Klient do którego będziemy porównywać</param>
        /// <returns>Zwraca 0 lub wartość ujemne lub dodatnie w zależności od wyniku porównania</returns>
        public int CompareTo(Klient other)
        {
            int x = Nazwisko.CompareTo(other.Nazwisko);
            if (x != 0) return x;
            return Imie.CompareTo(other.Imie);
        }
    }
}
