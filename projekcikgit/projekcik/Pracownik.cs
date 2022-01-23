using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace projekcik
{/// <summary>
/// Klasa Pracownik określa pracownika Wypożyczyalni
/// </summary>
    [Serializable]
    public class Pracownik : Osoba
    {
        private int idPracownika;
        private static int licznik_pracownikow = 0;
        /// <summary>
        /// Hermetyzacja pola ID Pracownika
        /// </summary>
        public int IdPracownika { get => idPracownika; set => idPracownika = value; }
        /// <summary>
        /// Hermetyzacja Licznika Pracowników
        /// </summary>
        public static int Licznik_pracownikow { get => licznik_pracownikow; set => licznik_pracownikow = value; }
        /// <summary>
        /// Konstruktor nie parametryczny
        /// </summary>
        public Pracownik()
        {
            this.idPracownika = ++licznik_pracownikow;
        }
        /// <summary>
        /// Konstruktor parametryczny
        /// </summary>
        
        public Pracownik(string imie, string nazwisko, string pesel, string numerTelefonu, int wiek, string email) : this()
        {
           
            Imie = imie;
            Nazwisko = nazwisko;
            Pesel = pesel;
            NumerTelefonu = numerTelefonu;
            Wiek = wiek;
            Email = email;
        }
        /// <summary>
        /// Funkcja opisuje wszystkie pola klasy Pracownik
        /// </summary>
        /// <returns>Zawraca napis będący połączeniem podstawowych danych o naszym pracowniku</returns>
        public override string ToString()
        {
            return base.ToString() + ", ID pracownika: " + idPracownika;
        }
    }
}
