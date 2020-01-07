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

        public string labelName
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

        private void TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void mtxtEnd_Validating(object sender, CancelEventArgs e)
        {

        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
