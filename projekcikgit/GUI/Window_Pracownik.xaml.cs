using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using projekcik;
namespace GUI
{
    /// <summary>
    /// Logika interakcji dla klasy Window_Pracownik.xaml
    /// </summary>
    public partial class Window_Pracownik : Window
    {
        Osoba pracownik;
        public Window_Pracownik()
        {
            InitializeComponent();
        }

        public Window_Pracownik(Osoba pr) : this()
        { pracownik=pr;
            if (pracownik is Osoba Prc) {
                imieTXT.Text = Prc.Imie;
                NazwiskoTXT.Text = Prc.Nazwisko;
                PeselTXT.Text = Prc.Pesel;
                wiekTXT.Text = (Prc.Wiek).ToString();
                mailTXT.Text = Prc.Email;
                TelTXT.Text = Prc.NumerTelefonu;
            
            
            
            }
        }

        private void ANBTN_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void ZATBTN_Click(object sender, RoutedEventArgs e)
        {
            if (imieTXT.Text != "" || NazwiskoTXT.Text != "" || PeselTXT.Text != "")
            {
                pracownik.Pesel = PeselTXT.Text;
                pracownik.Imie = imieTXT.Text;
                pracownik.Nazwisko = NazwiskoTXT.Text;
                pracownik.Wiek = Int32.Parse(wiekTXT.Text);
                pracownik.Email = mailTXT.Text;
                
                DialogResult = true;
                return;
            }

            DialogResult = false;
        }
    }
}
