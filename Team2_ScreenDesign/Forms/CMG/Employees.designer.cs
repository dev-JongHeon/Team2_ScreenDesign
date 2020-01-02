﻿namespace TeamProject
{
    partial class Employees
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
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtResignDate = new System.Windows.Forms.TextBox();
            this.txtHireDate = new System.Windows.Forms.TextBox();
            this.txtEmployeesCategory = new System.Windows.Forms.TextBox();
            this.txtEmployeesName = new System.Windows.Forms.TextBox();
            this.txtEmployeesNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeesCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeesCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeesHireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeesResignDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearchCategory = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpResignDate = new System.Windows.Forms.DateTimePicker();
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
            this.splitContainer1.Panel1.Controls.Add(this.dtpResignDate);
            this.splitContainer1.Panel1.Controls.Add(this.dtpHireDate);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearchCategory);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearchName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1095, 641);
            this.splitContainer1.SplitterDistance = 47;
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
            this.splitContainer2.Panel2.Controls.Add(this.txtPhoneNumber);
            this.splitContainer2.Panel2.Controls.Add(this.txtPassword);
            this.splitContainer2.Panel2.Controls.Add(this.txtUser);
            this.splitContainer2.Panel2.Controls.Add(this.txtResignDate);
            this.splitContainer2.Panel2.Controls.Add(this.txtHireDate);
            this.splitContainer2.Panel2.Controls.Add(this.txtEmployeesCategory);
            this.splitContainer2.Panel2.Controls.Add(this.txtEmployeesName);
            this.splitContainer2.Panel2.Controls.Add(this.txtEmployeesNumber);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.label8);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Size = new System.Drawing.Size(1095, 590);
            this.splitContainer2.SplitterDistance = 553;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeesCode,
            this.EmployeesName,
            this.EmployeesCategory,
            this.EmployeesHireDate,
            this.EmployeesResignDate});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(553, 590);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(50, 547);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(117, 21);
            this.txtPhoneNumber.TabIndex = 26;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPassword.Location = new System.Drawing.Point(50, 470);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(117, 21);
            this.txtPassword.TabIndex = 27;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUser.Location = new System.Drawing.Point(50, 397);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(117, 21);
            this.txtUser.TabIndex = 28;
            // 
            // txtResignDate
            // 
            this.txtResignDate.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtResignDate.Location = new System.Drawing.Point(50, 326);
            this.txtResignDate.Name = "txtResignDate";
            this.txtResignDate.Size = new System.Drawing.Size(117, 21);
            this.txtResignDate.TabIndex = 29;
            // 
            // txtHireDate
            // 
            this.txtHireDate.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtHireDate.Location = new System.Drawing.Point(50, 253);
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.Size = new System.Drawing.Size(117, 21);
            this.txtHireDate.TabIndex = 30;
            // 
            // txtEmployeesCategory
            // 
            this.txtEmployeesCategory.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEmployeesCategory.Location = new System.Drawing.Point(50, 185);
            this.txtEmployeesCategory.Name = "txtEmployeesCategory";
            this.txtEmployeesCategory.Size = new System.Drawing.Size(117, 21);
            this.txtEmployeesCategory.TabIndex = 31;
            // 
            // txtEmployeesName
            // 
            this.txtEmployeesName.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEmployeesName.Location = new System.Drawing.Point(50, 111);
            this.txtEmployeesName.Name = "txtEmployeesName";
            this.txtEmployeesName.Size = new System.Drawing.Size(117, 21);
            this.txtEmployeesName.TabIndex = 32;
            // 
            // txtEmployeesNumber
            // 
            this.txtEmployeesNumber.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEmployeesNumber.Location = new System.Drawing.Point(50, 38);
            this.txtEmployeesNumber.Name = "txtEmployeesNumber";
            this.txtEmployeesNumber.Size = new System.Drawing.Size(117, 21);
            this.txtEmployeesNumber.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(46, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "암호";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(46, 525);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "비상연락망";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(46, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "사용자 여부";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(46, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "퇴사일";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(46, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "입사일";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(46, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "부서명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(46, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "사원명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(46, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "사원번호";
            // 
            // EmployeesCode
            // 
            this.EmployeesCode.HeaderText = "사원번호";
            this.EmployeesCode.Name = "EmployeesCode";
            // 
            // EmployeesName
            // 
            this.EmployeesName.HeaderText = "사원명";
            this.EmployeesName.Name = "EmployeesName";
            // 
            // EmployeesCategory
            // 
            this.EmployeesCategory.HeaderText = "부서명";
            this.EmployeesCategory.Name = "EmployeesCategory";
            // 
            // EmployeesHireDate
            // 
            this.EmployeesHireDate.HeaderText = "입사일";
            this.EmployeesHireDate.Name = "EmployeesHireDate";
            // 
            // EmployeesResignDate
            // 
            this.EmployeesResignDate.HeaderText = "퇴사일";
            this.EmployeesResignDate.Name = "EmployeesResignDate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(18, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "사원명";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSearchName.Location = new System.Drawing.Point(78, 14);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(117, 21);
            this.txtSearchName.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(220, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "부서명";
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSearchCategory.Location = new System.Drawing.Point(280, 16);
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.Size = new System.Drawing.Size(117, 21);
            this.txtSearchCategory.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(413, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "기간";
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHireDate.Location = new System.Drawing.Point(458, 16);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(88, 21);
            this.dtpHireDate.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(552, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 19);
            this.label12.TabIndex = 25;
            this.label12.Text = "~";
            // 
            // dtpResignDate
            // 
            this.dtpResignDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpResignDate.Location = new System.Drawing.Point(577, 16);
            this.dtpResignDate.Name = "dtpResignDate";
            this.dtpResignDate.Size = new System.Drawing.Size(88, 21);
            this.dtpResignDate.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(681, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 34;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 641);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Employees";
            this.Text = "사원 관리";
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeesCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeesCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeesHireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeesResignDate;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtResignDate;
        private System.Windows.Forms.TextBox txtHireDate;
        private System.Windows.Forms.TextBox txtEmployeesCategory;
        private System.Windows.Forms.TextBox txtEmployeesName;
        private System.Windows.Forms.TextBox txtEmployeesNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpResignDate;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearchCategory;
    }
}