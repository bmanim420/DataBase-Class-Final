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
    /// Interaction logic for IfiAdmin.xaml
    /// </summary>
    public partial class IfiAdmin : Window
    {
        MySqlConnection connection = new MySqlConnection("server=localhost; username=root; password=; database=loan");
        public IfiAdmin()
        {
            InitializeComponent();
            
        }

        static public string Check="";

        private void expand(object sender, RoutedEventArgs e)
        {
            GridLength g = new GridLength(80, GridUnitType.Pixel);

        }

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
           /* connection.Open();
            
            string qrT = "TRUNCATE temp_app_a";
            MySqlCommand cmdT = new MySqlCommand(qrT, connection);
            cmdT.ExecuteNonQuery();

            connection.Close();

            connection.Open();
           
            string qrd = "INSERT INTO temp_app_a(SNID) SELECT (SNID) FROM app_a";
            MySqlCommand cmdd = new MySqlCommand(qrd, connection);
            cmdd.ExecuteNonQuery();

            connection.Close();
            */
        }

        private void Window_Activated(object sender, EventArgs e)
        {

            A.Children.Clear();
          
            connection.Open();
            string qry = "SELECT SNID FROM app_a";
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


            ///////////////////////////for b type lone ///////////////////////////
            

            B.Children.Clear();
          
            connection.Open();
            string qryB = "SELECT SNID FROM app_b";
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

            /////////////////////////////////////for c /////////////////////////////

            C.Children.Clear();

            connection.Open();
            string qryc = "SELECT SNID FROM sreda_selecteda";
            MySqlCommand cmdc = new MySqlCommand(qryc, connection);
            cmdc.ExecuteNonQuery();
            MySqlDataReader mdrc;
            mdrc = cmdc.ExecuteReader();
            while (mdrc.Read())
            {

                string ID = mdrc.GetString("SNID");

                model3 bmodel = new model3();
                C.Children.Add(bmodel);
                bmodel.SNID = ID;
            }
            connection.Close();
            connection.Open();
            string qrycb = "SELECT SNID FROM sreda_selectedb";
            MySqlCommand cmdcb = new MySqlCommand(qrycb, connection);
            cmdcb.ExecuteNonQuery();
            MySqlDataReader mdrcb;
            mdrcb = cmdcb.ExecuteReader();
            while (mdrcb.Read())
            {

                string ID = mdrcb.GetString("SNID");

                model3 bmodel = new model3();
                C.Children.Add(bmodel);
                bmodel.SNID = ID;
            }
            connection.Close();






        }
    }

    }

