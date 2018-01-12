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
    /// Interaction logic for LogAdmin.xaml
    /// </summary>
    public partial class LogAdmin : Window 
    {
        public LogAdmin()
        {
            InitializeComponent();
        }
        private void Btnzaloguj_Click(object sender, RoutedEventArgs e)
        {

            PanelAdmin pane = new PanelAdmin();            
            MessageBox.Show("Cześć Admin!", "Zalogowano");
            pane.ShowDialog();          
            this.Close();
            
            
            
        }

        private void btnwroc_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnkontakt_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Telefon Admin: 678329402                       E-Mail: admin@wp.pl","Kontakt Admin");
        }
    }
}
