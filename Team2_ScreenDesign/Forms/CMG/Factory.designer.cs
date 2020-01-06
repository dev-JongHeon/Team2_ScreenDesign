namespace Team2_ScreenDesign
{
    partial class Factory
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFactoryAddress = new System.Windows.Forms.TextBox();
            this.txtFactoryMasterName = new System.Windows.Forms.TextBox();
            this.txtFactoryFaxNumber = new System.Windows.Forms.TextBox();
            this.txtFactoryNumber = new System.Windows.Forms.TextBox();
            this.txtFactoryDivision = new System.Windows.Forms.TextBox();
            this.txtFactoryName = new System.Windows.Forms.TextBox();
            this.txtFactoryCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FactoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactoryDivision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchDivision = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearchName);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearchDivision);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1095, 641);
            this.splitContainer1.SplitterDistance = 46;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainer2.Panel2.Controls.Add(this.txtFactoryAddress);
            this.splitContainer2.Panel2.Controls.Add(this.txtFactoryMasterName);
            this.splitContainer2.Panel2.Controls.Add(this.txtFactoryFaxNumber);
            this.splitContainer2.Panel2.Controls.Add(this.txtFactoryNumber);
            this.splitContainer2.Panel2.Controls.Add(this.txtFactoryDivision);
            this.splitContainer2.Panel2.Controls.Add(this.txtFactoryName);
            this.splitContainer2.Panel2.Controls.Add(this.txtFactoryCode);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Size = new System.Drawing.Size(1095, 591);
            this.splitContainer2.SplitterDistance = 350;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FactoryCode,
            this.FactoryName,
            this.FactoryDivision});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(350, 591);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtFactoryAddress
            // 
            this.txtFactoryAddress.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtFactoryAddress.Location = new System.Drawing.Point(102, 534);
            this.txtFactoryAddress.Name = "txtFactoryAddress";
            this.txtFactoryAddress.Size = new System.Drawing.Size(117, 21);
            this.txtFactoryAddress.TabIndex = 25;
            // 
            // txtFactoryMasterName
            // 
            this.txtFactoryMasterName.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtFactoryMasterName.Location = new System.Drawing.Point(102, 447);
            this.txtFactoryMasterName.Name = "txtFactoryMasterName";
            this.txtFactoryMasterName.Size = new System.Drawing.Size(117, 21);
            this.txtFactoryMasterName.TabIndex = 26;
            // 
            // txtFactoryFaxNumber
            // 
            this.txtFactoryFaxNumber.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtFactoryFaxNumber.Location = new System.Drawing.Point(102, 363);
            this.txtFactoryFaxNumber.Name = "txtFactoryFaxNumber";
            this.txtFactoryFaxNumber.Size = new System.Drawing.Size(117, 21);
            this.txtFactoryFaxNumber.TabIndex = 27;
            // 
            // txtFactoryNumber
            // 
            this.txtFactoryNumber.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtFactoryNumber.Location = new System.Drawing.Point(102, 282);
            this.txtFactoryNumber.Name = "txtFactoryNumber";
            this.txtFactoryNumber.Size = new System.Drawing.Size(117, 21);
            this.txtFactoryNumber.TabIndex = 28;
            // 
            // txtFactoryDivision
            // 
            this.txtFactoryDivision.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtFactoryDivision.Location = new System.Drawing.Point(102, 207);
            this.txtFactoryDivision.Name = "txtFactoryDivision";
            this.txtFactoryDivision.Size = new System.Drawing.Size(117, 21);
            this.txtFactoryDivision.TabIndex = 29;
            // 
            // txtFactoryName
            // 
            this.txtFactoryName.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtFactoryName.Location = new System.Drawing.Point(102, 131);
            this.txtFactoryName.Name = "txtFactoryName";
            this.txtFactoryName.Size = new System.Drawing.Size(117, 21);
            this.txtFactoryName.TabIndex = 30;
            // 
            // txtFactoryCode
            // 
            this.txtFactoryCode.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtFactoryCode.Location = new System.Drawing.Point(102, 57);
            this.txtFactoryCode.Name = "txtFactoryCode";
            this.txtFactoryCode.Size = new System.Drawing.Size(117, 21);
            this.txtFactoryCode.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(98, 512);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "주소";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(98, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "담당자명";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(98, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "FAX 번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(98, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "전화번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(98, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "구분";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(98, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "공장이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(98, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "공장번호";
            // 
            // FactoryCode
            // 
            this.FactoryCode.HeaderText = "번호";
            this.FactoryCode.Name = "FactoryCode";
            // 
            // FactoryName
            // 
            this.FactoryName.HeaderText = "이름";
            this.FactoryName.Name = "FactoryName";
            // 
            // FactoryDivision
            // 
            this.FactoryDivision.HeaderText = "구분";
            this.FactoryDivision.Name = "FactoryDivision";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(16, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "이름";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSearchName.Location = new System.Drawing.Point(62, 13);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(117, 21);
            this.txtSearchName.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(204, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "구분";
            // 
            // txtSearchDivision
            // 
            this.txtSearchDivision.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSearchDivision.Location = new System.Drawing.Point(249, 12);
            this.txtSearchDivision.Name = "txtSearchDivision";
            this.txtSearchDivision.Size = new System.Drawing.Size(117, 21);
            this.txtSearchDivision.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(381, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 32;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Factory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 641);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Factory";
            this.Text = "공장 관리";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFactoryAddress;
        private System.Windows.Forms.TextBox txtFactoryMasterName;
        private System.Windows.Forms.TextBox txtFactoryFaxNumber;
        private System.Windows.Forms.TextBox txtFactoryNumber;
        private System.Windows.Forms.TextBox txtFactoryDivision;
        private System.Windows.Forms.TextBox txtFactoryName;
        private System.Windows.Forms.TextBox txtFactoryCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchDivision;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactoryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactoryDivision;
    }
}