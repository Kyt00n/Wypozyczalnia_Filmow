using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekcik
{/// <summary>
 /// Typ enum określa Gatunek filmu
 /// </summary>

    public enum EnumGatunek
    {
        /// <summary>
        /// Pierwszy typ
        /// </summary>
        komedia,
        /// <summary>
        /// Drugi typ
        /// </summary>
        dramat,
        /// <summary>
        /// Trzeci typ
        /// </summary>
        melodramat,
        /// <summary>
        /// Czwarty typ
        /// </summary>
        fantasy,
        /// <summary>
        /// Piąty typ
        /// </summary>
        kryminał,
        /// <summary>
        /// Szósty typ
        /// </summary>
        horror,
        /// <summary>
        /// Siódmy typ
        /// </summary>
        przygodowy,
        /// <summary>
        /// Ósmy typ
        /// </summary>
        musical,
        /// <summary>
        /// Dziweiąty typ
        /// </summary>
        sensacyjny,
        /// <summary>
        /// Dziesiąty typ
        /// </summary>
        wojenny,
        /// <summary>
        /// Jedynasty typ
        /// </summary>
        western
    }


    /// <summary>
    /// Klasa Film opisuje filmy w naszej Wypożyczalni
    /// </summary>
    [Serializable]
    public class Film : IComparable<Film>, ICloneable
    {/// <summary>
     /// Typ enum określa Gatunek filmu
     /// </summary>

        public enum EnumGatunek
        {
            /// <summary>
            /// Pierwszy typ
            /// </summary>
            komedia,
            /// <summary>
            /// Drugi typ
            /// </summary>
            dramat,
            /// <summary>
            /// Trzeci typ
            /// </summary>
            melodramat,
            /// <summary>
            /// Czwarty typ
            /// </summary>
            fantasy,
            /// <summary>
            /// Piąty typ
            /// </summary>
            kryminał,
            /// <summary>
            /// Szósty typ
            /// </summary>
            horror,
            /// <summary>
            /// Siódmy typ
            /// </summary>
            przygodowy,
            /// <summary>
            /// Ósmy typ
            /// </summary>
            musical,
            /// <summary>
            /// Dziweiąty typ
            /// </summary>
            sensacyjny,
            /// <summary>
            /// Dziesiąty typ
            /// </summary>
            wojenny,
            /// <summary>
            /// Jedynasty typ
            /// </summary>
            western
        }

        private string nazwaFilmu;
        private EnumGatunek gatunekfilm;
        int dl_w_min;
        string rezyser;
        string krajProdukcji;
        int cena_w_zl;
        /// <summary>
        /// Hermetyzacja Nazwy Filmu
        /// </summary>
        public string NazwaFilmu { get => nazwaFilmu; set => nazwaFilmu = value; }
      /// <summary>
      /// Hermetyzacja Gatunku
      /// </summary>
        public EnumGatunek Gatunekfilm { get => gatunekfilm; set => gatunekfilm = value; }
       /// <summary>
       /// Hermetyzacja długości filmu
       /// </summary>
        public int Dl_w_min { get => dl_w_min; set => dl_w_min = value; }
      /// <summary>
      /// Hermetyzacja Reżysera
      /// </summary>
        public string Rezyser { get => rezyser; set => rezyser = value; }
       /// <summary>
       /// Hermetyzacja Kraju Produkcji
       /// </summary>
        public string KrajProdukcji { get => krajProdukcji; set => krajProdukcji = value; }
       /// <summary>
       /// Hermetyzacja Ceny
       /// </summary>
        public int Cena_w_zl { get => cena_w_zl; set => cena_w_zl = value; }
        /// <summary>
        /// Konstruktor nieparametryczny
        /// </summary>
        public Film()
        {
        }
        /// <summary>
        /// Konstruktor parametryczny
        /// </summary>
        
        public Film(string nazwaFilmu, EnumGatunek gatunekfilm, int dl_w_min, string rezyser, string krajProdukcji, int cena_w_zl) : this()
        {
            this.nazwaFilmu = nazwaFilmu;
            this.gatunekfilm = gatunekfilm;
            this.dl_w_min = dl_w_min;
            this.rezyser = rezyser;
            this.krajProdukcji = krajProdukcji;
            this.cena_w_zl = cena_w_zl;
        }
        /// <summary>
        /// Funkcja porównuje dwa filmy
        /// </summary>
        /// <param name="other">To paramter który opisuje drugi film</param>
        /// <returns>Zwraca 0 lub wartość ujemne lub dodatnie w zależności od wyniku porównania</returns>
        public int CompareTo(Film other)
        {
            int x = NazwaFilmu.CompareTo(other.NazwaFilmu);
            if (x != 0) return x;
            return Rezyser.CompareTo(other.rezyser);
        }
        /// <summary>
        /// Funkcja opisuje Film
        /// </summary>
        /// <returns>Zwraca napis z  danymi o filmie</returns>

        public override string ToString()
        {
            return $"{cena_w_zl}zł - {nazwaFilmu} {dl_w_min}min., {krajProdukcji}; Gat. {gatunekfilm}, Reż. {rezyser}";
        }
        /// <summary>
        /// Funkcja klonuje film
        /// </summary>
        /// <returns>Zwraca klona filmu</returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
