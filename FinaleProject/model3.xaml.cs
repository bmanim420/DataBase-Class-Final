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
    /// Interaction logic for model3.xaml
    /// </summary>
    public partial class model3 : UserControl
    {
        public model3()
        {
            InitializeComponent();
        }
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

        private void notify(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("user notified ");
        }
    }
}
