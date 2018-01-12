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

namespace Scientia_interfejs_alpha
{
    /// <summary>
    /// Interaction logic for PanelAdmin.xaml
    /// </summary>
    public partial class PanelAdmin : Window
    {
        public PanelAdmin()
        {
            InitializeComponent();
            this.DPdzis.SelectedDate = DateTime.Now;
            List<Sprzet> sprzeet = new List<Sprzet>();
            sprzeet.Add(new Sprzet() { Id = 1, Nazwa = "Laptop Andrzeja",Kategoria="Laptop",Opis = "Szybki",Czywypozyczalny="Tak",Czywypozyczony="Nie",Stan="sprawny", Data_wyp="1999-02-03", Data_zwr = "1996-02-03",Kto="Andrzej" });
           
            dgsprzet.ItemsSource = sprzeet;
        }
        public class Sprzet
        {
            public int Id { get; set; }

            public string Nazwa { get; set; }

            public string Kategoria { get; set; }

            public string Opis { get; set; }

            public string Stan { get; set; }

            public string Czywypozyczalny { get; set; }

            public string Czywypozyczony { get; set; }

            public string Data_wyp { get; set; }

            public string Data_zwr { get; set; }

            public string Kto { get; set; }
        }

        private void MenuItem_Wroc(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Zamk(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(RBczl.IsChecked == true)
            {
                CBkto.Visibility = Visibility.Visible;
                lblkto2.Visibility = Visibility.Visible;
                SPdane.Visibility = Visibility.Hidden;
                SPlbl.Visibility = Visibility.Hidden;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (RBgosc.IsChecked==true)
            {
                CBkto.Visibility = Visibility.Hidden;
                lblkto2.Visibility = Visibility.Hidden;
                SPdane.Visibility = Visibility.Visible;
                SPlbl.Visibility = Visibility.Visible;
            }
        }

        private void MIedytczlo_Click(object sender, RoutedEventArgs e)//edycja czlonkow
        {
            Wind_Edyt_Czl wind_Edyt_Czl = new Wind_Edyt_Czl();
            wind_Edyt_Czl.ShowDialog();
        }

        private void MIedytzaso_Click(object sender, RoutedEventArgs e)//edycja zasobow
        {
            Win_Edyt_Zas win_Edyt_Zas = new Win_Edyt_Zas();
            win_Edyt_Zas.ShowDialog();
        }
    }
}
