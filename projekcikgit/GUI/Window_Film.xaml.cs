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
    /// Logika interakcji dla klasy Window_Film.xaml
    /// </summary>
    public partial class Window_Film : Window
    {
        Film film;
        public Window_Film()
        {
            InitializeComponent();
            DlugoscTXT.IsEnabled = false;
            
        }

        public Window_Film(Film flm) : this()
        {
            film = flm;
            if (film is Film fm)
            {
                DlugoscTXT.IsEnabled = true;
                KrajTXT.Text = fm.KrajProdukcji;
                ReżyserTXT.Text = fm.Rezyser;
                DlugoscTXT.Text = fm.Dl_w_min.ToString();
                CenaTXT.Text = fm.Cena_w_zl.ToString();

                GatunekCombo.Text = fm.Gatunekfilm.ToString();
            }

            else
            {
                KrajTXT.IsEnabled = true;
            }


        }

        private void AnulujBUTTON_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void ZATbutton_Click(object sender, RoutedEventArgs e)
        {
            if (TytTXT.Text != "" || DlugoscTXT.Text != "" || ReżyserTXT.Text != "")
            {
                film.NazwaFilmu = TytTXT.Text;
                film.Rezyser = ReżyserTXT.Text;
                film.KrajProdukcji = KrajTXT.Text;
                film.Dl_w_min = Int32.Parse(DlugoscTXT.Text);
                film.Cena_w_zl = Int32.Parse(CenaTXT.Text);
                if (GatunekCombo.Text == "horror")
                {
                    film.Gatunekfilm =Film.EnumGatunek.horror;
                }
                else if(GatunekCombo.Text == "western")
                {
                    film.Gatunekfilm = Film.EnumGatunek.western;
                }
                else if (GatunekCombo.Text == "melodramat")
                {
                    film.Gatunekfilm = Film.EnumGatunek.melodramat;
                }
                else if (GatunekCombo.Text == "dramat")
                {
                    film.Gatunekfilm = Film.EnumGatunek.dramat;
                }
                else if (GatunekCombo.Text == "kryminał")
                {
                    film.Gatunekfilm = Film.EnumGatunek.kryminał;
                }
                else if (GatunekCombo.Text == "przygodowy")
                {
                    film.Gatunekfilm = Film.EnumGatunek.przygodowy;
                }
                else if (GatunekCombo.Text == "fantasy")
                {
                    film.Gatunekfilm = Film.EnumGatunek.fantasy;
                }
                else if (GatunekCombo.Text == "musical")
                {
                    film.Gatunekfilm = Film.EnumGatunek.musical;
                }
                else if (GatunekCombo.Text == "komedia")
                {
                    film.Gatunekfilm = Film.EnumGatunek.komedia;
                }
                else if (GatunekCombo.Text == "wojenny")
                {
                    film.Gatunekfilm = Film.EnumGatunek.wojenny;
                }
                else film.Gatunekfilm = Film.EnumGatunek.sensacyjny;
                DialogResult = true;
                return;
            }

            DialogResult = false;
        }
    }
}