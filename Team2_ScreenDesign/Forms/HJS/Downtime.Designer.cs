namespace Team2_ScreenDesign.Forms.HJS
{
    partial class Downtime
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
            this.dgvDowntime = new System.Windows.Forms.DataGridView();
            this.searchCustomerContorl1 = new Team2_ScreenDesign.SearchCustomerContorl();
            this.searchCustomerContorl2 = new Team2_ScreenDesign.SearchCustomerContorl();
            this.searchCustomerContorl3 = new Team2_ScreenDesign.SearchCustomerContorl();
            this.searchCustomerContorl4 = new Team2_ScreenDesign.SearchCustomerContorl();
            this.panel1.SuspendLayout();
            this.panel_Search.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_Title.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDowntime)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDowntime);
            this.panel1.Controls.SetChildIndex(this.panel_Title, 0);
            this.panel1.Controls.SetChildIndex(this.panel_Search, 0);
            this.panel1.Controls.SetChildIndex(this.dgvDowntime, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.searchCustomerContorl3);
            this.panel5.Controls.Add(this.searchCustomerContorl4);
            this.panel5.Controls.Add(this.searchCustomerContorl2);
            this.panel5.Controls.Add(this.searchCustomerContorl1);
            // 
            // dgvDowntime
            // 
            this.dgvDowntime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDowntime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDowntime.Location = new System.Drawing.Point(0, 158);
            this.dgvDowntime.Name = "dgvDowntime";
            this.dgvDowntime.RowTemplate.Height = 23;
            this.dgvDowntime.Size = new System.Drawing.Size(1364, 662);
            this.dgvDowntime.TabIndex = 7;
            // 
            // searchCustomerContorl1
            // 
            this.searchCustomerContorl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.searchCustomerContorl1.ControlType = Team2_ScreenDesign.SearchCustomerContorl.Mode.Downtime;
            this.searchCustomerContorl1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchCustomerContorl1.Location = new System.Drawing.Point(12, 77);
            this.searchCustomerContorl1.Name = "searchCustomerContorl1";
            this.searchCustomerContorl1.Size = new System.Drawing.Size(250, 25);
            this.searchCustomerContorl1.TabIndex = 0;
            // 
            // searchCustomerContorl2
            // 
            this.searchCustomerContorl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.searchCustomerContorl2.ControlType = Team2_ScreenDesign.SearchCustomerContorl.Mode.Factory;
            this.searchCustomerContorl2.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchCustomerContorl2.Location = new System.Drawing.Point(280, 45);
            this.searchCustomerContorl2.Name = "searchCustomerContorl2";
            this.searchCustomerContorl2.Size = new System.Drawing.Size(250, 25);
            this.searchCustomerContorl2.TabIndex = 0;
            // 
            // searchCustomerContorl3
            // 
            this.searchCustomerContorl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.searchCustomerContorl3.ControlType = Team2_ScreenDesign.SearchCustomerContorl.Mode.Worker;
            this.searchCustomerContorl3.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchCustomerContorl3.Location = new System.Drawing.Point(280, 14);
            this.searchCustomerContorl3.Name = "searchCustomerContorl3";
            this.searchCustomerContorl3.Size = new System.Drawing.Size(250, 25);
            this.searchCustomerContorl3.TabIndex = 0;
            // 
            // searchCustomerContorl4
            // 
            this.searchCustomerContorl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.searchCustomerContorl4.ControlType = Team2_ScreenDesign.SearchCustomerContorl.Mode.Line;
            this.searchCustomerContorl4.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchCustomerContorl4.Location = new System.Drawing.Point(280, 76);
            this.searchCustomerContorl4.Name = "searchCustomerContorl4";
            this.searchCustomerContorl4.Size = new System.Drawing.Size(250, 25);
            this.searchCustomerContorl4.TabIndex = 0;
            // 
            // Downtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(1364, 820);
            this.Name = "Downtime";
            this.Text = "비가동 조회";
            this.panel1.ResumeLayout(false);
            this.panel_Search.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel_Title.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDowntime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDowntime;
        private SearchCustomerContorl searchCustomerContorl1;
        private SearchCustomerContorl searchCustomerContorl3;
        private SearchCustomerContorl searchCustomerContorl2;
        private SearchCustomerContorl searchCustomerContorl4;
    }
}
