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
            Osoba osoba1 = new Osoba("Jan", "Kowalski", "12345678901", 777888999, 21, "aaa@abc.com");
            //Console.WriteLine(osoba1);

            Klient klient1 = new Klient("Jan", "Kowalski", "12345678901", 777888999, 21, "aaa@abc.com", "1", 32);
            //Console.WriteLine(klient1);
            Klient klient2 = new Klient("Jan", "Kowalski", "12345678901", 777888999, 21, "aaa@abc.com", "2", 32);
            //Console.WriteLine(klient2);
            //Console.WriteLine("Ilość klientów: {0}", Klient.licznik_klientow);

            Pracownik pracownik1 = new Pracownik("Jan", "Kowalski", "12345678901", 777888999, 21, "aaa@abc.com", "1");
            //Console.WriteLine(pracownik1);
            Pracownik pracownik2 = new Pracownik("Jan", "Kowalski", "12345678901", 777888999, 21, "aaa@abc.com", "2");
            //Console.WriteLine(pracownik2);
            //Console.WriteLine("Ilość pracowników: {0}", Pracownik.licznik_pracownikow);

            Film film1 = new Film("Spiderman", EnumGatunek.przygodowy, 93, "Spike Lee", "Rumunia", 32);
            //Console.WriteLine(film1);

            Wypozyczenie wypozyczenie1 = new Wypozyczenie(film1, klient1, "21/01/2021", "21/03/2021");
            Console.WriteLine(wypozyczenie1);

            Console.ReadLine();
        }
    }
}
