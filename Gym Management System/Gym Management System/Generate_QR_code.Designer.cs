namespace Gym_Management_System
{
    partial class Generate_QR_code
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generate_QR_code));
            this.Load_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Mid_txt = new System.Windows.Forms.TextBox();
            this.Generate_btn = new System.Windows.Forms.Button();
            this.QRCode_Image = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.L_name = new System.Windows.Forms.TextBox();
            this.F_name = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QRCode_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Load_btn
            // 
            this.Load_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Load_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Load_btn.Location = new System.Drawing.Point(504, 150);
            this.Load_btn.Name = "Load_btn";
            this.Load_btn.Size = new System.Drawing.Size(187, 57);
            this.Load_btn.TabIndex = 23;
            this.Load_btn.Text = "Load";
            this.Load_btn.UseVisualStyleBackColor = false;
            this.Load_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(64, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "Phone";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phone_txt
            // 
            this.phone_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_txt.Location = new System.Drawing.Point(291, 416);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.ReadOnly = true;
            this.phone_txt.Size = new System.Drawing.Size(221, 30);
            this.phone_txt.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(32, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 32);
            this.label4.TabIndex = 21;
            this.label4.Text = "Member_Id";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Mid_txt
            // 
            this.Mid_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mid_txt.Location = new System.Drawing.Point(278, 127);
            this.Mid_txt.Name = "Mid_txt";
            this.Mid_txt.Size = new System.Drawing.Size(126, 30);
            this.Mid_txt.TabIndex = 12;
            this.Mid_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Generate_btn
            // 
            this.Generate_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Generate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Generate_btn.Location = new System.Drawing.Point(299, 532);
            this.Generate_btn.Name = "Generate_btn";
            this.Generate_btn.Size = new System.Drawing.Size(213, 57);
            this.Generate_btn.TabIndex = 20;
            this.Generate_btn.Text = "Generate";
            this.Generate_btn.UseVisualStyleBackColor = false;
            this.Generate_btn.Click += new System.EventHandler(this.Generate_btn_Click);
            // 
            // QRCode_Image
            // 
            this.QRCode_Image.BackColor = System.Drawing.Color.Silver;
            this.QRCode_Image.Location = new System.Drawing.Point(805, 216);
            this.QRCode_Image.Name = "QRCode_Image";
            this.QRCode_Image.Size = new System.Drawing.Size(361, 249);
            this.QRCode_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QRCode_Image.TabIndex = 19;
            this.QRCode_Image.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(875, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 38);
            this.label3.TabIndex = 18;
            this.label3.Text = "QRCode";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(44, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Last_name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(38, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "First_name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_name
            // 
            this.L_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_name.Location = new System.Drawing.Point(278, 338);
            this.L_name.Name = "L_name";
            this.L_name.ReadOnly = true;
            this.L_name.Size = new System.Drawing.Size(234, 30);
            this.L_name.TabIndex = 15;
            // 
            // F_name
            // 
            this.F_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_name.Location = new System.Drawing.Point(278, 261);
            this.F_name.Name = "F_name";
            this.F_name.ReadOnly = true;
            this.F_name.Size = new System.Drawing.Size(234, 30);
            this.F_name.TabIndex = 13;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save_btn.Location = new System.Drawing.Point(694, 532);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(213, 57);
            this.save_btn.TabIndex = 24;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // Generate_QR_code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1215, 626);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.Load_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Mid_txt);
            this.Controls.Add(this.Generate_btn);
            this.Controls.Add(this.QRCode_Image);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_name);
            this.Controls.Add(this.F_name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Generate_QR_code";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate_QR_code";
            this.Load += new System.EventHandler(this.Generate_QR_code_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QRCode_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Load_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Mid_txt;
        private System.Windows.Forms.Button Generate_btn;
        private System.Windows.Forms.PictureBox QRCode_Image;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox L_name;
        private System.Windows.Forms.TextBox F_name;
        private System.Windows.Forms.Button save_btn;
    }
}