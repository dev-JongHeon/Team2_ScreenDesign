using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2_ScreenDesign.Forms;
using System.Globalization;

namespace Team2_ScreenDesign
{
    public partial class SearchControl : UserControl
    {
        private string labelname;

        public string Labelname
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }


        public SearchControl()
        {
            InitializeComponent();
            
        }
    }
}
