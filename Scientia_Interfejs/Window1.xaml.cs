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
using System.Data;
using System.Data.SqlClient;

namespace Scientia_Interfejs
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        DataSet ds = new DataSet("Kolo");
        SqlDataAdapter adap = new SqlDataAdapter();
        SqlDataAdapter adap2 = new SqlDataAdapter();
        SqlCommandBuilder zatwierdz;
        int id_uzytkownika = 0;

        public Window1(int uzytkownik)
        {
            InitializeComponent();
            id_uzytkownika = uzytkownik;


        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnectionStringBuilder pol = new SqlConnectionStringBuilder();                                  ////model bezpołączneiowy
            pol.DataSource = "";
            pol.InitialCatalog = "Ewidencja_SI";
            pol.IntegratedSecurity = true;

            SqlConnection con = new SqlConnection(pol.ConnectionString);


            try
            {                                                                                               //tworzenie dataseta z tabelami

                string zapytanie = "SELECT * FROM Wypozyczenia";
                adap = new SqlDataAdapter(zapytanie, con);
                adap.FillSchema(ds, SchemaType.Source, "Wypozyczenia");
                adap.Fill(ds, "Wypozyczenia");

                string zapytanie2 = "SELECT * FROM Zasoby";
                adap2 = new SqlDataAdapter(zapytanie2, con);                                     ///poprawić połączenie
                adap2.FillSchema(ds, SchemaType.Source, "Zasoby");
                adap2.Fill(ds, "Zasoby");

                aktualizacja();


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Błąd");
            }


        }

        public class Sprzet
        {

            public int id { get; set; }
            public string nazwa { get; set; }
            public string stan { get; set; }
            public string opis { get; set; }

        }

        private void aktualizacja()
        {


            var x = from z in ds.Tables["Zasoby"].AsEnumerable()                         //selekcja do zakładki pierwszej
                    where z.Field<Boolean>("Status_wypozyczenia") == false
                    select new Sprzet
                    {
                        id = z.Field<Int16>("id_zasobu"),
                        nazwa = z.Field<string>("Nazwa"),
                        stan = z.Field<string>("Stan_techniczny"),
                        opis = z.Field<string>("Opis")
                    };
            livwyp.ItemsSource = x;


            /*DateTime dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;*/

            var d = from z in ds.Tables["Zasoby"].AsEnumerable()                                                    //selekcja do zakładki drugiej
                    join c in ds.Tables["Wypozyczenia"].AsEnumerable() on z.Field<Int16>("ID_zasobu") equals c.Field<Int16>("ID_zasoby")
                    where c.Field<Int16>("ID_osoby") == id_uzytkownika && z.Field<Boolean>("Status_wypozyczenia") == true && c.Field<Boolean>("aktualne") == true /*&& c.Field<DateTime>("Data_zwrot") >= date*/
                    select new Sprzet
                    {

                        id = c.Field<int>("id_wypozyczenia"),
                        nazwa = z.Field<string>("Nazwa"),
                        stan = z.Field<string>("Stan_techniczny"),
                        opis = null

                    };

            livodd.ItemsSource = d;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (livwyp.SelectedValue != null && kalendarz.SelectedDate != null)
            {
                int id = (int)livwyp.SelectedValue;

                for (int i = 0; i < ds.Tables["Zasoby"].Rows.Count; i++)
                {                                                                                          //modyfikowanie tabel dla "wypożyczenie"
                    if (Convert.ToInt16(ds.Tables["Zasoby"].Rows[i][0]) == id)
                    {
                        ds.Tables["Zasoby"].Rows[i][7] = true;
                    }
                }

                DataRow row = ds.Tables["Wypozyczenia"].NewRow();
                row[1] = id_uzytkownika;
                row[2] = id;
                row[3] = DateTime.Now;
                row[4] = kalendarz.SelectedDate;
                row[5] = true;
                ds.Tables["Wypozyczenia"].Rows.Add(row);




            }
            else
            {
                MessageBox.Show("Nie wybrano sprzętu bądź daty oddania");
            }

            aktualizacja();

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

            if (livodd.SelectedValue != null)
            {
                int id = (int)livodd.SelectedValue;
                int id_do_zasobu = 0;



                for (int u = 0; u < ds.Tables["Wypozyczenia"].Rows.Count; u++)
                {
                    if (Convert.ToInt16(ds.Tables["Wypozyczenia"].Rows[u][0]) == id)
                    {
                        ds.Tables["Wypozyczenia"].Rows[u][4] = DateTime.Now;
                        ds.Tables["Wypozyczenia"].Rows[u][5] = false;
                        id_do_zasobu = (Int16)ds.Tables["Wypozyczenia"].Rows[u][2];
                    }
                }


                for (int i = 0; i < ds.Tables["Zasoby"].Rows.Count; i++)
                {                                                                                          //modyfikowanie tabel dla "oddanie"
                    if (Convert.ToInt16(ds.Tables["Zasoby"].Rows[i][0]) == id_do_zasobu)
                    {
                        ds.Tables["Zasoby"].Rows[i][7] = false;
                    }
                }
            }



            aktualizacja();




        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult odpowiedz = System.Windows.MessageBox.Show("Czy chcesz zapisać zmiany?", "Zatwierdź", System.Windows.MessageBoxButton.YesNo);

            if (odpowiedz == MessageBoxResult.Yes)
            {
                try
                {
                    zatwierdz = new SqlCommandBuilder(adap);
                    adap.Update(ds, "Wypozyczenia");                                                        //poprawić połączenie
                    zatwierdz = new SqlCommandBuilder(adap2);
                    adap2.Update(ds, "Zasoby");

                    MessageBox.Show("Zapisano w bazie!");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                MessageBox.Show("Dane nie zostały zapisane");
            }
        }
    }
}
