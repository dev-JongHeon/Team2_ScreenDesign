using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KJH_Project_ScreenDesign
{
    public partial class KJHMenuControl : UserControl
    {
        private Color border_color;
        bool isClicked = false;
        public KJHMenuControl()
        {
            InitializeComponent();
        }

        public Color Border_color { set => border_color = value; }
        public void SetBorderColor()
        {
            panel_Menu.BackColor = border_color;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (!isClicked)
            {
                panel_Menu.BackColor = Color.Blue;
                isClicked = true;
            }
            else
            {
                panel_Menu.BackColor = Color.Transparent;
                isClicked = false;
            }

        }

    } 
}
