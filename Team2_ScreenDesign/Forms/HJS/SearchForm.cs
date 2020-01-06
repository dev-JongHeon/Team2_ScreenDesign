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
    public partial class SearchForm : Form
    {
        public SearchCustomerContorl.Mode Mode { get; set; }
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            SettingData();
        }

        private void SettingData()
        {
            // Mode값에 따라 그리드뷰 컬럼명 및 검색 결과 
        }
    }
}
