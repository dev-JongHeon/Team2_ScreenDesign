using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team2_ScreenDesign.Forms
{
    public partial class CalendarForm : Form
    {
        public CalendarForm()
        {
            InitializeComponent();
        }

        private void StartCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            StartCalendar.SelectionStart = e.Start;
            dtpStart.Value = e.Start;
        }

        private void EndCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            EndCalendar.SelectionStart = e.Start;
            dtpEnd.Value = e.Start;
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
