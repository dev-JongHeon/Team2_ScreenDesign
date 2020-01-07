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
    public partial class SearchPeriodControl : UserControl
    {
        private string labelname;

        public string Labelname
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }


        public SearchPeriodControl()
        {
            InitializeComponent();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CalendarForm frm = new CalendarForm();
            frm.ShowDialog();
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            
            if (dtpStart.Value > dtpEnd.Value)
            {
                DateTime starttmp = dtpStart.Value;
                DateTime endtmp = dtpEnd.Value;
                dtpEnd.Value = starttmp;
                dtpStart.Value = endtmp;
            }
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {

            if (dtpStart.Value > dtpEnd.Value)
            {
                DateTime temp = dtpEnd.Value;
                dtpEnd.Value = dtpStart.Value;
                dtpStart.Value = temp;
            }
        }
    }
}
