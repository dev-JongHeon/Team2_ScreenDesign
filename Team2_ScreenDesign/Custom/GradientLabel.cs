using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team2_ScreenDesign.Custom
{
    public partial class GradientLabel : Label
    {
        private Color cLeft;
        private Color cRight;

        // property of begin color in linear gradient
        public Color BeginColor
        {
            get
            {
                return cLeft;
            }
            set
            {
                cLeft = value;
            }
        }
        // property of end color in linear gradient
        public Color EndColor
        {
            get
            {
                return cRight;
            }
            set
            {
                cRight = value;
            }
        }
        public GradientLabel()
        {
            // Default get system color 
            cLeft = SystemColors.Control;
            cRight = SystemColors.Control;
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            // declare linear gradient brush for fill background of label
            LinearGradientBrush GBrush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(this.Width, 0), cLeft, cRight);
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            // Fill with gradient 
            e.Graphics.FillRectangle(GBrush, rect);

            // draw text on label
            SolidBrush drawBrush = new SolidBrush(this.ForeColor);
            StringFormat sf = new StringFormat();
            // align with center
            sf.Alignment = StringAlignment.Center;
            // set rectangle bound text
            RectangleF rectF = new
            RectangleF(0, this.Height / 2 - Font.Height / 2, this.Width, this.Height);
            // output string
            e.Graphics.DrawString(this.Text, this.Font, drawBrush, rectF, sf);
        }
    }
}
