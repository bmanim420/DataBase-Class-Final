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
    /// Interaction logic for modelB.xaml
    /// </summary>
    public partial class modelB : UserControl
    {
        public modelB()
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

        private void openFormB(object sender, RoutedEventArgs e)
        {
            checkFormBType checkWindow = new checkFormBType();
            checkWindow.Owner = checkFormBType.GetWindow(this);
            idmodel = SELECT.Content.ToString();
            MessageBox.Show(idmodel);
            checkWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            checkWindow.ShowDialog();
        }
    }
}
