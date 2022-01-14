using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Logika interakcji dla klasy Wypożyczenie.xaml
    /// </summary>
    public partial class Wypożyczenie : Window
    {  
        Wypozyczenie wypozyczenie;
        Wypozyczalnia wypoz;
        List<Film> lstF = new List<Film>();
        List<Klient> lstK = new List<Klient>();
        public Wypożyczenie()
        {
            InitializeComponent();
        }

        public Wypożyczenie(Wypozyczenie wyp, Wypozyczalnia wypozyczalnia) : this()
        {
            wypozyczenie = wyp;
            wypoz = wypozyczalnia;
            lstF=wypozyczalnia.Katalog;
            lstK = wypozyczalnia.Klienci;
            if (wypozyczenie is Wypozyczenie wypożyczenie && wypoz is Wypozyczalnia wypożyczalnia)
            {
                Data_odTXT.Text = $"{wypożyczenie.Data_wypozyczenia:dd-MMM-yyyy}";
                Data_doTXT.Text = $"{wypożyczenie.Data_oddania:dd-MMM-yyyy}";
                foreach (Film var in lstF)
                {
                    FilmCOMB.Items.Add(var);
                
                }
                foreach (Klient var in lstK)
                {
                    KlientCOMB.Items.Add(var);
                
                }
                //KlientCOMB.Items.Add(wypożyczalnia.Klienci);
               
               ///FilmCOMB.Text = wypożyczenie.Wypozyczony_film.ToString();
                //KlientCOMB.Text = wypożyczenie.Wypozyczony_przez.ToString();
            }
        }

        private void AnulBTN_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void ZatBtn_Click(object sender, RoutedEventArgs e) {
            
            if (Data_doTXT.Text != "" && Data_odTXT.Text != "")
            {
                DateTime.TryParseExact(Data_odTXT.Text, new[] { "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MMM-yyyy" }, null, DateTimeStyles.None, out DateTime date);
                wypozyczenie.Data_wypozyczenia = date;
                DateTime.TryParseExact(Data_odTXT.Text, new[] { "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MMM-yyyy" }, null, DateTimeStyles.None, out DateTime date2);
                wypozyczenie.Data_oddania = date2;
                wypozyczenie.Wypozyczony_film=(Film)FilmCOMB.SelectedItem;
                wypozyczenie.Wypozyczony_przez = (Klient)KlientCOMB.SelectedItem;
                DialogResult = true;
                return;
            
            }
            DialogResult = false;


        }


    }


}
