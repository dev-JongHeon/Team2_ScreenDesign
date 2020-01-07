namespace Team2_ScreenDesign
{
    partial class ProductionProcess
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.공정코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.공정명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.공정분류 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.사용여부 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.비고 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_Search.SuspendLayout();
            this.panel_Title.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            // 
            // panel_Title
            // 
            this.panel_Title.Controls.Add(this.btnAdd);
            this.panel_Title.Controls.SetChildIndex(this.linepanel1, 0);
            this.panel_Title.Controls.SetChildIndex(this.panel8, 0);
            this.panel_Title.Controls.SetChildIndex(this.btnAdd, 0);
            // 
            // lblFormName
            // 
            this.lblFormName.Text = "공정 관리";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.공정코드,
            this.공정명,
            this.공정분류,
            this.사용여부,
            this.비고});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1364, 662);
            this.dataGridView1.TabIndex = 0;
            // 
            // 공정코드
            // 
            this.공정코드.HeaderText = "공정코드";
            this.공정코드.Name = "공정코드";
            // 
            // 공정명
            // 
            this.공정명.HeaderText = "공정명";
            this.공정명.Name = "공정명";
            // 
            // 공정분류
            // 
            this.공정분류.HeaderText = "공정분류";
            this.공정분류.Name = "공정분류";
            // 
            // 사용여부
            // 
            this.사용여부.HeaderText = "사용여부";
            this.사용여부.Name = "사용여부";
            // 
            // 비고
            // 
            this.비고.HeaderText = "비고";
            this.비고.Name = "비고";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1065, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "공정등록";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ProductionProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(1364, 820);
            this.FormName = "공정 관리";
            this.Name = "ProductionProcess";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_Search.ResumeLayout(false);
            this.panel_Title.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 공정코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 공정명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 공정분류;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사용여부;
        private System.Windows.Forms.DataGridViewTextBoxColumn 비고;
        private System.Windows.Forms.Button btnAdd;
    }
}
