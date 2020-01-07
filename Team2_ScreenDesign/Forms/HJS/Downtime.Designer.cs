﻿namespace Team2_ScreenDesign.Forms.HJS
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
            this.searchPeriodControl1 = new Team2_ScreenDesign.SearchPeriodControl();
            this.searchUserControl5 = new Team2_ScreenDesign.SearchUserControl();
            this.searchUserControl1 = new Team2_ScreenDesign.SearchUserControl();
            this.searchUserControl4 = new Team2_ScreenDesign.SearchUserControl();
            this.searchUserControl2 = new Team2_ScreenDesign.SearchUserControl();
            this.searchUserControl3 = new Team2_ScreenDesign.SearchUserControl();
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
            this.panel5.Controls.Add(this.searchPeriodControl1);
            this.panel5.Controls.Add(this.searchUserControl5);
            this.panel5.Controls.Add(this.searchUserControl1);
            this.panel5.Controls.Add(this.searchUserControl4);
            this.panel5.Controls.Add(this.searchUserControl2);
            this.panel5.Controls.Add(this.searchUserControl3);
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
            // searchPeriodControl1
            // 
            this.searchPeriodControl1.Location = new System.Drawing.Point(380, 66);
            this.searchPeriodControl1.Name = "searchPeriodControl1";
            this.searchPeriodControl1.Size = new System.Drawing.Size(312, 36);
            this.searchPeriodControl1.TabIndex = 11;
            // 
            // searchUserControl5
            // 
            this.searchUserControl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.searchUserControl5.ControlType = Team2_ScreenDesign.SearchUserControl.Mode.Worker;
            this.searchUserControl5.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchUserControl5.Location = new System.Drawing.Point(380, 4);
            this.searchUserControl5.Name = "searchUserControl5";
            this.searchUserControl5.Size = new System.Drawing.Size(312, 30);
            this.searchUserControl5.TabIndex = 9;
            // 
            // searchUserControl1
            // 
            this.searchUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.searchUserControl1.ControlType = Team2_ScreenDesign.SearchUserControl.Mode.Factory;
            this.searchUserControl1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchUserControl1.Location = new System.Drawing.Point(21, 4);
            this.searchUserControl1.Name = "searchUserControl1";
            this.searchUserControl1.Size = new System.Drawing.Size(312, 30);
            this.searchUserControl1.TabIndex = 10;
            // 
            // searchUserControl4
            // 
            this.searchUserControl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.searchUserControl4.ControlType = Team2_ScreenDesign.SearchUserControl.Mode.Downtime;
            this.searchUserControl4.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchUserControl4.Location = new System.Drawing.Point(380, 35);
            this.searchUserControl4.Name = "searchUserControl4";
            this.searchUserControl4.Size = new System.Drawing.Size(319, 36);
            this.searchUserControl4.TabIndex = 6;
            // 
            // searchUserControl2
            // 
            this.searchUserControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.searchUserControl2.ControlType = Team2_ScreenDesign.SearchUserControl.Mode.Line;
            this.searchUserControl2.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchUserControl2.Location = new System.Drawing.Point(21, 34);
            this.searchUserControl2.Name = "searchUserControl2";
            this.searchUserControl2.Size = new System.Drawing.Size(319, 36);
            this.searchUserControl2.TabIndex = 7;
            // 
            // searchUserControl3
            // 
            this.searchUserControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.searchUserControl3.ControlType = Team2_ScreenDesign.SearchUserControl.Mode.Product;
            this.searchUserControl3.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchUserControl3.Location = new System.Drawing.Point(21, 66);
            this.searchUserControl3.Name = "searchUserControl3";
            this.searchUserControl3.Size = new System.Drawing.Size(319, 36);
            this.searchUserControl3.TabIndex = 8;
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
        private SearchPeriodControl searchPeriodControl1;
        private SearchUserControl searchUserControl5;
        private SearchUserControl searchUserControl1;
        private SearchUserControl searchUserControl4;
        private SearchUserControl searchUserControl2;
        private SearchUserControl searchUserControl3;
    }
}
