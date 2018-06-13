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
    /// Interaction logic for checkFormBType.xaml
    /// </summary>
    public partial class checkFormBType : Window
    {
        public checkFormBType()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("server=localhost; username=root; password=; database=loan");

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string searchID = model2.idmodel;



            connection.Open();

            if (MainWindow.isIFI)
            {
                string qry = "SELECT * FROM app_b WHERE SNID = '" + searchID + "'";
                MySqlCommand cmd = new MySqlCommand(qry, connection);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Clear();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                
                da.Fill(dt);
                dataGridB.ItemsSource = dt.AsDataView();


                connection.Close();
            }
            else
            {
                string qry = "SELECT * FROM sreda_app_b WHERE SNID = '" + searchID + "'";
                MySqlCommand cmd = new MySqlCommand(qry, connection);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Clear();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();       
                da.Fill(dt);
                dataGridB.ItemsSource = dt.AsDataView();


                connection.Close();
            }
           
           
        }

        private void close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void minimize(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            checkFormBType chckFrm = new checkFormBType();
            chckFrm.Owner = this;
        }

        private void reject_Click(object sender, RoutedEventArgs e)
        {
            /*
            connection.Open();
            string qry1 = "DELETE FROM app_b WHERE SNID = '" + model2.idmodel + "'";
            MySqlCommand cmd1 = new MySqlCommand(qry1, connection);
            cmd1.ExecuteNonQuery();
            connection.Close();
            */

            if (MainWindow.isIFI)
            {
                connection.Open();
                string qry1 = "DELETE FROM app_b WHERE SNID = '" + model2.idmodel + "'";
                MySqlCommand cmd1 = new MySqlCommand(qry1, connection);
                cmd1.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                connection.Open();
                string qry1 = "DELETE FROM sreda_app_b WHERE SNID = '" + model2.idmodel + "'";
                MySqlCommand cmd1 = new MySqlCommand(qry1, connection);
                cmd1.ExecuteNonQuery();
                connection.Close();

            }




        }

        private void accept_Click(object sender, RoutedEventArgs e)
        {
           /* connection.Open();

            string qry1 = "INSERT INTO sreda_app_b SELECT* FROM app_b WHERE SNID = '" + model2.idmodel + "'";

            MySqlCommand cmd = new MySqlCommand(qry1, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Data Save TO SREDA!");



            connection.Open();
            string qryt = "DELETE FROM app_b WHERE SNID = '" + model2.idmodel + "'";
            MySqlCommand cmdt = new MySqlCommand(qryt, connection);
            cmdt.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Data Deleted!");
            */

            connection.Open();
            if (MainWindow.isIFI)
            {
                string qry1 = "INSERT INTO sreda_app_b SELECT* FROM app_b WHERE SNID = '" + model2.idmodel + "'";

                MySqlCommand cmd = new MySqlCommand(qry1, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data Save TO SREDA!");



                connection.Open();
                string qryt = "DELETE FROM app_b WHERE SNID = '" + model2.idmodel + "'";
                MySqlCommand cmdt = new MySqlCommand(qryt, connection);
                cmdt.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data Deleted!");
            }
            else
            {
               

                string qryb = "INSERT INTO sreda_selectedb SELECT* FROM sreda_app_b WHERE SNID = '" + model2.idmodel + "'";

                MySqlCommand cmdb = new MySqlCommand(qryb, connection);
                cmdb.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data Save TO SREDA selected!");



                connection.Open();
                string qryt = "DELETE FROM sreda_app_b WHERE SNID = '" + model2.idmodel + "'";
                MySqlCommand cmdt = new MySqlCommand(qryt, connection);
                cmdt.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data Deleted from sreda_app!");


            }



        }
    }
}
