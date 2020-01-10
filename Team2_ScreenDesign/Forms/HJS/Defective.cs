using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team2_ScreenDesign
{
    public partial class Defective : BaseForm
    {
        public Defective()
        {
            InitializeComponent();
        }

        private void Defective_Load(object sender, EventArgs e)
        {
            SettingData();
        }

        private void SettingData()
        {
            //this.lblFormName.Text = "불량유형";        
            
        }

    }
}
