using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
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
    /// Interaction logic for checkFormAType.xaml
    /// </summary>
    public partial class checkFormAType : Window
    {
        public checkFormAType()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("server=localhost; username=root; password=; database=loan");
        private void close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void minimize(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            checkFormAType chckFrm = new checkFormAType();
            chckFrm.Owner = this;
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string searchID = model.idmodel;



            connection.Open();

            if (MainWindow.isIFI)
            {
                string qry = "SELECT * FROM app_a WHERE SNID = '" + searchID + "'";
                MySqlCommand cmd = new MySqlCommand(qry, connection);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Clear();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();

                da.Fill(dt);
                dataGrid.ItemsSource = dt.AsDataView();


                connection.Close();
            }
            else
            {
                string qry = "SELECT * FROM sreda_app_a WHERE SNID = '" + searchID + "'";
                MySqlCommand cmd = new MySqlCommand(qry, connection);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Clear();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                da.Fill(dt);
                dataGrid.ItemsSource = dt.AsDataView();


                connection.Close();
            }




            /*
            string searchID = model.idmodel;



            connection.Open();
            string qry = "SELECT * FROM app_a WHERE SNID = '" + searchID + "'";
            MySqlCommand cmd = new MySqlCommand(qry, connection);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGrid.ItemsSource = dt.AsDataView();


            connection.Close(); */
        }

        private void accept_Click(object sender, RoutedEventArgs e)
        {

            connection.Open();
            if (MainWindow.isIFI)
            {
                string qry1 = "INSERT INTO sreda_app_a SELECT* FROM app_a WHERE SNID = '" + model.idmodel + "'";

                MySqlCommand cmd = new MySqlCommand(qry1, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data Save TO SREDA!");



                connection.Open();
                string qryt = "DELETE FROM app_a WHERE SNID = '" + model.idmodel + "'";
                MySqlCommand cmdt = new MySqlCommand(qryt, connection);
                cmdt.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data Deleted!");
            }
            else
            {
                

                string qry1 = "INSERT INTO sreda_selecteda SELECT* FROM sreda_app_a WHERE SNID = '" + model.idmodel + "'";

                MySqlCommand cmd = new MySqlCommand(qry1, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data Save TO SREDA selected!");



                connection.Open();
                string qryt = "DELETE FROM sreda_app_a WHERE SNID = '" + model.idmodel + "'";
                MySqlCommand cmdt = new MySqlCommand(qryt, connection);
                cmdt.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data Deleted from sreda_app!");


            }
        }
    


        private void reject_Click( object sender, RoutedEventArgs e )
        {
            if (MainWindow.isIFI)
            {
                connection.Open();
                string qry1 = "DELETE FROM app_a WHERE SNID = '" + model.idmodel + "'";
                MySqlCommand cmd1 = new MySqlCommand(qry1, connection);
                cmd1.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                connection.Open();
                string qry1 = "DELETE FROM sreda_app_a WHERE SNID = '" + model.idmodel + "'";
                MySqlCommand cmd1 = new MySqlCommand(qry1, connection);
                cmd1.ExecuteNonQuery();
                connection.Close();

            }
      
            
        }
    }
}
