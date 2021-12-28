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
        int idKlienta;
        public static int licznik_klientow = 0;
        int do_Zaplaty;

        public Klient(string imie, string nazwisko, string pesel, int numerTelefonu, int wiek, string email, int do_Zaplaty) : base(imie, nazwisko, pesel, numerTelefonu, wiek, email)
        {
            this.idKlienta = ++licznik_klientow;
            this.do_Zaplaty = do_Zaplaty;
            
        }
        
        public override string ToString()
        {
            return base.ToString() + ", ID klienta: " + idKlienta + ", należności: " + do_Zaplaty + "zł";
        }
    }
}
