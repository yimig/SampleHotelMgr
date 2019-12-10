namespace HotelMgr2017101999
{
    partial class MainForm
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.客房管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            this.miCheckOut = new System.Windows.Forms.ToolStripMenuItem();
            this.查询管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miCustomerQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.miRoomQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.miUserManage = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客房管理ToolStripMenuItem,
            this.查询管理ToolStripMenuItem,
            this.miUserManage,
            this.帮助ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 客房管理ToolStripMenuItem
            // 
            this.客房管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCheckIn,
            this.miCheckOut});
            this.客房管理ToolStripMenuItem.Name = "客房管理ToolStripMenuItem";
            this.客房管理ToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.客房管理ToolStripMenuItem.Text = "客房管理(&M)";
            // 
            // miCheckIn
            // 
            this.miCheckIn.Name = "miCheckIn";
            this.miCheckIn.Size = new System.Drawing.Size(180, 22);
            this.miCheckIn.Text = "入住登记";
            this.miCheckIn.Click += new System.EventHandler(this.miCheckIn_Click);
            // 
            // miCheckOut
            // 
            this.miCheckOut.Name = "miCheckOut";
            this.miCheckOut.Size = new System.Drawing.Size(180, 22);
            this.miCheckOut.Text = "退房登记";
            this.miCheckOut.Click += new System.EventHandler(this.miCheckOut_Click);
            // 
            // 查询管理ToolStripMenuItem
            // 
            this.查询管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCustomerQuery,
            this.miRoomQuery});
            this.查询管理ToolStripMenuItem.Name = "查询管理ToolStripMenuItem";
            this.查询管理ToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.查询管理ToolStripMenuItem.Text = "查询管理(&S)";
            // 
            // miCustomerQuery
            // 
            this.miCustomerQuery.Name = "miCustomerQuery";
            this.miCustomerQuery.Size = new System.Drawing.Size(180, 22);
            this.miCustomerQuery.Text = "旅客信息查询";
            this.miCustomerQuery.Click += new System.EventHandler(this.miCustomerQuery_Click);
            // 
            // miRoomQuery
            // 
            this.miRoomQuery.Name = "miRoomQuery";
            this.miRoomQuery.Size = new System.Drawing.Size(180, 22);
            this.miRoomQuery.Text = "客房信息查询";
            this.miRoomQuery.Click += new System.EventHandler(this.miRoomQuery_Click);
            // 
            // miUserManage
            // 
            this.miUserManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddUser,
            this.miEditUser});
            this.miUserManage.Name = "miUserManage";
            this.miUserManage.Size = new System.Drawing.Size(87, 20);
            this.miUserManage.Text = "用户管理(&U)";
            // 
            // miAddUser
            // 
            this.miAddUser.Name = "miAddUser";
            this.miAddUser.Size = new System.Drawing.Size(180, 22);
            this.miAddUser.Text = "添加新用户";
            this.miAddUser.Click += new System.EventHandler(this.miNewUser_Click);
            // 
            // miEditUser
            // 
            this.miEditUser.Name = "miEditUser";
            this.miEditUser.Size = new System.Drawing.Size(180, 22);
            this.miEditUser.Text = "删除/修改";
            this.miEditUser.Click += new System.EventHandler(this.miEditUser_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(180, 22);
            this.miAbout.Text = "关于";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::HotelMgr2017101999.Properties.Resources.inRoom;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(79, 22);
            this.toolStripButton1.Text = "入住登记";
            this.toolStripButton1.Click += new System.EventHandler(this.miCheckIn_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::HotelMgr2017101999.Properties.Resources.outRoom;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(79, 22);
            this.toolStripButton2.Text = "退房登记";
            this.toolStripButton2.Click += new System.EventHandler(this.miCheckOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::HotelMgr2017101999.Properties.Resources.cosInfo;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(79, 22);
            this.toolStripButton3.Text = "旅客信息";
            this.toolStripButton3.Click += new System.EventHandler(this.miCustomerQuery_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::HotelMgr2017101999.Properties.Resources.roomInfo;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(79, 22);
            this.toolStripButton4.Text = "客房信息";
            this.toolStripButton4.Click += new System.EventHandler(this.miRoomQuery_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::HotelMgr2017101999.Properties.Resources.userAdd;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(92, 22);
            this.toolStripButton5.Text = "添加新用户";
            this.toolStripButton5.Click += new System.EventHandler(this.miNewUser_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = global::HotelMgr2017101999.Properties.Resources.editUser;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(110, 22);
            this.toolStripButton6.Text = "删除/修改用户";
            this.toolStripButton6.Click += new System.EventHandler(this.miEditUser_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "酒店管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm1999_FormClosed);
            this.Load += new System.EventHandler(this.MainForm1999_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 客房管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miCheckIn;
        private System.Windows.Forms.ToolStripMenuItem miCheckOut;
        private System.Windows.Forms.ToolStripMenuItem 查询管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miCustomerQuery;
        private System.Windows.Forms.ToolStripMenuItem miRoomQuery;
        private System.Windows.Forms.ToolStripMenuItem miUserManage;
        private System.Windows.Forms.ToolStripMenuItem miAddUser;
        private System.Windows.Forms.ToolStripMenuItem miEditUser;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}