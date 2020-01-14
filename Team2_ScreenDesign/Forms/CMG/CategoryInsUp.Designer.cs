namespace Team2_ScreenDesign
{
    partial class CategoryInsUp
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
            this.txtWarehouseDivision = new System.Windows.Forms.TextBox();
            this.txtWarehouseName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitle)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(641, 408);
            // 
            // panel_Title
            // 
            this.panel_Title.Size = new System.Drawing.Size(639, 32);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(439, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtWarehouseDivision);
            this.panel5.Controls.Add(this.txtWarehouseName);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Size = new System.Drawing.Size(639, 292);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 356);
            this.panel4.Size = new System.Drawing.Size(639, 50);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(639, 32);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Location = new System.Drawing.Point(367, 3);
            // 
            // btnOK
            // 
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.Location = new System.Drawing.Point(170, 3);
            // 
            // txtWarehouseDivision
            // 
            this.txtWarehouseDivision.Location = new System.Drawing.Point(131, 100);
            this.txtWarehouseDivision.Multiline = true;
            this.txtWarehouseDivision.Name = "txtWarehouseDivision";
            this.txtWarehouseDivision.Size = new System.Drawing.Size(390, 137);
            this.txtWarehouseDivision.TabIndex = 5;
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Location = new System.Drawing.Point(131, 38);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(143, 21);
            this.txtWarehouseName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "카테고리내용";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "카테고리이름";
            // 
            // CategoryInsUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 408);
            this.Name = "CategoryInsUp";
            this.Text = "CategoryInsUp";
            this.panel1.ResumeLayout(false);
            this.panel_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitle)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtWarehouseDivision;
        private System.Windows.Forms.TextBox txtWarehouseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}