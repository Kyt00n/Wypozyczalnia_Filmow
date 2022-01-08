using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace projekcik
{
    [Serializable]
    public class Klient : Osoba, IComparable<Klient>
    {
        int idKlienta;
        public static int licznik_klientow = 0;
        int do_Zaplaty;

        public Klient()
        {

        }
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
        
        public override string ToString()
        {
            return base.ToString() + ", ID klienta: " + idKlienta + ", należności: " + do_Zaplaty + "zł";
        }

        public int CompareTo(Klient other)
        {
            int x = Nazwisko.CompareTo(other.Nazwisko);
            if (x != 0) return x;
            return Imie.CompareTo(other.Imie);
        }
    }
}
