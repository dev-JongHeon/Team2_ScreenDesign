namespace Team2_ScreenDesign.Forms.HJS
{
    partial class Produce
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
            this.searchPeriodControl1 = new Team2_ScreenDesign.SearchPeriodControl();
            this.searchPeriodControl2 = new Team2_ScreenDesign.SearchPeriodControl();
            this.panel1.SuspendLayout();
            this.panel_Search.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_Title.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.searchPeriodControl2);
            this.panel5.Controls.Add(this.searchPeriodControl1);
            // 
            // searchPeriodControl1
            // 
            this.searchPeriodControl1.labelName = "생산 시작일";
            this.searchPeriodControl1.Location = new System.Drawing.Point(12, 6);
            this.searchPeriodControl1.Name = "searchPeriodControl1";
            this.searchPeriodControl1.Size = new System.Drawing.Size(312, 30);
            this.searchPeriodControl1.TabIndex = 0;
            // 
            // searchPeriodControl2
            // 
            this.searchPeriodControl2.labelName = "생산 종료일";
            this.searchPeriodControl2.Location = new System.Drawing.Point(12, 37);
            this.searchPeriodControl2.Name = "searchPeriodControl2";
            this.searchPeriodControl2.Size = new System.Drawing.Size(312, 30);
            this.searchPeriodControl2.TabIndex = 1;
            // 
            // Produce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(1364, 820);
            this.Name = "Produce";
            this.panel1.ResumeLayout(false);
            this.panel_Search.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel_Title.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SearchPeriodControl searchPeriodControl1;
        private SearchPeriodControl searchPeriodControl2;
    }
}
