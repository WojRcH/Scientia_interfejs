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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Scientia_interfejs_alpha
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();           
            
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

            //public string Details
            //{
            //    get
            //    {
            //        return String.Format("{0} was born on {1} and this is a long description of the person.");
            //    }
            //}
        }
        
        private void BtnPanel_Click(object sender, RoutedEventArgs e)
        {
            LogAdmin logadm = new LogAdmin();
            logadm.ShowDialog();            
        }
        private void BtnO_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Witaj użytkowniku! Jesteśmy wielce zadowoleni, że korzystasz z naszego programu mamy nadzieję, że Ci się spodoba!", "O programie");
        }

        private void plak_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                
                System.Diagnostics.Process.Start("http://knsi.ue.katowice.pl/");
            }
            catch { }
        }

        private void plak_MouseEnter(object sender, MouseEventArgs e)
        {
            plak.Opacity = .2;
        }

        private void plak_MouseLeave(object sender, MouseEventArgs e)
        {
            plak.Opacity = 1;
        }

        private void Lblkom_MouseEnter(object sender, MouseEventArgs e)
        {
            BtnPanel.FontWeight = FontWeights.ExtraBold;
        }

        private void Lblkom_MouseLeave(object sender, MouseEventArgs e)
        {
            BtnPanel.FontWeight = FontWeights.Normal;
        }

        private void CBfiltr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch(CBfiltr.Text)
            {
                case "Komórka":
                   
                    
                    
                    break;
                case "Telefon":
                    
                    break;
                default:
                    
                    break;


            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Sprzet> sprzeet = new List<Sprzet>();//lista do datagrid
            sprzeet.Add(new Sprzet() { Id = 1, Nazwa = "Laptop Andrzeja", Opis = "Szybki", Stan = "Sprawny", Czywypozyczalny = "tak", Czywypozyczony = "nie",Kategoria="Laptop" });
            
           
            dgsprzet.ItemsSource = sprzeet;//datagrid
        }
    }
}
