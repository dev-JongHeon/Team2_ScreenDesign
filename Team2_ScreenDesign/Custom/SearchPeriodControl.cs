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

namespace Team2_ScreenDesign
{
    public partial class SearchPeriodControl : UserControl
    {
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
                DateTime temp = dtpStart.Value;
                dtpStart.Value = dtpEnd.Value;
                dtpEnd.Value = temp;
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
