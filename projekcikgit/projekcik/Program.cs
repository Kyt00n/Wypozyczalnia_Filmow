using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekcik
{
    class Program
    {
        static FileStream fs;
        static StreamWriter sw;
        public delegate void Przywitanie(string s);
        public static void Wypisz(string s)
        {
            Console.WriteLine(s);
        }
        public static void Zapisz(string s)
        {
            fs = new FileStream(".\\wiadomosc.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public static void SendString(Przywitanie p)
        {
            p("Autorzy projektu: \nEryk Olsza \nWiktoria Skowron\nWojciech Smolarczyk\nMichal Swiderek");
        }
        static void Main(string[] args)
        {

            Przywitanie p1 = new Przywitanie(Wypisz);
            Przywitanie p2 = new Przywitanie(Zapisz);
            SendString(p1);
            SendString(p2);
            
            Klient klient1 = new Klient("Marek", "Nowak", "23456789012", "888999111", 18, "bbb@abc.com", 32);
            Klient klient2 = new Klient("Anita", "Zielona", "34567890123", "777888999", 21, "ccc@abc.com", 21);
            Pracownik pracownik1 = new Pracownik("Paweł", "Jumper", "45678901234", "666777888", 33, "ddd@abc.com");
            Pracownik pracownik2 = new Pracownik("Juliusz", "Cezar", "56789012345", "767878989", 27, "eee@abc.com");
            Film film1 = new Film("Spiderman", Film.EnumGatunek.przygodowy, 93, "Spike Lee", "Rumunia", 32);
            Wypozyczenie wypozyczenie1 = new Wypozyczenie(film1, klient1, "21/01/2021", "21/03/2021");
            Wypozyczenie wypozyczenie2 = new Wypozyczenie(film1, klient2, "22/01/2022", "23/01/2022");
            Wypozyczalnia wypozyczalnia1 = new Wypozyczalnia("Halko", 2.40, 3.50);
            wypozyczalnia1.UmiescPracownikow(pracownik1);
            wypozyczalnia1.UmiescKlienta(klient1);
            wypozyczalnia1.UmiescKlienta(klient2);
            wypozyczalnia1.UmiescPracownikow(pracownik2);
            wypozyczalnia1.UmiescWypozyczenia(wypozyczenie1);
            wypozyczalnia1.UmiescWypozyczenia(wypozyczenie2);
            wypozyczalnia1.UsunPracownika(1);
            wypozyczalnia1.DodajFilm(film1);
            Console.WriteLine(wypozyczalnia1);
            wypozyczalnia1.WypiszWypozyczenie(2);
            Console.WriteLine(wypozyczalnia1.wyszukajPoKategoriiString(EnumGatunek.przygodowy));
            wypozyczalnia1.ZapiszXML("netflix.xml");
            Console.ReadLine();
        }
    }
}
