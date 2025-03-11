namespace Gym_Management_System
{
    partial class Expire_Date
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expire_Date));
            this.view_expired_date = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.view_expired_date)).BeginInit();
            this.SuspendLayout();
            // 
            // view_expired_date
            // 
            this.view_expired_date.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view_expired_date.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_expired_date.Location = new System.Drawing.Point(62, 251);
            this.view_expired_date.Name = "view_expired_date";
            this.view_expired_date.RowHeadersWidth = 51;
            this.view_expired_date.RowTemplate.Height = 24;
            this.view_expired_date.Size = new System.Drawing.Size(1220, 376);
            this.view_expired_date.TabIndex = 0;
            this.view_expired_date.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_expired_date_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(516, 674);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 101);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send Message Whatsapp";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Expire_Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1333, 800);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.view_expired_date);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Expire_Date";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expire_Date";
            this.Load += new System.EventHandler(this.Expire_Date_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_expired_date)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView view_expired_date;
        private System.Windows.Forms.Button button1;
    }
}