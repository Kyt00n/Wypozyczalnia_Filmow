using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekcik
{
    class Wypozyczenie
    {
        Film wypozyczony_film;
        Klient wypozyczony_przez;
        DateTime data_wypozyczenia;
        DateTime data_oddania;

        public Wypozyczenie(Film wypozyczony_film, Klient wypozyczony_przez, string data_wypozyczenia, string data_oddania)
        {
            this.wypozyczony_film = wypozyczony_film;
            this.wypozyczony_przez = wypozyczony_przez;
            this.data_wypozyczenia = DateTime.Parse(data_wypozyczenia);
            this.data_oddania = DateTime.Parse(data_oddania);
        }

        public override string ToString()
        {
            return $"Wypożyczony film: {wypozyczony_film}\n" +
                $"Wypożyczony przez: {wypozyczony_przez}\n" +
                $"Data wypożyczenia: {data_wypozyczenia: dd/MM/yyyy}\n" +
                $"Data oddania: {data_oddania: dd/MM/yyyy}";
        }
    }
}
