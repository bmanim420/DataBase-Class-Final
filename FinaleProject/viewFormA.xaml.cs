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
    /// Interaction logic for viewFormA.xaml
    /// </summary>
    public partial class viewFormA : UserControl
    {
        public viewFormA()
        {
            InitializeComponent();
        }

        public string FullNameSet
        {
            get
            {
                return fullname.Text.ToString();
            }
            set
            {
                this.fullname.Text = value;
            }

        }


        public string emailSet
        {
            get
            {
                return email.Text.ToString();
            }
            set
            {
                this.email.Text = value;
            }

        }

        public string AgeSet
        {
            get
            {
                return age.Text.ToString();
            }
            set
            {
                this.age.Text = value;
            }

        }



        public string NIDSet
        {
            get
            {
                return NID.Text.ToString();
            }
            set
            {
                this.NID.Text = value;
            }

        }



        public string ProfessionSet
        {
            get
            {
                return profession.Text.ToString();
            }
            set
            {
                this.profession.Text = value;
            }

        }


        public string phoneSet
        {
            get
            {
                return phone.Text.ToString();
            }
            set
            {
                this.phone.Text = value;
            }

        }

        public string AddressSet
        {
            get
            {
                return address.Text.ToString();
            }
            set
            {
                this.address.Text = value;
            }

        }


        public string fatherNameSet
        {
            get
            {
                return fullname.Text.ToString();
            }
            set
            {
                this.fathername.Text = value;
            }

        }


        public string motherNameSet
        {
            get
            {
                return mothername.Text.ToString();
            }
            set
            {
                this.mothername.Text = value;
            }

        }


    }
}
