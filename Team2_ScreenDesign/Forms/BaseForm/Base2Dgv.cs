using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team2_ScreenDesign
{
    public partial class Base2Dgv : Form
    {
        private string formname;

        public string FormName
        {
            get { return lblFormName.Text; }
            set { lblFormName.Text = value; }
        }

        public Base2Dgv()
        {
            InitializeComponent();
        }
        
    }
}
