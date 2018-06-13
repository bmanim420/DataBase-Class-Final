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
    /// Interaction logic for applicationIDModel.xaml
    /// </summary>
    public partial class applicationIDModel : UserControl
    {
        public applicationIDModel()
        {
            InitializeComponent();
        }

        public string idSet
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


        private void SELECT_Click_1(object sender, RoutedEventArgs e)
        {
            checkFormAType cFAT = new checkFormAType();
            cFAT.ShowDialog();
        }
    }
}
