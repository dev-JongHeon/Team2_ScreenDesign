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

            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
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
            FillMenu();
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
                        tmp.Height = 100;
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
                        tmp.Height = 0;
                        tmp.Visible = false;
                    }
                }
            }
        }

        public void FillMenu()
        {
            int sumheight = 0;
            foreach (var item in mpanel.Controls)
            {
                if (item is Panel)
                {
                    Panel tmp = (Panel)item;
                    if (tmp.Tag.ToString() == string.Empty)
                    {
                        sumheight += tmp.Height;
                    }
                }
            }
            foreach (var item in mpanel.Controls)
            {
                if(item is Panel)
                {
                    Panel tmp = (Panel)item;
                    if (tmp.Tag.ToString() != string.Empty && tmp.Visible)
                    {
                        tmp.Height = mpanel.Height - sumheight;
                    }
                }
            }
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            SolidBrush sb2 = new SolidBrush(Color.FromArgb(42, 76, 105));
            Graphics g = e.Graphics;
            TabPage tp = tabControl1.TabPages[e.Index];
            
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;  //optional

            // This is the rectangle to draw "over" the tabpage title
            RectangleF headerRect = new RectangleF(e.Bounds.X, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height - 2);

            // This is the default colour to use for the non-selected tabs
            SolidBrush sb = new SolidBrush(Color.FromArgb(42,76,105));
            SolidBrush co = new SolidBrush(Color.White);
            // This changes the colour if we're trying to draw the selected tabpage
            if (tabControl1.SelectedIndex == e.Index)
            {
                sb.Color = Color.FromArgb(225, 225, 225);
                co.Color = Color.Blue;
            }
            // Colour the header of the current tabpage based on what we did above
            g.FillRectangle(sb, e.Bounds);

            //Remember to redraw the text - I'm always using black for title text
            g.DrawString(tp.Text, new Font(tabControl1.Font,FontStyle.Bold), co, headerRect, sf);

            SolidBrush fillbrush = new SolidBrush(Color.FromArgb(42, 76, 105));
            Rectangle lasttabrect = tabControl1.GetTabRect(tabControl1.TabPages.Count - 1);
            Rectangle background = new Rectangle();
            background.Location = new Point(lasttabrect.Right+10, 0);

            //pad the rectangle to cover the 1 pixel line between the top of the tabpage and the start of the tabs
            background.Size = new Size(tabControl1.Right - background.Left, lasttabrect.Height + 1);
            e.Graphics.FillRectangle(fillbrush, background);
        }

        private void 새로고침ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TabPage tb = new TabPage();
            tb.Text = "생산관리";
            tb.Parent = tabControl1;
            tb.Show();
            
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            FillMenu();
        }
    }
}
