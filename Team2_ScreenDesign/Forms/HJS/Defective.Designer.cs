namespace Team2_ScreenDesign
{
    partial class Defective
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDefective = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchCustomerContorl1 = new Team2_ScreenDesign.SearchCustomerContorl();
            this.searchCustomerContorl2 = new Team2_ScreenDesign.SearchCustomerContorl();
            this.searchCustomerContorl3 = new Team2_ScreenDesign.SearchCustomerContorl();
            this.searchCustomerContorl4 = new Team2_ScreenDesign.SearchCustomerContorl();
            this.searchCustomerContorl5 = new Team2_ScreenDesign.SearchCustomerContorl();
            this.panel1.SuspendLayout();
            this.panel_Search.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_Title.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefective)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDefective);
            this.panel1.Controls.SetChildIndex(this.panel_Title, 0);
            this.panel1.Controls.SetChildIndex(this.panel_Search, 0);
            this.panel1.Controls.SetChildIndex(this.dgvDefective, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.searchCustomerContorl5);
            this.panel5.Controls.Add(this.searchCustomerContorl2);
            this.panel5.Controls.Add(this.searchCustomerContorl3);
            this.panel5.Controls.Add(this.searchCustomerContorl4);
            this.panel5.Controls.Add(this.searchCustomerContorl1);
            // 
            // dgvDefective
            // 
            this.dgvDefective.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDefective.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dgvDefective.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDefective.Location = new System.Drawing.Point(0, 158);
            this.dgvDefective.Name = "dgvDefective";
            this.dgvDefective.Size = new System.Drawing.Size(1364, 662);
            this.dgvDefective.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "공정불량코드명";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "공장코드";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "공장명";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "공정코드";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "공정명";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "불량유형코드";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "불량유형명";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "제품코드";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "제품명";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "작업지시번호";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "생산지시번호";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "작업자";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "불량발생날짜";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "불량처리코드";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "불량조치";
            this.Column15.Name = "Column15";
            // 
            // searchCustomerContorl1
            // 
            this.searchCustomerContorl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.searchCustomerContorl1.ControlType = Team2_ScreenDesign.SearchCustomerContorl.Mode.Line;
            this.searchCustomerContorl1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchCustomerContorl1.Location = new System.Drawing.Point(12, 43);
            this.searchCustomerContorl1.Name = "searchCustomerContorl1";
            this.searchCustomerContorl1.Size = new System.Drawing.Size(261, 25);
            this.searchCustomerContorl1.TabIndex = 0;
            // 
            // searchCustomerContorl2
            // 
            this.searchCustomerContorl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.searchCustomerContorl2.ControlType = Team2_ScreenDesign.SearchCustomerContorl.Mode.Factory;
            this.searchCustomerContorl2.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchCustomerContorl2.Location = new System.Drawing.Point(12, 12);
            this.searchCustomerContorl2.Name = "searchCustomerContorl2";
            this.searchCustomerContorl2.Size = new System.Drawing.Size(250, 25);
            this.searchCustomerContorl2.TabIndex = 1;
            // 
            // searchCustomerContorl3
            // 
            this.searchCustomerContorl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.searchCustomerContorl3.ControlType = Team2_ScreenDesign.SearchCustomerContorl.Mode.Product;
            this.searchCustomerContorl3.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchCustomerContorl3.Location = new System.Drawing.Point(12, 74);
            this.searchCustomerContorl3.Name = "searchCustomerContorl3";
            this.searchCustomerContorl3.Size = new System.Drawing.Size(261, 25);
            this.searchCustomerContorl3.TabIndex = 0;
            // 
            // searchCustomerContorl4
            // 
            this.searchCustomerContorl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.searchCustomerContorl4.ControlType = Team2_ScreenDesign.SearchCustomerContorl.Mode.Defective;
            this.searchCustomerContorl4.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchCustomerContorl4.Location = new System.Drawing.Point(279, 43);
            this.searchCustomerContorl4.Name = "searchCustomerContorl4";
            this.searchCustomerContorl4.Size = new System.Drawing.Size(261, 25);
            this.searchCustomerContorl4.TabIndex = 0;
            // 
            // searchCustomerContorl5
            // 
            this.searchCustomerContorl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.searchCustomerContorl5.ControlType = Team2_ScreenDesign.SearchCustomerContorl.Mode.Worker;
            this.searchCustomerContorl5.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchCustomerContorl5.Location = new System.Drawing.Point(279, 12);
            this.searchCustomerContorl5.Name = "searchCustomerContorl5";
            this.searchCustomerContorl5.Size = new System.Drawing.Size(250, 25);
            this.searchCustomerContorl5.TabIndex = 1;
            // 
            // Defective
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(1364, 820);
            this.Name = "Defective";
            this.Text = "불량 조회";
            this.Load += new System.EventHandler(this.Defective_Load);
            this.panel1.ResumeLayout(false);
            this.panel_Search.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel_Title.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefective)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDefective;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private SearchCustomerContorl searchCustomerContorl1;
        private SearchCustomerContorl searchCustomerContorl2;
        private SearchCustomerContorl searchCustomerContorl3;
        private SearchCustomerContorl searchCustomerContorl5;
        private SearchCustomerContorl searchCustomerContorl4;
    }
}
