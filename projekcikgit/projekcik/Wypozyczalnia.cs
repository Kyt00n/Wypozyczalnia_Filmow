using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace projekcik
{/// <summary>
/// Klasa Wypożyczalnia stanowi oś projektu opisując udając standardową wypożyczalnię
/// </summary>
    [Serializable]
    public class Wypozyczalnia :ICloneable
    {
        List<Wypozyczenie> wypozyczenia;
        List<Pracownik> pracownicy;
        List<Film> katalog;
        List<Klient> klienci;
        string nazwa;
        double oplata_podstawowa;
        double oplata_dodatkowa;

        
        /// <summary>
        /// Hermetyzacja Listy z Wypożyczeniami
        /// </summary>
        public List<Wypozyczenie> Wypozyczenia { get => wypozyczenia; set => wypozyczenia = value; }
       /// <summary>
       /// Hermetyzacja Listy z Pracownikami
       /// </summary>
        public List<Pracownik> Pracownicy { get => pracownicy; set => pracownicy = value; }
       /// <summary>
       /// Hermetyzacja Listy z Filmami
       /// </summary>
        public List<Film> Katalog { get => katalog; set => katalog = value; }
       /// <summary>
       /// Hermetyzacja Nazwy wypożyczalni
       /// </summary>
        public string Nazwa { get => nazwa; set => nazwa = value; }
       /// <summary>
       /// Hermetyzacja opłaty podstawowej
       /// </summary>
        public double Oplata_podstawowa { get => oplata_podstawowa; set => oplata_podstawowa = value; }
      /// <summary>
      /// Hermetyzacja opłaty dodatkowej
      /// </summary>
        public double Oplata_dodatkowa { get => oplata_dodatkowa; set => oplata_dodatkowa = value; }
      /// <summary>
      /// Hermetyzacja listy klientów
      /// </summary>
        public List<Klient> Klienci { get => klienci; set => klienci = value; }

        /// <summary>
        /// Konstruktor nieparametryczny
        /// </summary>
        public Wypozyczalnia()
        {
            Wypozyczenia = new List<Wypozyczenie>();
            Pracownicy = new List<Pracownik>();
            Katalog = new List<Film>();
            Klienci = new List<Klient>();
        }
        /// <summary>
        /// Funkcja umieszcza Klientów na liście klientów wypożyczalni
        /// </summary>
        /// <param name="t">Paramter określa klienta</param>
        public void UmiescKlienta(Klient t) {

            Klienci.Add(t);
        
        
        }
        

        /// <summary>
        /// Funkcja umieszcza pracownika na liście pracowników
        /// </summary>
        /// <param name="t">Paramter opisuje instancję klasy Pracownik</param>
        public void UmiescPracownikow(Pracownik t)
        {
            Pracownicy.Add(t);
        }
        /// <summary>
        /// Funkcja umieszcza wypożyczenie na liście wypozyczeń
        /// </summary>
        /// <param name="x">Paramter opisuje instancję klasy Wypożyczenie</param>
        public void UmiescWypozyczenia(Wypozyczenie x)
        {
            Wypozyczenia.Add(x);
        }
        /// <summary>
        /// Funkcja wypisuje Wypożyczenie o odpowiednim nr ID
        /// </summary>
        /// <param name="id">Paramter opisuje instancję klasy Wypożyczenie poprzez jego ID</param>
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
        /// <summary>
        /// Funkcja usuwa Pracownika z listy
        /// </summary>
        /// <param name="id">Parametr pomaga określić którego Pracownika usunąć w zależności od jego nr ID</param>
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
        /// <summary>
        /// Funkcja usuwa Wypożyczenie z listy
        /// </summary>
        /// <param name="id">Parametr pomaga określić które Wypożyczenie usunąć w zależności od jego nr ID</param>
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
        /// <summary>
        /// Funkcja sprawdza czy posiadamy danego pracownika na liście prac
        /// </summary>
        /// <param name="id">Paramter określa numer ID pracownika którego szukamy</param>
        /// <returns>Zwraca true lub false w zależności czy pracownik o danym ID istnieje</returns>
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
        /// <summary>
        /// Funkcja dodaje film do listy Filmów Wypożyczalni
        /// </summary>
        /// <param name="film">Parametr określa którą instancje klasy Film dodajemy</param>
        public void DodajFilm(Film film)
        {
            Katalog.Add(film);
        }
        /// <summary>
        /// Funkcja usuwa film z Listy filmów Wypożyczalni
        /// </summary>
        /// <param name="nazwa">Paramter pozwala zidentyfikować film do usunięcia dzięki jego nazwie</param>
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
        /// <summary>
        /// Wyszukuje wszystkie filmu z listy Filmów o danym gatunku
        /// </summary>
        /// <param name="gatunek">Pozwala określić gatunek którego poszukujemy</param>
        /// <returns>Zwraca listę z filmami danego gatunku</returns>
        public List<Film> wyszukajPoKategorii(EnumGatunek gatunek)
        {
            List<Film> temp = new List<Film>() ;
            foreach(var x in Katalog)
            {
                if(Equals(x.Gatunekfilm, gatunek))
                {
                    temp.Add(x);
                }
            }
            return temp;
        }
        /// <summary>
        /// Wyszukuje wszystkie filmu z listy Filmów o danym gatunku
        /// </summary>
        /// <param name="gatunek">Pozwala określić gatunek którego poszukujemy</param>
        /// <returns>Zwraca napis z filmami danego gatunku</returns>
        public string wyszukajPoKategoriiString(EnumGatunek gatunek)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var x in Katalog)
            {
                if (Equals(x.Gatunekfilm , gatunek))
                {
                    sb.AppendLine(x.ToString());
                }
            }
            return sb.ToString();
        }
        /// <summary>
        /// Konstruktor parametryczny
        /// </summary>
        public Wypozyczalnia(string nazwa) : this()
        {
            this.Nazwa = nazwa;
        }
        public Wypozyczalnia(string nazwa, double oplata_podstawowa, double oplata_dodatkowa) : this()
        {
            this.Nazwa = nazwa;
            this.Oplata_podstawowa = oplata_podstawowa;
            this.Oplata_dodatkowa = oplata_dodatkowa;
        }
/// <summary>
/// Funkcja dostracza informacjo o Wypożyczalni
/// </summary>
/// <returns>Zwraca napis z danymi o Wypozyczalni</returns>
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
        /// <summary>
        /// Funkcja klonuje Wypożyczalnię
        /// </summary>
        /// <returns>Zwarca klona Wypożyczalni</returns>
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
        /// <summary>
        /// Funkcja zapisuje do pliku XML Wypożyczalnię
        /// </summary>
        /// <param name="plik"></param>
        public void ZapiszXML(string plik)
        {
            using (StreamWriter file = new StreamWriter(plik))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Wypozyczalnia));
                xs.Serialize(file, this);
            }
        }
        /// <summary>
        /// Funkcja sortuje Listę z Wypożyczeniami
        /// </summary>
        public void Sortuj()
        {
            Wypozyczenia.Sort();
        }
        /// <summary>
        /// Funkcja odczytuje Wypozyczalnie z pliku XML
        /// </summary>
        /// <param name="plik"></param>
        /// <returns></returns>
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
