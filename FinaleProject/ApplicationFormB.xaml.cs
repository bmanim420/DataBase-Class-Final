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
    /// Interaction logic for ApplicationFormB.xaml
    /// </summary>
    public partial class ApplicationFormB : Window
    {
        public ApplicationFormB()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("server=localhost; username=root; password=; database=loan");
        private void close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SubmitB_Click(object sender, RoutedEventArgs e)
        {
            if (DisName.Text == "" || Email.Text == "" || Address.Text == "" || Phone.Text == ""|| LicenseNo.Text == "")
            {
                MessageBox.Show("Invalid Input");
            }
            else
            {
                connection.Open();
                // string fn= FullName.Text;
                // string email;


                string qry = "INSERT INTO app_b(disName, email, address, phone, license) VALUES ('" + DisName.Text + "','" + Email.Text + "','" + Address.Text + "','" + Phone.Text + "','" + LicenseNo.Text + "');";
                MySqlCommand cmd = new MySqlCommand(qry, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Application Submitted");
                this.Close();
            }
        }

        private void minimize(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
