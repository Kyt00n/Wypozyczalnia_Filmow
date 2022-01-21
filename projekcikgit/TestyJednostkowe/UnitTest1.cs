using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace projekcik
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNazwy()
        {
            Wypozyczalnia wypozyczalnia = new Wypozyczalnia("test");
            string nazwa = "test";
            Assert.AreEqual(nazwa, wypozyczalnia.Nazwa);
        }
        [TestMethod]
        public void TestKlienta()
        {
            Klient k1 = new Klient("Eryk", "Olsza", "12345678901", "123456789", 21, "a@gmail.com", 0);
            Klient k2 = new Klient("Michal", "Swiderek", "12345678901", "123456789", 21, "a@gmail.com", 0);
            Klient k3 = new Klient("Wiktoria", "Skowron", "12345678901", "123456789", 21, "a@gmail.com", 0);
            Klient k4 = new Klient("Wojciech", "Smolarczyk", "12345678901", "123456789", 22, "a@gmail.com", 5);
            int liczba = 22;
            Assert.AreEqual(liczba, k4.Wiek);
        }
        [TestMethod]
        [ExpectedException(typeof(BlednyPeselException))]
        public void TestBledu()
        {
            Klient klient = new Klient("Eryk", "Olsza", "123456701", "123456789", 21, "a@gmail.com", 0);
        }
        [TestMethod]
        public void TestInterfejsu()
        {
            Klient klient1 = new Klient("Eryk", "Olsza", "12345678901", "123456789", 21, "a@gmail.com", 0);
            Klient klient2 = new Klient("Alicja", "Olsza", "12345678901", "123456789", 21, "a@gmail.com", 0);
            int oczekiwane = 1;
            Assert.AreEqual(oczekiwane, klient1.CompareTo(klient2));
        }
    }   
}
