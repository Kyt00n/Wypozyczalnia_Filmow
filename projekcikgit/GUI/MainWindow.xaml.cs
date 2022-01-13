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
    }
}
