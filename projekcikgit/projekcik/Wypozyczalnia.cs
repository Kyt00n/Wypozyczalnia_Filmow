using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace projekcik
{
    [Serializable]
    public class Wypozyczalnia :ICloneable
    {
        List<Wypozyczenie> wypozyczenia;
        List<Pracownik> pracownicy;
        List<Film> katalog;
        string nazwa;
        double oplata_podstawowa;
        double oplata_dodatkowa;

        public List<Wypozyczenie> Wypozyczenia { get => wypozyczenia; set => wypozyczenia = value; }
        public List<Pracownik> Pracownicy { get => pracownicy; set => pracownicy = value; }
        public List<Film> Katalog { get => katalog; set => katalog = value; }
        public string Nazwa { get => nazwa; set => nazwa = value; }
        public double Oplata_podstawowa { get => oplata_podstawowa; set => oplata_podstawowa = value; }
        public double Oplata_dodatkowa { get => oplata_dodatkowa; set => oplata_dodatkowa = value; }

        public Wypozyczalnia()
        {
            Wypozyczenia = new List<Wypozyczenie>();
            Pracownicy = new List<Pracownik>();
            Katalog = new List<Film>();
        }

        public void UmiescPracownikow(Pracownik t)
        {
            Pracownicy.Add(t);
        }

        public void UmiescWypozyczenia(Wypozyczenie x)
        {
            Wypozyczenia.Add(x);
        }

        public void WypiszWypozyczenie(int id)
        {
            foreach(var x in Wypozyczenia)
            {
                if (x.IdWypozyczenia == id)
                {
                    Console.WriteLine(x.ToString()); ;
                }
            }
        }
        public void UsunPracownika(int id)
        {
            foreach(var x in Pracownicy)
            {
                if (x.IdPracownika == id)
                {
                    Pracownicy.Remove(x);
                    break;
                }
            }
        }
        public void UsunWypozyczenie(int id)
        {
            foreach (var x in Wypozyczenia)
            {
                if (x.IdWypozyczenia == id)
                {
                    Wypozyczenia.Remove(x);
                    break;
                }
            }
        }
        public bool PracownikIstnieje(int id)
        {
            foreach(var x in Pracownicy)
            {
                if(x.IdPracownika == id)
                {
                    return true;
                }
            }
            return false;
        }
        public void DodajFilm(Film film)
        {
            Katalog.Add(film);
        }
        public void UsunFilm(string nazwa)
        {
            foreach(var x in Katalog)
            {
                if (x.NazwaFilmu == nazwa)
                {
                    Katalog.Remove(x);
                    break;
                }
            }
        }
        public List<Film> wyszukajPoKategorii(EnumGatunek gatunek)
        {
            List<Film> temp = new List<Film>() ;
            foreach(var x in Katalog)
            {
                if(x.Gatunekfilm == gatunek)
                {
                    temp.Add(x);
                }
            }
            return temp;
        }
        public string wyszukajPoKategoriiString(EnumGatunek gatunek)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var x in Katalog)
            {
                if (x.Gatunekfilm == gatunek)
                {
                    sb.AppendLine(x.ToString());
                }
            }
            return sb.ToString();
        }
        public Wypozyczalnia(string nazwa, double oplata_podstawowa, double oplata_dodatkowa) : this()
        {
            this.Nazwa = nazwa;
            this.Oplata_podstawowa = oplata_podstawowa;
            this.Oplata_dodatkowa = oplata_dodatkowa;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder1 = new StringBuilder();
            foreach (Pracownik t in Pracownicy)
            {
                stringBuilder1.AppendLine(t.ToString());
            }
            StringBuilder stringBuilder2 = new StringBuilder();
            foreach (Wypozyczenie x in Wypozyczenia)
            {
                stringBuilder2.AppendLine(x.ToString());
            }
            return "Nazwa wypożyczalni: " + Nazwa + "\nOpłata podstawowa: " + Oplata_podstawowa + "zł\nOpłata dodatkowa: " + Oplata_dodatkowa +
                "zł\nLista pracowników:\n" + stringBuilder1.ToString() + "\nLista wypożyczonych filmów:\n" + stringBuilder2.ToString();
        }

        public object Clone()
        {
            Wypozyczalnia temp = new Wypozyczalnia();
            List<Film> lista = new List<Film>();
            foreach (Film x in Katalog)
            {
                temp.DodajFilm((Film)x.Clone());
            }
            return temp;
        }

        public void ZapiszXML(string plik)
        {
            using (StreamWriter file = new StreamWriter(plik))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Wypozyczalnia));
                xs.Serialize(file, this);
            }
        }
        public void Sortuj()
        {
            Wypozyczenia.Sort();
        }
        public static Wypozyczalnia OdczytajXML(string plik)
        {
            if (!File.Exists(plik))
            {
                return null;
            }
            using (StreamReader file = new StreamReader(plik))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Wypozyczalnia));
                return (Wypozyczalnia)xs.Deserialize(file);
            }
        }
        
    }



    
}
