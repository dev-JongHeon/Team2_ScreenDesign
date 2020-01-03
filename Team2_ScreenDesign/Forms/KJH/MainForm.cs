using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2_ScreenDesign.Properties;


namespace Team2_ScreenDesign
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void splitter1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_Menu.Visible = !panel_Menu.Visible;
            if (panel_Menu.Visible)
            {
                button1.Location = new Point(splitter1.Location.X, button1.Location.Y);
                button1.Image = Resources.left_arrow__2_;
            }
            else
            {
                button1.Image = Resources.right_arrow;
                button1.Location = new Point(0, button1.Location.Y);
            }

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            button1.Location = new Point(splitter1.Location.X, button1.Location.Y);
        }

        private void toolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = this.BackColor;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (Panel p in mpanel.Controls)
            {
                if (p.Tag.ToString() != string.Empty)
                {
                    p.Visible = false;
                }
            }

        }

        private void 새로고침ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            string tag = lbl.Tag.ToString();
            string ptag = string.Empty;
            string lname = string.Empty;
            switch (tag)
            {
                case "system":
                    ptag = "panel_System";
                    lname = "lblSystem";
                    break;
                case "process":
                    ptag = "panel_Process";
                    lname = "lblProcess";
                    break;
                case "production":
                    ptag = "panel_Production";
                    lname = "lblProduction";
                    break;
                case "stock":
                    ptag = "panel_Stock";
                    lname = "lblStock";
                    break;
                case "sales":
                    ptag = "panel_Sales";
                    lname = "lblSales";
                    break;
                case "info":
                    ptag = "panel_Info";
                    lname = "lblInfo";
                    break;
                default:
                    break;
            }
            SelectMenu(ptag, lname);
            //FillMenu();

        }

        private void SelectMenu(string ptag, string lname)
        {
            foreach (var item in mpanel.Controls)
            {
                if (item is Panel)
                {
                    Panel tmp = (Panel)item;
                    if (tmp.Tag.ToString() != string.Empty && tmp.Tag.ToString() == ptag)
                    {
                        tmp.Visible = true;

                    }
                    else if (tmp.Tag.ToString() == string.Empty)
                    {
                        tmp.Visible = true;
                        foreach (var pa in tmp.Controls)
                        {
                            if (pa is Panel)
                            {
                                Panel p = (Panel)pa;
                                if (p.Tag.ToString() == "labelpanel")
                                {
                                    foreach (var la in p.Controls)
                                    {
                                        if (la is Label)
                                        {
                                            Label l = (Label)la;
                                            if (l.Name == lname)
                                            {
                                                l.Image = Resources.down_16x16;
                                            }
                                            else
                                            {
                                                l.Image = Resources.Prev_16x16;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        tmp.Visible = false;
                    }
                }
            }
        }

        public void FillMenu()
        {
            foreach(var item in mpanel.Controls)
            {
                if(item is Panel)
                {
                    Panel tmp = (Panel)item;
                    if (tmp.Tag.ToString() != string.Empty && tmp.Visible)
                    {
                        tmp.Dock = DockStyle.Fill;
                    }
                }
            }
        }
    }
}
