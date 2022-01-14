using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using projekcik;


namespace GUI
{
    
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Wypozyczalnia wypozyczalnia;
        public MainWindow()
        {
            InitializeComponent();
            wypozyczalnia = Wypozyczalnia.OdczytajXML(@"netflix.xml"); // nazwa pliku + właściwa ścieżka! 
            if (wypozyczalnia is object)
            {
                PracownicyList.ItemsSource = new ObservableCollection<Pracownik>(wypozyczalnia.Pracownicy);
                nazwaWyptxt.Text = wypozyczalnia.Nazwa;
                FilmList.ItemsSource = new ObservableCollection<Film>(wypozyczalnia.Katalog);
                WypozyczeniaList.ItemsSource = new ObservableCollection<Wypozyczenie>(wypozyczalnia.Wypozyczenia);
                KlienciList.ItemsSource = new ObservableCollection<Klient>(wypozyczalnia.Klienci);
            }
        }

        private void FilmDodajBT_Click(object sender, RoutedEventArgs e)
        {
            Film fm = new Film();
            Window_Film okno = new Window_Film(fm);
            bool? result = okno.ShowDialog();

            if (result == true)
            {
                wypozyczalnia.DodajFilm(fm); //dodajemy członka
                                         //kolekcja.Add(cz);
                                         //FilmList.Items.Refresh();

                FilmList.ItemsSource = new
           ObservableCollection<Film>(wypozyczalnia.Katalog);
            }
        }
     private void FilmUsunBT_Click(object sender, RoutedEventArgs e)
        {
            if (FilmList.SelectedIndex > -1)
            {
                Film fm= FilmList.SelectedItem as Film;
                wypozyczalnia.UsunFilm(fm.NazwaFilmu);
                FilmList.ItemsSource = new
                ObservableCollection<Film>(wypozyczalnia.Katalog);
            }
        }

        private void NazwaBT_Click(object sender, RoutedEventArgs e)
        {
            Window_Nazwa okno = new Window_Nazwa(wypozyczalnia);
            bool? result = okno.ShowDialog();
            if (result == true)
            {
                nazwaWyptxt.Text = wypozyczalnia.Nazwa;
            }
        }

        private void PracownikDodajBTN_Click(object sender, RoutedEventArgs e)
        {
            Pracownik pr = new Pracownik();
            Window_Pracownik okno = new Window_Pracownik(pr);
            bool? result = okno.ShowDialog();

            if (result == true)
            {
                wypozyczalnia.UmiescPracownikow(pr); //dodajemy członka
                                         //kolekcja.Add(cz);
                                         //lstCzlonkowie.Items.Refresh();

                PracownicyList.ItemsSource = new
           ObservableCollection<Pracownik>(wypozyczalnia.Pracownicy);
            }

        }

        private void PracownikUsunBTN_Click(object sender, RoutedEventArgs e)
        {
            if (PracownicyList.SelectedIndex > -1)
            {
                Pracownik pr = PracownicyList.SelectedItem as Pracownik;
                wypozyczalnia.UsunPracownika(pr.IdPracownika);
                PracownicyList.ItemsSource = new
                ObservableCollection<Pracownik>(wypozyczalnia.Pracownicy);
            }
        }

        private void KlientDodajBTN_Click(object sender, RoutedEventArgs e)
        {
            Klient kl = new Klient();
            Window_Pracownik okno = new Window_Pracownik(kl);
            bool? result = okno.ShowDialog();

            if (result == true)
            {
                wypozyczalnia.UmiescKlienta(kl); //dodajemy członka
                                                     //kolekcja.Add(cz);
                                                     //lstCzlonkowie.Items.Refresh();

                KlienciList.ItemsSource = new
           ObservableCollection<Klient>(wypozyczalnia.Klienci);
            }
        }

        private void ZapisBTN_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
                wypozyczalnia.Nazwa = nazwaWyptxt.Text;
                wypozyczalnia.ZapiszXML(filename);
            }

        }

        private void MenuWyjdz_Click(object sender, RoutedEventArgs e) {

            Close();
        
        
        }

        private void MenuOtworz_Click(object sender, RoutedEventArgs e) {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Filter = "(XML)|*.xml";
            bool? result = dlg.ShowDialog();

            if (result == true) {
                string filename = dlg.FileName;
                wypozyczalnia = Wypozyczalnia.OdczytajXML(filename);
            
            
            
            }
        
        
        }

        private void DodajWYPBTN_Click(object sender, RoutedEventArgs e)
        {
            Wypozyczenie wp = new Wypozyczenie(); 
            Wypożyczenie okno = new Wypożyczenie(wp,wypozyczalnia);
            bool? result = okno.ShowDialog();

            if (result == true)
            {
                wypozyczalnia.UmiescWypozyczenia(wp); //dodajemy członka
                                                 //kolekcja.Add(cz);
                                                 //lstCzlonkowie.Items.Refresh();

                WypozyczeniaList.ItemsSource = new
           ObservableCollection<Wypozyczenie>(wypozyczalnia.Wypozyczenia);
            }
        }
    }
}
