namespace Gym_Management_System
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.generateQRCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanQRCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expiredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateQRCodeToolStripMenuItem,
            this.scanQRCodeToolStripMenuItem,
            this.dashBoardToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(164, 137);
            this.toolStripMenuItem1.BackColorChanged += new System.EventHandler(this.toolStripMenuItem1_BackColorChanged);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // generateQRCodeToolStripMenuItem
            // 
            this.generateQRCodeToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.generateQRCodeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("generateQRCodeToolStripMenuItem.Image")));
            this.generateQRCodeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.generateQRCodeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 40, 0, 20);
            this.generateQRCodeToolStripMenuItem.Name = "generateQRCodeToolStripMenuItem";
            this.generateQRCodeToolStripMenuItem.Size = new System.Drawing.Size(354, 42);
            this.generateQRCodeToolStripMenuItem.Text = "Generate QR code";
            this.generateQRCodeToolStripMenuItem.Click += new System.EventHandler(this.generateQRCodeToolStripMenuItem_Click);
            // 
            // scanQRCodeToolStripMenuItem
            // 
            this.scanQRCodeToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.scanQRCodeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("scanQRCodeToolStripMenuItem.Image")));
            this.scanQRCodeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scanQRCodeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.scanQRCodeToolStripMenuItem.Name = "scanQRCodeToolStripMenuItem";
            this.scanQRCodeToolStripMenuItem.Size = new System.Drawing.Size(354, 42);
            this.scanQRCodeToolStripMenuItem.Text = "Scan QR Code";
            this.scanQRCodeToolStripMenuItem.Click += new System.EventHandler(this.scanQRCodeToolStripMenuItem_Click);
            // 
            // dashBoardToolStripMenuItem
            // 
            this.dashBoardToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.dashBoardToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dashBoardToolStripMenuItem.Image")));
            this.dashBoardToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dashBoardToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.dashBoardToolStripMenuItem.Name = "dashBoardToolStripMenuItem";
            this.dashBoardToolStripMenuItem.Size = new System.Drawing.Size(354, 42);
            this.dashBoardToolStripMenuItem.Text = "Dash Board";
            this.dashBoardToolStripMenuItem.Click += new System.EventHandler(this.dashBoardToolStripMenuItem_Click);
            // 
            // newMemberToolStripMenuItem
            // 
            this.newMemberToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.newMemberToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMemberToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newMemberToolStripMenuItem.Image")));
            this.newMemberToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newMemberToolStripMenuItem.Name = "newMemberToolStripMenuItem";
            this.newMemberToolStripMenuItem.Size = new System.Drawing.Size(289, 137);
            this.newMemberToolStripMenuItem.Text = "New Member";
            this.newMemberToolStripMenuItem.Click += new System.EventHandler(this.newMemberToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.paymentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("paymentToolStripMenuItem.Image")));
            this.paymentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(226, 137);
            this.paymentToolStripMenuItem.Text = "Payment";
            this.paymentToolStripMenuItem.Click += new System.EventHandler(this.paymentToolStripMenuItem_Click);
            // 
            // expiredToolStripMenuItem
            // 
            this.expiredToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.expiredToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiredToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("expiredToolStripMenuItem.Image")));
            this.expiredToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.expiredToolStripMenuItem.Name = "expiredToolStripMenuItem";
            this.expiredToolStripMenuItem.Padding = new System.Windows.Forms.Padding(25, 0, 5, 0);
            this.expiredToolStripMenuItem.Size = new System.Drawing.Size(229, 137);
            this.expiredToolStripMenuItem.Text = "Expired";
            this.expiredToolStripMenuItem.Click += new System.EventHandler(this.expiredToolStripMenuItem_Click);
            // 
            // deleteMemberToolStripMenuItem
            // 
            this.deleteMemberToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.deleteMemberToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteMemberToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteMemberToolStripMenuItem.Image")));
            this.deleteMemberToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteMemberToolStripMenuItem.Name = "deleteMemberToolStripMenuItem";
            this.deleteMemberToolStripMenuItem.Size = new System.Drawing.Size(315, 137);
            this.deleteMemberToolStripMenuItem.Text = "Delete Member";
            this.deleteMemberToolStripMenuItem.Click += new System.EventHandler(this.deleteMemberToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(216, 137);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.newMemberToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.searchMemberToolStripMenuItem,
            this.expiredToolStripMenuItem,
            this.deleteMemberToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1868, 141);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // searchMemberToolStripMenuItem
            // 
            this.searchMemberToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.searchMemberToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMemberToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchMemberToolStripMenuItem.Image")));
            this.searchMemberToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.searchMemberToolStripMenuItem.Name = "searchMemberToolStripMenuItem";
            this.searchMemberToolStripMenuItem.Size = new System.Drawing.Size(317, 137);
            this.searchMemberToolStripMenuItem.Text = "Search Member";
            this.searchMemberToolStripMenuItem.Click += new System.EventHandler(this.searchMemberToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1868, 568);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Welcome GYM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expiredToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateQRCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanQRCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashBoardToolStripMenuItem;
    }
}

