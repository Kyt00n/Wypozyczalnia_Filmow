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

        public Wypozyczalnia()
        {
            wypozyczenia = new List<Wypozyczenie>();
            pracownicy = new List<Pracownik>();
            katalog = new List<Film>();
        }

        public void UmiescPracownikow(Pracownik t)
        {
            pracownicy.Add(t);
        }

        public void UmiescWypozyczenia(Wypozyczenie x)
        {
            wypozyczenia.Add(x);
        }

        public void WypiszWypozyczenie(int id)
        {
            foreach(var x in wypozyczenia)
            {
                if (x.IdWypozyczenia == id)
                {
                    Console.WriteLine(x.ToString()); ;
                }
            }
        }
        public void UsunPracownika(int id)
        {
            foreach(var x in pracownicy)
            {
                if (x.IdPracownika == id)
                {
                    pracownicy.Remove(x);
                    break;
                }
            }
        }
        public void UsunWypozyczenie(int id)
        {
            foreach (var x in wypozyczenia)
            {
                if (x.IdWypozyczenia == id)
                {
                    wypozyczenia.Remove(x);
                    break;
                }
            }
        }
        public bool PracownikIstnieje(int id)
        {
            foreach(var x in pracownicy)
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
            katalog.Add(film);
        }
        public void UsunFilm(string nazwa)
        {
            foreach(var x in katalog)
            {
                if (x.NazwaFilmu == nazwa)
                {
                    katalog.Remove(x);
                    break;
                }
            }
        }
        public List<Film> wyszukajPoKategorii(EnumGatunek gatunek)
        {
            List<Film> temp = new List<Film>() ;
            foreach(var x in katalog)
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
            foreach(var x in katalog)
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
            this.nazwa = nazwa;
            this.oplata_podstawowa = oplata_podstawowa;
            this.oplata_dodatkowa = oplata_dodatkowa;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder1 = new StringBuilder();
            foreach (Pracownik t in pracownicy)
            {
                stringBuilder1.AppendLine(t.ToString());
            }
            StringBuilder stringBuilder2 = new StringBuilder();
            foreach (Wypozyczenie x in wypozyczenia)
            {
                stringBuilder2.AppendLine(x.ToString());
            }
            return "Nazwa wypożyczalni: " + nazwa + "\nOpłata podstawowa: " + oplata_podstawowa + "zł\nOpłata dodatkowa: " + oplata_dodatkowa +
                "zł\nLista pracowników:\n" + stringBuilder1.ToString() + "\nLista wypożyczonych filmów:\n" + stringBuilder2.ToString();
        }

        public object Clone()
        {
            Wypozyczalnia temp = new Wypozyczalnia();
            List<Film> lista = new List<Film>();
            foreach (Film x in katalog)
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
            wypozyczenia.Sort();
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
