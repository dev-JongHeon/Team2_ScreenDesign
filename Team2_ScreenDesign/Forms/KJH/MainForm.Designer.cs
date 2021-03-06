﻿namespace Team2_ScreenDesign
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("부서 관리", 0, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("사원 관리", 0, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("거래처 관리", 0, 1);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("고객 관리", 0, 1);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("회사관련기준정보", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("공장 관리", 0, 1);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("공정 관리", 0, 1);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("창고 관리", 0, 1);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("BOM 관리", 0, 1);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("공장관련기준정보", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("출하지시", 0, 1);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("매출현황", 0, 1);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("영업관리", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("사용자권한설정", 0, 1);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("노드1");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("노드2");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("재고관리", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("작업대기현황", 0, 1);
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("생산실적현황", 0, 1);
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("생산 관리", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("비가동유형", 0, 1);
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("비가동현황", 0, 1);
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("비가동 관리", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("불량유형", 0, 1);
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("불량현황", 0, 1);
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("불량 관리", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("사용자권한설정", 0, 1);
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("시스템 메뉴", new System.Windows.Forms.TreeNode[] {
            treeNode27});
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.새로고침ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.신규ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.검색toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.인쇄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.mpanel = new System.Windows.Forms.Panel();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.treeView4 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menu_Info = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel_Sales = new System.Windows.Forms.Panel();
            this.treeView3 = new System.Windows.Forms.TreeView();
            this.menu_Sales = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_Stock = new System.Windows.Forms.Panel();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.menu_Stock = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_Production = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menu_production = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblProduction = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_System = new System.Windows.Forms.Panel();
            this.treeView_System = new System.Windows.Forms.TreeView();
            this.menu_System = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSystem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_Menu.SuspendLayout();
            this.mpanel.SuspendLayout();
            this.panel_Info.SuspendLayout();
            this.menu_Info.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel_Sales.SuspendLayout();
            this.menu_Sales.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel_Stock.SuspendLayout();
            this.menu_Stock.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel_Production.SuspendLayout();
            this.menu_production.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel_System.SuspendLayout();
            this.menu_System.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(216)))), ((int)(((byte)(225)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1584, 90);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.menuStrip);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1580, 84);
            this.panel2.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(202, 71);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1293, 13);
            this.panel7.TabIndex = 18;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.menuStrip.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로고침ToolStripMenuItem,
            this.신규ToolStripMenuItem,
            this.수정ToolStripMenuItem,
            this.삭제ToolStripMenuItem,
            this.검색toolStripMenuItem,
            this.인쇄ToolStripMenuItem,
            this.닫기ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(202, 13);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1293, 59);
            this.menuStrip.TabIndex = 17;
            this.menuStrip.Text = "menuStrip2";
            // 
            // 새로고침ToolStripMenuItem
            // 
            this.새로고침ToolStripMenuItem.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.새로고침ToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.새로고침ToolStripMenuItem.Image = global::Team2_ScreenDesign.Properties.Resources.Action_Refresh_32x32;
            this.새로고침ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.새로고침ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.새로고침ToolStripMenuItem.Name = "새로고침ToolStripMenuItem";
            this.새로고침ToolStripMenuItem.Size = new System.Drawing.Size(81, 55);
            this.새로고침ToolStripMenuItem.Text = "새로고침";
            this.새로고침ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.새로고침ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.새로고침ToolStripMenuItem.Click += new System.EventHandler(this.새로고침ToolStripMenuItem_Click);
            // 
            // 신규ToolStripMenuItem
            // 
            this.신규ToolStripMenuItem.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.신규ToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.신규ToolStripMenuItem.Image = global::Team2_ScreenDesign.Properties.Resources.AddFile_32x32;
            this.신규ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.신규ToolStripMenuItem.Name = "신규ToolStripMenuItem";
            this.신규ToolStripMenuItem.Size = new System.Drawing.Size(59, 55);
            this.신규ToolStripMenuItem.Text = " 신규 ";
            this.신규ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.신규ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.신규ToolStripMenuItem.Click += new System.EventHandler(this.신규ToolStripMenuItem_Click);
            // 
            // 수정ToolStripMenuItem
            // 
            this.수정ToolStripMenuItem.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.수정ToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.수정ToolStripMenuItem.Image = global::Team2_ScreenDesign.Properties.Resources.Edit_32x32;
            this.수정ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.수정ToolStripMenuItem.Name = "수정ToolStripMenuItem";
            this.수정ToolStripMenuItem.Size = new System.Drawing.Size(59, 55);
            this.수정ToolStripMenuItem.Text = " 수정 ";
            this.수정ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.삭제ToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.삭제ToolStripMenuItem.Image = global::Team2_ScreenDesign.Properties.Resources.DeleteList_32x32;
            this.삭제ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(59, 55);
            this.삭제ToolStripMenuItem.Text = " 삭제 ";
            this.삭제ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // 검색toolStripMenuItem
            // 
            this.검색toolStripMenuItem.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.검색toolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.검색toolStripMenuItem.Image = global::Team2_ScreenDesign.Properties.Resources.Lookup_Reference_32x32;
            this.검색toolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.검색toolStripMenuItem.Name = "검색toolStripMenuItem";
            this.검색toolStripMenuItem.Size = new System.Drawing.Size(59, 55);
            this.검색toolStripMenuItem.Text = " 검색 ";
            this.검색toolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // 인쇄ToolStripMenuItem
            // 
            this.인쇄ToolStripMenuItem.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.인쇄ToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.인쇄ToolStripMenuItem.Image = global::Team2_ScreenDesign.Properties.Resources.Printer_32x32;
            this.인쇄ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.인쇄ToolStripMenuItem.Name = "인쇄ToolStripMenuItem";
            this.인쇄ToolStripMenuItem.Size = new System.Drawing.Size(59, 55);
            this.인쇄ToolStripMenuItem.Text = " 인쇄 ";
            this.인쇄ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // 닫기ToolStripMenuItem
            // 
            this.닫기ToolStripMenuItem.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.닫기ToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.닫기ToolStripMenuItem.Image = global::Team2_ScreenDesign.Properties.Resources.window_remove_12810;
            this.닫기ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.닫기ToolStripMenuItem.Name = "닫기ToolStripMenuItem";
            this.닫기ToolStripMenuItem.Size = new System.Drawing.Size(59, 55);
            this.닫기ToolStripMenuItem.Text = " 닫기 ";
            this.닫기ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(202, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1293, 13);
            this.panel6.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.panel5.Controls.Add(this.button2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1495, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(85, 84);
            this.panel5.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.Gray;
            this.button2.Image = global::Team2_ScreenDesign.Properties.Resources.Action_Logoff;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 26);
            this.button2.TabIndex = 0;
            this.button2.Text = "로그아웃";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 84);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Team2_ScreenDesign.Properties.Resources.로고;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1580, 2);
            this.panel3.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 835);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1584, 26);
            this.panel8.TabIndex = 21;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.panel15);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(845, 22);
            this.panel9.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(24, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(821, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "메세지";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.pictureBox2);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(24, 22);
            this.panel15.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Team2_ScreenDesign.Properties.Resources.chat_26_icon_icons_com_65943;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Menu.Controls.Add(this.mpanel);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 90);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(200, 745);
            this.panel_Menu.TabIndex = 23;
            this.panel_Menu.Tag = "system";
            // 
            // mpanel
            // 
            this.mpanel.BackColor = System.Drawing.Color.White;
            this.mpanel.Controls.Add(this.panel_Info);
            this.mpanel.Controls.Add(this.menu_Info);
            this.mpanel.Controls.Add(this.panel_Sales);
            this.mpanel.Controls.Add(this.menu_Sales);
            this.mpanel.Controls.Add(this.panel_Stock);
            this.mpanel.Controls.Add(this.menu_Stock);
            this.mpanel.Controls.Add(this.panel_Production);
            this.mpanel.Controls.Add(this.menu_production);
            this.mpanel.Controls.Add(this.panel_System);
            this.mpanel.Controls.Add(this.menu_System);
            this.mpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpanel.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mpanel.Location = new System.Drawing.Point(0, 0);
            this.mpanel.Name = "mpanel";
            this.mpanel.Size = new System.Drawing.Size(196, 741);
            this.mpanel.TabIndex = 1;
            // 
            // panel_Info
            // 
            this.panel_Info.Controls.Add(this.treeView4);
            this.panel_Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Info.Location = new System.Drawing.Point(0, 505);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(196, 95);
            this.panel_Info.TabIndex = 12;
            this.panel_Info.Tag = "panel_Info";
            // 
            // treeView4
            // 
            this.treeView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView4.FullRowSelect = true;
            this.treeView4.ImageIndex = 2;
            this.treeView4.ImageList = this.imageList1;
            this.treeView4.Location = new System.Drawing.Point(0, 0);
            this.treeView4.Name = "treeView4";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "노드1";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "부서 관리";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "노드1";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "사원 관리";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "노드2";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "거래처 관리";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "노드3";
            treeNode4.SelectedImageIndex = 1;
            treeNode4.Text = "고객 관리";
            treeNode5.Name = "노드0";
            treeNode5.Text = "회사관련기준정보";
            treeNode6.ImageIndex = 0;
            treeNode6.Name = "노드4";
            treeNode6.SelectedImageIndex = 1;
            treeNode6.Text = "공장 관리";
            treeNode7.ImageIndex = 0;
            treeNode7.Name = "노드5";
            treeNode7.SelectedImageIndex = 1;
            treeNode7.Text = "공정 관리";
            treeNode8.ImageIndex = 0;
            treeNode8.Name = "노드6";
            treeNode8.SelectedImageIndex = 1;
            treeNode8.Text = "창고 관리";
            treeNode9.ImageIndex = 0;
            treeNode9.Name = "노드7";
            treeNode9.SelectedImageIndex = 1;
            treeNode9.Text = "BOM 관리";
            treeNode10.Name = "노드0";
            treeNode10.Text = "공장관련기준정보";
            this.treeView4.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode10});
            this.treeView4.SelectedImageIndex = 3;
            this.treeView4.Size = new System.Drawing.Size(196, 95);
            this.treeView4.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "BOReport2_16x16.png");
            this.imageList1.Images.SetKeyName(1, "BOTask_16x16.png");
            this.imageList1.Images.SetKeyName(2, "icons8-folder-16.png");
            this.imageList1.Images.SetKeyName(3, "icons8-opened-folder-16.png");
            // 
            // menu_Info
            // 
            this.menu_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.menu_Info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menu_Info.Controls.Add(this.panel13);
            this.menu_Info.Controls.Add(this.label10);
            this.menu_Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_Info.Location = new System.Drawing.Point(0, 480);
            this.menu_Info.Name = "menu_Info";
            this.menu_Info.Size = new System.Drawing.Size(196, 25);
            this.menu_Info.TabIndex = 11;
            this.menu_Info.Tag = "";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label12);
            this.panel13.Controls.Add(this.lblInfo);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(106, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(86, 21);
            this.panel13.TabIndex = 7;
            this.panel13.Tag = "labelpanel";
            // 
            // label12
            // 
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(-50, -3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 26);
            this.label12.TabIndex = 4;
            this.label12.Tag = "info";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblInfo.Image = global::Team2_ScreenDesign.Properties.Resources.Prev_16x16;
            this.lblInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblInfo.Location = new System.Drawing.Point(48, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(38, 21);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Tag = "info";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInfo.Click += new System.EventHandler(this.label_Click);
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Image = global::Team2_ScreenDesign.Properties.Resources.BOReport_16x16;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 21);
            this.label10.TabIndex = 0;
            this.label10.Tag = "info";
            this.label10.Text = "기준 관리";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label_Click);
            // 
            // panel_Sales
            // 
            this.panel_Sales.Controls.Add(this.treeView3);
            this.panel_Sales.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Sales.Location = new System.Drawing.Point(0, 385);
            this.panel_Sales.Name = "panel_Sales";
            this.panel_Sales.Size = new System.Drawing.Size(196, 95);
            this.panel_Sales.TabIndex = 10;
            this.panel_Sales.Tag = "panel_Sales";
            // 
            // treeView3
            // 
            this.treeView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView3.FullRowSelect = true;
            this.treeView3.ImageIndex = 2;
            this.treeView3.ImageList = this.imageList1;
            this.treeView3.Location = new System.Drawing.Point(0, 0);
            this.treeView3.Name = "treeView3";
            treeNode11.ImageIndex = 0;
            treeNode11.Name = "노드1";
            treeNode11.SelectedImageIndex = 1;
            treeNode11.Text = "출하지시";
            treeNode12.ImageIndex = 0;
            treeNode12.Name = "노드0";
            treeNode12.SelectedImageIndex = 1;
            treeNode12.Text = "매출현황";
            treeNode13.Name = "노드0";
            treeNode13.Text = "영업관리";
            this.treeView3.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.treeView3.SelectedImageIndex = 3;
            this.treeView3.Size = new System.Drawing.Size(196, 95);
            this.treeView3.TabIndex = 1;
            // 
            // menu_Sales
            // 
            this.menu_Sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.menu_Sales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menu_Sales.Controls.Add(this.panel12);
            this.menu_Sales.Controls.Add(this.label8);
            this.menu_Sales.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_Sales.Location = new System.Drawing.Point(0, 360);
            this.menu_Sales.Name = "menu_Sales";
            this.menu_Sales.Size = new System.Drawing.Size(196, 25);
            this.menu_Sales.TabIndex = 9;
            this.menu_Sales.Tag = "";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label11);
            this.panel12.Controls.Add(this.lblSales);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(106, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(86, 21);
            this.panel12.TabIndex = 6;
            this.panel12.Tag = "labelpanel";
            // 
            // label11
            // 
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(-71, -3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 26);
            this.label11.TabIndex = 4;
            this.label11.Tag = "sales";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label_Click);
            // 
            // lblSales
            // 
            this.lblSales.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblSales.Image = global::Team2_ScreenDesign.Properties.Resources.Prev_16x16;
            this.lblSales.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSales.Location = new System.Drawing.Point(48, 0);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(38, 21);
            this.lblSales.TabIndex = 2;
            this.lblSales.Tag = "sales";
            this.lblSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSales.Click += new System.EventHandler(this.label_Click);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Image = global::Team2_ScreenDesign.Properties.Resources.BOOrderItem_16x16;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 21);
            this.label8.TabIndex = 0;
            this.label8.Tag = "sales";
            this.label8.Text = "영업 관리";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label_Click);
            // 
            // panel_Stock
            // 
            this.panel_Stock.Controls.Add(this.treeView2);
            this.panel_Stock.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Stock.Location = new System.Drawing.Point(0, 265);
            this.panel_Stock.Name = "panel_Stock";
            this.panel_Stock.Size = new System.Drawing.Size(196, 95);
            this.panel_Stock.TabIndex = 8;
            this.panel_Stock.Tag = "panel_Stock";
            // 
            // treeView2
            // 
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.FullRowSelect = true;
            this.treeView2.ImageIndex = 2;
            this.treeView2.ImageList = this.imageList1;
            this.treeView2.Location = new System.Drawing.Point(0, 0);
            this.treeView2.Name = "treeView2";
            treeNode14.ImageIndex = 0;
            treeNode14.Name = "노드1";
            treeNode14.SelectedImageIndex = 1;
            treeNode14.Text = "사용자권한설정";
            treeNode15.Name = "노드1";
            treeNode15.Text = "노드1";
            treeNode16.Name = "노드2";
            treeNode16.Text = "노드2";
            treeNode17.Name = "노드0";
            treeNode17.Text = "재고관리";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17});
            this.treeView2.SelectedImageIndex = 3;
            this.treeView2.Size = new System.Drawing.Size(196, 95);
            this.treeView2.TabIndex = 1;
            // 
            // menu_Stock
            // 
            this.menu_Stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.menu_Stock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menu_Stock.Controls.Add(this.panel11);
            this.menu_Stock.Controls.Add(this.label3);
            this.menu_Stock.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_Stock.Location = new System.Drawing.Point(0, 240);
            this.menu_Stock.Name = "menu_Stock";
            this.menu_Stock.Size = new System.Drawing.Size(196, 25);
            this.menu_Stock.TabIndex = 7;
            this.menu_Stock.Tag = "";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label9);
            this.panel11.Controls.Add(this.lblStock);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(106, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(86, 21);
            this.panel11.TabIndex = 5;
            this.panel11.Tag = "labelpanel";
            // 
            // label9
            // 
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(-71, -3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 26);
            this.label9.TabIndex = 4;
            this.label9.Tag = "stock";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label_Click);
            // 
            // lblStock
            // 
            this.lblStock.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblStock.Image = global::Team2_ScreenDesign.Properties.Resources.Prev_16x16;
            this.lblStock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStock.Location = new System.Drawing.Point(48, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(38, 21);
            this.lblStock.TabIndex = 2;
            this.lblStock.Tag = "stock";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStock.Click += new System.EventHandler(this.label_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Image = global::Team2_ScreenDesign.Properties.Resources.BOProductGroup_16x16;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 0;
            this.label3.Tag = "stock";
            this.label3.Text = "재고관리";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label_Click);
            // 
            // panel_Production
            // 
            this.panel_Production.Controls.Add(this.treeView1);
            this.panel_Production.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Production.Location = new System.Drawing.Point(0, 145);
            this.panel_Production.Name = "panel_Production";
            this.panel_Production.Size = new System.Drawing.Size(196, 95);
            this.panel_Production.TabIndex = 6;
            this.panel_Production.Tag = "panel_Production";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.FullRowSelect = true;
            this.treeView1.ImageIndex = 2;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode18.ImageIndex = 0;
            treeNode18.Name = "노드3";
            treeNode18.SelectedImageIndex = 1;
            treeNode18.Text = "작업대기현황";
            treeNode19.ImageIndex = 0;
            treeNode19.Name = "노드5";
            treeNode19.SelectedImageIndex = 1;
            treeNode19.Text = "생산실적현황";
            treeNode20.Name = "노드1";
            treeNode20.Text = "생산 관리";
            treeNode21.ImageIndex = 0;
            treeNode21.Name = "노드1";
            treeNode21.SelectedImageIndex = 1;
            treeNode21.Text = "비가동유형";
            treeNode22.ImageIndex = 0;
            treeNode22.Name = "노드7";
            treeNode22.SelectedImageIndex = 1;
            treeNode22.Text = "비가동현황";
            treeNode23.Name = "노드0";
            treeNode23.Text = "비가동 관리";
            treeNode24.ImageIndex = 0;
            treeNode24.Name = "노드8";
            treeNode24.SelectedImageIndex = 1;
            treeNode24.Text = "불량유형";
            treeNode25.ImageIndex = 0;
            treeNode25.Name = "노드9";
            treeNode25.SelectedImageIndex = 1;
            treeNode25.Text = "불량현황";
            treeNode26.Name = "노드0";
            treeNode26.Text = "불량 관리";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode23,
            treeNode26});
            this.treeView1.SelectedImageIndex = 3;
            this.treeView1.Size = new System.Drawing.Size(196, 95);
            this.treeView1.TabIndex = 1;
            // 
            // menu_production
            // 
            this.menu_production.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.menu_production.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menu_production.Controls.Add(this.panel10);
            this.menu_production.Controls.Add(this.label6);
            this.menu_production.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_production.Location = new System.Drawing.Point(0, 120);
            this.menu_production.Name = "menu_production";
            this.menu_production.Size = new System.Drawing.Size(196, 25);
            this.menu_production.TabIndex = 5;
            this.menu_production.Tag = "";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label7);
            this.panel10.Controls.Add(this.lblProduction);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(106, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(86, 21);
            this.panel10.TabIndex = 4;
            this.panel10.Tag = "labelpanel";
            // 
            // label7
            // 
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(-74, -3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 26);
            this.label7.TabIndex = 4;
            this.label7.Tag = "production";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label_Click);
            // 
            // lblProduction
            // 
            this.lblProduction.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblProduction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblProduction.Image = global::Team2_ScreenDesign.Properties.Resources.Prev_16x16;
            this.lblProduction.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblProduction.Location = new System.Drawing.Point(48, 0);
            this.lblProduction.Name = "lblProduction";
            this.lblProduction.Size = new System.Drawing.Size(38, 21);
            this.lblProduction.TabIndex = 3;
            this.lblProduction.Tag = "production";
            this.lblProduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProduction.Click += new System.EventHandler(this.label_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Image = global::Team2_ScreenDesign.Properties.Resources.IDE_16x16;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 0;
            this.label6.Tag = "production";
            this.label6.Text = "  생산 관리";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label_Click);
            // 
            // panel_System
            // 
            this.panel_System.Controls.Add(this.treeView_System);
            this.panel_System.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_System.Location = new System.Drawing.Point(0, 25);
            this.panel_System.Name = "panel_System";
            this.panel_System.Size = new System.Drawing.Size(196, 95);
            this.panel_System.TabIndex = 2;
            this.panel_System.Tag = "panel_System";
            // 
            // treeView_System
            // 
            this.treeView_System.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_System.FullRowSelect = true;
            this.treeView_System.ImageIndex = 2;
            this.treeView_System.ImageList = this.imageList1;
            this.treeView_System.Location = new System.Drawing.Point(0, 0);
            this.treeView_System.Name = "treeView_System";
            treeNode27.ImageIndex = 0;
            treeNode27.Name = "노드1";
            treeNode27.SelectedImageIndex = 1;
            treeNode27.Text = "사용자권한설정";
            treeNode28.Name = "노드0";
            treeNode28.Text = "시스템 메뉴";
            this.treeView_System.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode28});
            this.treeView_System.SelectedImageIndex = 3;
            this.treeView_System.Size = new System.Drawing.Size(196, 95);
            this.treeView_System.TabIndex = 0;
            // 
            // menu_System
            // 
            this.menu_System.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.menu_System.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menu_System.Controls.Add(this.panel14);
            this.menu_System.Controls.Add(this.label1);
            this.menu_System.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_System.Location = new System.Drawing.Point(0, 0);
            this.menu_System.Name = "menu_System";
            this.menu_System.Size = new System.Drawing.Size(196, 25);
            this.menu_System.TabIndex = 1;
            this.menu_System.Tag = "";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label2);
            this.panel14.Controls.Add(this.lblSystem);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel14.Location = new System.Drawing.Point(106, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(86, 21);
            this.panel14.TabIndex = 2;
            this.panel14.Tag = "labelpanel";
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(-53, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 26);
            this.label2.TabIndex = 3;
            this.label2.Tag = "system";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label_Click);
            // 
            // lblSystem
            // 
            this.lblSystem.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblSystem.Image = global::Team2_ScreenDesign.Properties.Resources.Prev_16x16;
            this.lblSystem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSystem.Location = new System.Drawing.Point(48, 0);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(38, 21);
            this.lblSystem.TabIndex = 2;
            this.lblSystem.Tag = "system";
            this.lblSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSystem.Click += new System.EventHandler(this.label_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Image = global::Team2_ScreenDesign.Properties.Resources.ViewSetting_16x16;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Tag = "system";
            this.label1.Text = "시스템 관리";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.splitter1.Location = new System.Drawing.Point(200, 90);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 745);
            this.splitter1.TabIndex = 25;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.HotTrack = true;
            this.tabControl1.ItemSize = new System.Drawing.Size(110, 25);
            this.tabControl1.Location = new System.Drawing.Point(204, 90);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1380, 28);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 26;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Team2_ScreenDesign.Properties.Resources.left_arrow__2_;
            this.button1.Location = new System.Drawing.Point(200, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(4, 100);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "구디 B2KE";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_Menu.ResumeLayout(false);
            this.mpanel.ResumeLayout(false);
            this.panel_Info.ResumeLayout(false);
            this.menu_Info.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel_Sales.ResumeLayout(false);
            this.menu_Sales.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel_Stock.ResumeLayout(false);
            this.menu_Stock.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel_Production.ResumeLayout(false);
            this.menu_production.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel_System.ResumeLayout(false);
            this.menu_System.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.MenuStrip menuStrip;
        public System.Windows.Forms.ToolStripMenuItem 새로고침ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 신규ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 수정ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 검색toolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 인쇄ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 닫기ToolStripMenuItem;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel mpanel;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.Panel menu_Info;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel_Sales;
        private System.Windows.Forms.Panel menu_Sales;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel_Stock;
        private System.Windows.Forms.Panel menu_Stock;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_Production;
        private System.Windows.Forms.Panel menu_production;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblProduction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_System;
        private System.Windows.Forms.Panel menu_System;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TreeView treeView_System;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView4;
        private System.Windows.Forms.TreeView treeView3;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
    }
}

