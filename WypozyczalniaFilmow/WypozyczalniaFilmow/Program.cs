using System;

namespace WypozyczalniaFilmow
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek test1= new Czlowiek("Jan", "Kowalski", "19-12-2000","0000000000000", Czlowiek.Plec.M, "997");
            System.Console.WriteLine(test1);
        }
    }
}
