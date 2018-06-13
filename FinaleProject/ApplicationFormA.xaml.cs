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
    /// Interaction logic for ApplicationFormA.xaml
    /// </summary>
    public partial class ApplicationFormA : Window
    {
        MySqlConnection connection = new MySqlConnection("server=localhost; username=root; password=; database=loan");
        public ApplicationFormA()
        {
            InitializeComponent();
        }

        private void close(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void minimize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }



        private void SubmitA_Click(object sender, RoutedEventArgs e)
        {
            if (FullName.Text==""|| Email.Text==""|| Address.Text==""|| Age.Text==""|| NID.Text==""|| Profession.Text==""|| Phone.Text==""|| FatherName.Text==""|| MotherName.Text=="")
            {
                MessageBox.Show("Invalid Input");
            }
            else {
                connection.Open();
                

                string qry = "INSERT INTO app_a(fullName,email,address,age,NID,profession,phone,fatherName,motherName) VALUES  ('" + FullName.Text + "','" + Email.Text + "','" + Address.Text + "','" + Age.Text + "','" + NID.Text + "','" + Profession.Text + "','" + Phone.Text + "','" + FatherName.Text + "','" + MotherName.Text + "');";
                MySqlCommand cmd = new MySqlCommand(qry, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Application Submitted");
                this.Close();
            }
        }
    }
}
