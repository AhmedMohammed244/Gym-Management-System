namespace Gym_Management_System
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.total_p_lab = new System.Windows.Forms.Label();
            this.Total_money_lab = new System.Windows.Forms.Label();
            this.tot_remain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // total_p_lab
            // 
            this.total_p_lab.BackColor = System.Drawing.Color.Teal;
            this.total_p_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_p_lab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.total_p_lab.Image = ((System.Drawing.Image)(resources.GetObject("total_p_lab.Image")));
            this.total_p_lab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.total_p_lab.Location = new System.Drawing.Point(79, 268);
            this.total_p_lab.Name = "total_p_lab";
            this.total_p_lab.Size = new System.Drawing.Size(447, 105);
            this.total_p_lab.TabIndex = 0;
            this.total_p_lab.Text = "Total Players";
            this.total_p_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Total_money_lab
            // 
            this.Total_money_lab.BackColor = System.Drawing.Color.Teal;
            this.Total_money_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_money_lab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Total_money_lab.Image = ((System.Drawing.Image)(resources.GetObject("Total_money_lab.Image")));
            this.Total_money_lab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Total_money_lab.Location = new System.Drawing.Point(310, 545);
            this.Total_money_lab.Name = "Total_money_lab";
            this.Total_money_lab.Size = new System.Drawing.Size(826, 105);
            this.Total_money_lab.TabIndex = 1;
            this.Total_money_lab.Text = "Total Money";
            this.Total_money_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tot_remain
            // 
            this.tot_remain.BackColor = System.Drawing.Color.Teal;
            this.tot_remain.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tot_remain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tot_remain.Image = ((System.Drawing.Image)(resources.GetObject("tot_remain.Image")));
            this.tot_remain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tot_remain.Location = new System.Drawing.Point(760, 268);
            this.tot_remain.Name = "tot_remain";
            this.tot_remain.Size = new System.Drawing.Size(528, 105);
            this.tot_remain.TabIndex = 2;
            this.tot_remain.Text = "Total Remaining";
            this.tot_remain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tot_remain.Click += new System.EventHandler(this.tot_remain_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1387, 744);
            this.Controls.Add(this.tot_remain);
            this.Controls.Add(this.Total_money_lab);
            this.Controls.Add(this.total_p_lab);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label total_p_lab;
        private System.Windows.Forms.Label Total_money_lab;
        private System.Windows.Forms.Label tot_remain;
    }
}