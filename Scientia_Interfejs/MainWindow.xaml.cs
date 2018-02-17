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
using System.Data.SqlClient;

namespace Scientia_Interfejs
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnzaloguj_Click(object sender, RoutedEventArgs e)
        {
            if (txtboxlog == null && txtboxpsw == null)                                                                 ////sprawdzanie pustych pól
            {
                MessageBox.Show("Pola nie mogą być puste", "Nieprawidłowe dane");
            }
            else
            {
                SqlConnectionStringBuilder pol = new SqlConnectionStringBuilder();                                  ////model połączneiowy
                pol.DataSource = "";
                pol.InitialCatalog = "Ewidencja_SI";
                pol.IntegratedSecurity = true;
                SqlConnection con = new SqlConnection(pol.ConnectionString);

                string zapytanie = @"SELECT id_osoby,Logg,Haslo 
                                FROM Osoby 
                                WHERE Logg='" + txtboxlog.Text + "' AND Haslo='" + txtboxpsw.Password + "'";

                try
                {
                    SqlCommand com = new SqlCommand(zapytanie, con);
                    con.Open();
                    int id_uzytkownika = 0;

                    SqlDataReader red = com.ExecuteReader();
                    if (red.Read())
                    {
                        id_uzytkownika = red.GetInt16(0);
                    }
                    con.Close();
                    if (id_uzytkownika != 0)
                    {
                        Window1 wypo = new Window1(id_uzytkownika);
                        MessageBox.Show("Cześć", "Zalogowano pomyślnie");
                        wypo.Show();
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Błędny login i/lub hasło", "Logowanie nie powiodło się");
                    }
                }
                catch (SqlException exc)
                {

                    MessageBox.Show(exc.Message, "Błąd SQL");
                }
                finally
                {
                    con.Close();
                }

            }

        }

        private void btnkontakt_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("XD", "Kontakt");
        }


    }
}
