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

        }
    }
}
