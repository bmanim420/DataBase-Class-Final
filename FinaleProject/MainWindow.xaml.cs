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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace FinaleProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MySqlConnection connection = new MySqlConnection("server=localhost; username=root; password=; database=loan");
        public MainWindow()
        {
            InitializeComponent();
        }

        static public bool isIFI=true;
    /// Signup sign in tab swaping functions 
    
            
        private void signin_Click(object sender, RoutedEventArgs e)
        {
            this.GridSignUP.Visibility = Visibility.Hidden;
            this.GridSignIn.Visibility = Visibility.Visible;
        }


        private void signUp1_Click(object sender, RoutedEventArgs e)
        {
           this.GridSignIn.Visibility = Visibility.Hidden;
            this.GridSignUP.Visibility = Visibility.Visible;
        }

        private void signUp_Click(object sender, RoutedEventArgs e)
        {
            this.GridSignIn.Visibility = Visibility.Hidden;
            this.GridSignUP.Visibility = Visibility.Visible;
        }

 
    /// Signup sign in tab swaping functions 

    /// textbox---placeholder functions


        private void username_Enter(object sender, MouseEventArgs e)
        {
           
            if (text_username.Text =="_someone@email.com" )
            {
                text_username.Text = "";
            }
        }

        private void username_Leave(object sender, MouseEventArgs e)
        {
            if (text_username.Text == "" && !text_username.IsSelectionActive)
            {
                text_username.Text = "_someone@email.com";

            }
        }

        private void password_Enter(object sender, MouseEventArgs e)
        {
          if(text_password.Password == "password")
            {
                text_password.Password = "";
            }
        }

        private void password_Leave(object sender, MouseEventArgs e)
        {
            if (text_password.Password == "" && !text_password.IsSelectionActive)
            {
                text_password.Password = "password";

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////////////////
          

            connection.Open();

           
            bool isSreda = true ;
            int records = 0;
            string querySreda = "SELECT * FROM sreda_user WHERE email='" + text_username.Text + "' AND pass='" + text_password.Password + "'";
            string queryIFI = "SELECT * FROM ifi_user WHERE email='" + text_username.Text + "' AND password='" + text_password.Password + "'";

            MySqlCommand cmd1 = new MySqlCommand(querySreda, connection);
            MySqlCommand cmd2 = new MySqlCommand(queryIFI, connection);

            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
            MySqlDataAdapter db = new MySqlDataAdapter(cmd2);
            da.Fill(dt);
            records = Convert.ToInt32(dt.Rows.Count.ToString());
            if(records == 0)
            {
                isSreda = false;
               
            }
            db.Fill(dt);
            records = Convert.ToInt32(dt.Rows.Count.ToString());
            connection.Close();

            //MessageBox.Show(records.ToString());
            if (records == 0)
            {
                MessageBox.Show("Mismatch");

            }
            else
            {
                if (isSreda)
                {
                    isIFI = false;
                    double width = this.Width;
                    double height = this.Height;

                    SredaAdmin sre_window = new SredaAdmin();
                    sre_window.Owner = this;
                    sre_window.Width = width;
                    sre_window.Height = height;

                    sre_window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                    MessageBox.Show("sreda");
                    sre_window.ShowDialog();

                  
                    
                }
                else
                {
                    
                    double width = this.Width;
                    double height = this.Height;

                    IfiAdmin ifi_window = new IfiAdmin();
                    ifi_window.Owner = this;
                    ifi_window.Width = width;
                    ifi_window.Height = height;

                    ifi_window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                    isIFI = true;
                    MessageBox.Show("ifi");
                    ifi_window.ShowDialog();

                    ///////////////////////////////////////////////////////////////////////////////////////
                }
            }
        }

        private void close(object sender, RoutedEventArgs e)
        {
            
                Application.Current.Shutdown();
            
        }

        private void minimize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

 

        private void About_MouseEnter(object sender, MouseEventArgs e)
        {
            aSelected.Visibility = Visibility.Visible;
            ASelected.Visibility = Visibility.Hidden;
            BSelected.Visibility = Visibility.Hidden;
            about.Visibility = Visibility.Visible;
            typeA.Visibility = Visibility.Hidden;
            typeB.Visibility = Visibility.Hidden;
            apply_A.Visibility = Visibility.Hidden;
            apply_B.Visibility = Visibility.Hidden;
        }

        private void LoneType_A_MouseEnter(object sender, MouseEventArgs e)
        {
            aSelected.Visibility = Visibility.Hidden;
            ASelected.Visibility = Visibility.Visible;
            BSelected.Visibility = Visibility.Hidden;
            about.Visibility = Visibility.Hidden;
            typeA.Visibility = Visibility.Visible;
            typeB.Visibility = Visibility.Hidden;
            apply_A.Visibility = Visibility.Visible;
            apply_B.Visibility = Visibility.Hidden;
        }

        private void LoneType_B_MouseEnter(object sender, MouseEventArgs e)
        {
            aSelected.Visibility = Visibility.Hidden;
            ASelected.Visibility = Visibility.Hidden;
            BSelected.Visibility = Visibility.Visible;
            about.Visibility = Visibility.Hidden;
            typeA.Visibility = Visibility.Hidden;
            typeB.Visibility = Visibility.Visible;
            apply_A.Visibility = Visibility.Hidden;
            apply_B.Visibility = Visibility.Visible;
        }

        private void apply_A_Click(object sender, RoutedEventArgs e)
        {
            double width = this.Width;
            double height = this.Height;
          //  MainWindow mw = new MainWindow();
            ApplicationFormA FormA_window = new ApplicationFormA();
       
            FormA_window.Width = width/2;
           

            FormA_window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            FormA_window.ShowDialog();

        }

        private void apply_B_Click(object sender, RoutedEventArgs e)
        {
            double width = this.Width;
            double height = this.Height;
            //  MainWindow mw = new MainWindow();
            ApplicationFormB FormB_window = new ApplicationFormB();

            FormB_window.Width = width / 2;


            FormB_window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            FormB_window.ShowDialog();
        }

        private void maximize(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else if (this.WindowState == WindowState.Minimized)
            {
                this.WindowState = WindowState.Normal;
            }
            else 
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void signUP(object sender, RoutedEventArgs e)
        {
            string SEL = combo.Text;

            if (SEL == "IFI")
            {
                connection.Open();
                string QRY = "INSERT INTO ifi_user(email,password) VALUES('"+email.Text+"','"+password.Text+ "');";

                MySqlCommand cmd = new MySqlCommand(QRY, connection);
                cmd.ExecuteNonQuery();
                connection.Close();

            }else if(SEL == "SREDA")
            {
                connection.Open();
                string QRY = "INSERT INTO sreda_user(email,pass) VALUES('" + email.Text + "','" + password.Text + "');";

                MySqlCommand cmd = new MySqlCommand(QRY, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            if (combo.Text == null)
            {
                MessageBox.Show("select One");
            }
        }
    }

}
