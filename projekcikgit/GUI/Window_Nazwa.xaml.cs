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
    /// Logika interakcji dla klasy Window_Nazwa.xaml
    /// </summary>
    public partial class Window_Nazwa : Window
    {
        Wypozyczalnia wypozyczalnia;
        public Window_Nazwa()
        {
            InitializeComponent();
        }

        public Window_Nazwa(Wypozyczalnia wp) : this()
        {
            wypozyczalnia = wp;
            if (wypozyczalnia is Wypozyczalnia Wypozyczalnia) {
                NAZWA_TXT.Text = Wypozyczalnia.Nazwa;
            
            
            
            }
        
        
        
        }

       

        private void AnBTN_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void ZatBTN_Click(object sender, RoutedEventArgs e)
        {
            if (NAZWA_TXT.Text != "")
            {

                wypozyczalnia.Nazwa = NAZWA_TXT.Text;
                DialogResult = true;
                return;
            }
            
            DialogResult = false;

        }
        
    }
}
