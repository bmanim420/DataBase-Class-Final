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

namespace FinaleProject
{
    /// <summary>
    /// Interaction logic for model.xaml
    /// </summary>
    public partial class model : UserControl
    {
        public model()
        {
            InitializeComponent();
        }

        public static string idmodel = "";

        public string SNID
        {
            get
            {
                return SELECT.Content.ToString();
            }
            set
            {

                this.SELECT.Content = value;
            }

        }

        private void openForm_Click(object sender, RoutedEventArgs e)
        {
            
            checkFormAType checkWindow = new checkFormAType();
                checkWindow.Owner = checkFormAType.GetWindow(this);
                idmodel = SELECT.Content.ToString();
            //   MessageBox.Show(idmodel);
          
            checkWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                checkWindow.ShowDialog();
             
            }
                 
        }
    }

