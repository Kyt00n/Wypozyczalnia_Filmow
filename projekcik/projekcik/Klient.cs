using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace projekcik
{
    class Klient : Osoba
    {
        string idKlienta;
        public static int licznik_klientow = 0;
        int do_Zaplaty;

        public Klient(string imie, string nazwisko, string pesel, int numerTelefonu, int wiek, string email, string idKlienta, int do_Zaplaty) : base(imie, nazwisko, pesel, numerTelefonu, wiek, email)
        {
            this.idKlienta = idKlienta;
            this.do_Zaplaty = do_Zaplaty;
            Interlocked.Increment(ref licznik_klientow);
        }
        
        public override string ToString()
        {
            return base.ToString() + ", ID klienta: " + idKlienta + ", należności: " + do_Zaplaty + "zł";
        }
    }
}
