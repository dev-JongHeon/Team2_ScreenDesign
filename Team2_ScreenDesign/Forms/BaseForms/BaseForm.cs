﻿using System;
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
    public partial class BaseForm : Form
    {
        private string formname;

        public string FormName
        {
            get { return lblFormName.Text; }
            set { lblFormName.Text = value; }
        }
        #region MDI를위한 것들
        private TabControl tabCtrl;
        private TabPage tabPag;
        public TabControl TabCtrl { get => tabCtrl; set => tabCtrl = value; }
        public TabPage TabPag { get => tabPag; set => tabPag = value; }

        public void Form_Activated(object sender, EventArgs e)
        {
            tabCtrl.SelectedTab = tabPag;

            if (!tabCtrl.Visible)
            {
                tabCtrl.Visible = true;
            }
        }

        public void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Destroy the corresponding Tabpage when closing MDI child form
            this.tabPag.Dispose();

            //If no Tabpage left
            if (!tabCtrl.HasChildren)
            {
                tabCtrl.Visible = false;
            }
        }
        #endregion

        public BaseForm()
        {
            InitializeComponent();
        }

        

    }
}
