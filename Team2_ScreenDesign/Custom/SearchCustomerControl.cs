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
    public partial class SearchCustomerContorl : SearchUserControl
    {
        public enum Mode { Worker, Defective, Product, Downtime, Factory, Line, Meterial, SemiProduct };

        Mode Modes = Mode.Worker;

        public Mode ControlType
        {
            get { return Modes; }
            set
            {
                Modes = value;

                switch (Modes)
                {
                    case Mode.Worker:
                        this.CodeLabel.Text = "작업자 코드";
                        break;
                    case Mode.Defective:
                        this.CodeLabel.Text = "불량유형 코드";
                        break;
                    case Mode.Product:
                        this.CodeLabel.Text = "제품 코드";
                        break;
                    case Mode.Meterial:
                        this.CodeLabel.Text = "원자재 코드";
                        break;
                    case Mode.SemiProduct:
                        this.CodeLabel.Text = "반제품 코드";
                        break;
                    case Mode.Downtime:
                        this.CodeLabel.Text = "비가동유형 코드";
                        break;
                    case Mode.Factory:
                        this.CodeLabel.Text = "공장 코드";
                        break;
                    case Mode.Line:
                        this.CodeLabel.Text = "공정 코드";
                        break;
                }
            }
        }

        public SearchCustomerContorl()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            // 원하는 폼 띄우기
            SearchForm search = new SearchForm();
            search.Mode = this.Modes;
            search.ShowDialog();
        }
    }
}
