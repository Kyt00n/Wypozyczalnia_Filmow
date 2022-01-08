using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace projekcik
{
    [Serializable]
    public class Wypozyczenie : IComparable<Wypozyczenie>, ICloneable
    {
        Film wypozyczony_film;
        Klient wypozyczony_przez;
        DateTime data_wypozyczenia;
        DateTime data_oddania;
        static int obecnyLicznik =0 ;
        private int idWypozyczenia;

        public Film Wypozyczony_film { get => wypozyczony_film; set => wypozyczony_film = value; }
        public Klient Wypozyczony_przez { get => wypozyczony_przez; set => wypozyczony_przez = value; }
        public DateTime Data_wypozyczenia { get => data_wypozyczenia; set => data_wypozyczenia = value; }
        public DateTime Data_oddania { get => data_oddania; set => data_oddania = value; }
        public int IdWypozyczenia { get => idWypozyczenia; set => idWypozyczenia = value; }

        public Wypozyczenie()
        {
            this.idWypozyczenia = ++obecnyLicznik;
        }
        public Wypozyczenie(Film wypozyczony_film, Klient wypozyczony_przez, string data_wypozyczenia, string data_oddania):this()
        {
            this.wypozyczony_film = wypozyczony_film;
            this.wypozyczony_przez = wypozyczony_przez;
            this.data_wypozyczenia = DateTime.Parse(data_wypozyczenia);
            this.data_oddania = DateTime.Parse(data_oddania);
            
        }

        public override string ToString()
        {
            return $"Id: {idWypozyczenia}\n Wypożyczony film: {wypozyczony_film}\n" +
                $"Wypożyczony przez: {wypozyczony_przez}\n" +
                $"Data wypożyczenia: {data_wypozyczenia: dd/MM/yyyy}\n" +
                $"Data oddania: {data_oddania: dd/MM/yyyy}";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Wypozyczenie other)
        {
            int x = Wypozyczony_przez.Nazwisko.CompareTo(other.Wypozyczony_przez.Nazwisko);
            if (x != 0) return x;
            return Wypozyczony_przez.Imie.CompareTo(other.Wypozyczony_przez.Imie);
        }
    }
}
