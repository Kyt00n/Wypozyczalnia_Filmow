using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekcik
{
    class Program
    {
        static void Main(string[] args)
        {
            //Osoba osoba1 = new Osoba("Jan", "Kowalski", "12345678901", 777888999, 21, "aaa@abc.com");
            //Console.WriteLine(osoba1);

            Klient klient1 = new Klient("Marek", "Nowak", "23456789012", 888999111, 18, "bbb@abc.com", 32);
            //Console.WriteLine(klient1);
            Klient klient2 = new Klient("Anita", "Zielona", "34567890123", 777888999, 21, "ccc@abc.com", 21);
            //Console.WriteLine(klient2);
            //Console.WriteLine("Ilość klientów: {0}", Klient.licznik_klientow);

            Pracownik pracownik1 = new Pracownik("Paweł", "Jumper", "45678901234", 666777888, 33, "ddd@abc.com");
            //Console.WriteLine(pracownik1);
            Pracownik pracownik2 = new Pracownik("Juliusz", "Cezar", "56789012345", 767878989, 27, "eee@abc.com");
            //Console.WriteLine(pracownik2);
            //Console.WriteLine("Ilość pracowników: {0}", Pracownik.licznik_pracownikow);

            Film film1 = new Film("Spiderman", EnumGatunek.przygodowy, 93, "Spike Lee", "Rumunia", 32);
            //Console.WriteLine(film1);

            Wypozyczenie wypozyczenie1 = new Wypozyczenie(film1, klient1, "21/01/2021", "21/03/2021");
            //Console.WriteLine(wypozyczenie1);
            Wypozyczenie wypozyczenie2 = new Wypozyczenie(film1, klient2, "22/01/2022", "23/01/2022");
            //Wypozyczalnia wypozyczalnia1 = new Wypozyczalnia("Halko", 2.40, 3.50);
            //Console.WriteLine(wypozyczalnia1);

            Wypozyczalnia wypozyczalnia1 = new Wypozyczalnia("Halko", 2.40, 3.50);
            wypozyczalnia1.UmiescPracownikow(pracownik1);
            wypozyczalnia1.UmiescPracownikow(pracownik2);
            wypozyczalnia1.UmiescWypozyczenia(wypozyczenie1);
            wypozyczalnia1.UmiescWypozyczenia(wypozyczenie2);
            wypozyczalnia1.UsunPracownika(1);
            wypozyczalnia1.DodajFilm(film1);
            Console.WriteLine(wypozyczalnia1);
            wypozyczalnia1.WypiszWypozyczenie(2);
            Console.WriteLine(wypozyczalnia1.wyszukajPoKategoriiString(EnumGatunek.przygodowy));
            Console.ReadLine();
        }
    }
}
