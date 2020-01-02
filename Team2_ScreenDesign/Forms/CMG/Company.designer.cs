namespace TeamProject
{
    partial class Company
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCompanyDivision = new System.Windows.Forms.TextBox();
            this.txtCompanyBC = new System.Windows.Forms.TextBox();
            this.txtCompanyFaxNumber = new System.Windows.Forms.TextBox();
            this.txtCompanyPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtCompanyAddressDetail = new System.Windows.Forms.TextBox();
            this.txtCompanyAddress = new System.Windows.Forms.TextBox();
            this.txtCompanyAddressNumber = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtCompanyNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CompanyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightGreen;
            this.splitContainer1.Panel2.Controls.Add(this.txtCompanyDivision);
            this.splitContainer1.Panel2.Controls.Add(this.txtCompanyBC);
            this.splitContainer1.Panel2.Controls.Add(this.txtCompanyFaxNumber);
            this.splitContainer1.Panel2.Controls.Add(this.txtCompanyPhoneNumber);
            this.splitContainer1.Panel2.Controls.Add(this.txtCompanyAddressDetail);
            this.splitContainer1.Panel2.Controls.Add(this.txtCompanyAddress);
            this.splitContainer1.Panel2.Controls.Add(this.txtCompanyAddressNumber);
            this.splitContainer1.Panel2.Controls.Add(this.txtCompanyName);
            this.splitContainer1.Panel2.Controls.Add(this.txtCompanyNumber);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1095, 641);
            this.splitContainer1.SplitterDistance = 249;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyCode,
            this.CompanyName});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(249, 641);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtCompanyDivision
            // 
            this.txtCompanyDivision.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCompanyDivision.Location = new System.Drawing.Point(187, 576);
            this.txtCompanyDivision.Name = "txtCompanyDivision";
            this.txtCompanyDivision.Size = new System.Drawing.Size(117, 21);
            this.txtCompanyDivision.TabIndex = 20;
            // 
            // txtCompanyBC
            // 
            this.txtCompanyBC.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCompanyBC.Location = new System.Drawing.Point(187, 513);
            this.txtCompanyBC.Name = "txtCompanyBC";
            this.txtCompanyBC.Size = new System.Drawing.Size(117, 21);
            this.txtCompanyBC.TabIndex = 18;
            // 
            // txtCompanyFaxNumber
            // 
            this.txtCompanyFaxNumber.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCompanyFaxNumber.Location = new System.Drawing.Point(187, 448);
            this.txtCompanyFaxNumber.Name = "txtCompanyFaxNumber";
            this.txtCompanyFaxNumber.Size = new System.Drawing.Size(117, 21);
            this.txtCompanyFaxNumber.TabIndex = 17;
            // 
            // txtCompanyPhoneNumber
            // 
            this.txtCompanyPhoneNumber.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCompanyPhoneNumber.Location = new System.Drawing.Point(187, 381);
            this.txtCompanyPhoneNumber.Name = "txtCompanyPhoneNumber";
            this.txtCompanyPhoneNumber.Size = new System.Drawing.Size(117, 21);
            this.txtCompanyPhoneNumber.TabIndex = 16;
            // 
            // txtCompanyAddressDetail
            // 
            this.txtCompanyAddressDetail.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCompanyAddressDetail.Location = new System.Drawing.Point(187, 308);
            this.txtCompanyAddressDetail.Name = "txtCompanyAddressDetail";
            this.txtCompanyAddressDetail.Size = new System.Drawing.Size(117, 21);
            this.txtCompanyAddressDetail.TabIndex = 15;
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCompanyAddress.Location = new System.Drawing.Point(187, 236);
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Size = new System.Drawing.Size(117, 21);
            this.txtCompanyAddress.TabIndex = 14;
            // 
            // txtCompanyAddressNumber
            // 
            this.txtCompanyAddressNumber.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCompanyAddressNumber.Location = new System.Drawing.Point(187, 169);
            this.txtCompanyAddressNumber.Name = "txtCompanyAddressNumber";
            this.txtCompanyAddressNumber.Size = new System.Drawing.Size(117, 21);
            this.txtCompanyAddressNumber.TabIndex = 13;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCompanyName.Location = new System.Drawing.Point(187, 96);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(117, 21);
            this.txtCompanyName.TabIndex = 19;
            // 
            // txtCompanyNumber
            // 
            this.txtCompanyNumber.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCompanyNumber.Location = new System.Drawing.Point(187, 31);
            this.txtCompanyNumber.Name = "txtCompanyNumber";
            this.txtCompanyNumber.Size = new System.Drawing.Size(117, 21);
            this.txtCompanyNumber.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(142, 578);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "종목";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(142, 515);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "업태";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(107, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "FAX 번호";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(112, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "전화번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(93, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "거래처 번지";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(93, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "거래처 주소";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(63, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "거래처 우편번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(112, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "대표자명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(63, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "거래처 등록번호";
            // 
            // CompanyCode
            // 
            this.CompanyCode.HeaderText = "거래처 코드";
            this.CompanyCode.Name = "CompanyCode";
            // 
            // CompanyName
            // 
            this.CompanyName.HeaderText = "거래처명";
            this.CompanyName.Name = "CompanyName";
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 641);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Company";
            this.Text = "Company";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCompanyDivision;
        private System.Windows.Forms.TextBox txtCompanyBC;
        private System.Windows.Forms.TextBox txtCompanyFaxNumber;
        private System.Windows.Forms.TextBox txtCompanyPhoneNumber;
        private System.Windows.Forms.TextBox txtCompanyAddressDetail;
        private System.Windows.Forms.TextBox txtCompanyAddress;
        private System.Windows.Forms.TextBox txtCompanyAddressNumber;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtCompanyNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
    }
}