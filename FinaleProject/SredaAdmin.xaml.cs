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
using MySql.Data.MySqlClient;
namespace FinaleProject
{
    /// <summary>
    /// Interaction logic for SredaAdmin.xaml
    /// </summary>
    public partial class SredaAdmin : Window
    {
        public SredaAdmin()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("server=localhost; username=root; password=; database=loan");
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (g.ColumnDefinitions[0].Width.Value < 150)
            {
                g.ColumnDefinitions[0].Width = new GridLength(200);
            }
            else if (g.ColumnDefinitions[0].Width.Value >= 150)
            {
                g.ColumnDefinitions[0].Width = new GridLength();
            }
        }

        private void close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void minimize(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Activated(object sender, EventArgs e)
        {

            A.Children.Clear();

            connection.Open();
            string qry = "SELECT SNID FROM sreda_app_a";
            MySqlCommand cmd = new MySqlCommand(qry, connection);
            cmd.ExecuteNonQuery();
            MySqlDataReader mdr;
            mdr = cmd.ExecuteReader();
            while (mdr.Read())
            {

                string ID = mdr.GetString("SNID");
                model bmodel = new model();
                A.Children.Add(bmodel);
                bmodel.SNID = ID;
            }
            connection.Close();

            /////////////////////////////////////////////


            B.Children.Clear();

            connection.Open();
            string qryB = "SELECT SNID FROM sreda_app_b";
            MySqlCommand cmdB = new MySqlCommand(qryB, connection);
            cmdB.ExecuteNonQuery();
            MySqlDataReader mdrB;
            mdrB = cmdB.ExecuteReader();
            while (mdrB.Read())
            {

                string ID = mdrB.GetString("SNID");

                model2 bmodel = new model2();
                B.Children.Add(bmodel);
                bmodel.SNID = ID;
            }
            connection.Close();




        }
    }
}
