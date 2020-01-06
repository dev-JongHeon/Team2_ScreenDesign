using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team2_ScreenDesign
{
    public partial class SearchUserControl : UserControl
    {
        public TextBox CodeTextBox 
        {
            get { return txtCode; }
            set { txtCode = value; }
        }

        public Label CodeLabel
        {
            get { return lblName; }
            set { lblName = value; }
        }

        public Button CodeButton
        {
            get { return btnSearch; }
            set { btnSearch = value; }
        }


        public SearchUserControl()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
