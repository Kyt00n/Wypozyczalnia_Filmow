using System;

namespace WypozyczalniaFilmow
{
    public class Czlowiek
    {
        protected string imie;
        protected string nazwisko;
        protected DateTime dataUrodzenia;
        protected string pESEL;
        public enum Plec{M, K};
        protected Plec plec1;
        protected string numerTelefonu;
        protected int wiek;

        public Czlowiek(string imie, string nazwisko, string dataUrodzenia, string pESEL, Plec plec1, string numerTelefonu)
        {
            this.imie = imie;
            DateTime.TryParse(dataUrodzenia, out this.dataUrodzenia);
            this.pESEL = pESEL;
            this.plec1 = plec1;
            this.numerTelefonu = numerTelefonu;
            //this.wiek = ;
        }    


        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public DateTime DataUrodzenia { get => dataUrodzenia; set => dataUrodzenia = value; }
        public string PESEL { get => pESEL; set => pESEL = value; }
        public Plec Plec1 { get => plec1; set => plec1 = value; }
        public string NumerTelefonu { get => numerTelefonu; set => numerTelefonu = value; }
        protected int Wiek { get => wiek; set => wiek = value; }

        public override string ToString()
        {
            return $"{imie}, {nazwisko}, {dataUrodzenia}, {PESEL}, {plec1}, {numerTelefonu}, {DateTime.Today.Year - this.DataUrodzenia.Year}";
        }
    }
}