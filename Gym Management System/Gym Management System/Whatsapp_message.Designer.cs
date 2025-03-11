namespace Gym_Management_System
{
    partial class Whatsapp_message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Whatsapp_message));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Number_txt = new System.Windows.Forms.TextBox();
            this.Message_txt = new System.Windows.Forms.TextBox();
            this.Send_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_id = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(239, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(261, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Number_txt
            // 
            this.Number_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_txt.Location = new System.Drawing.Point(569, 205);
            this.Number_txt.Name = "Number_txt";
            this.Number_txt.Size = new System.Drawing.Size(263, 38);
            this.Number_txt.TabIndex = 1;
            this.Number_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Message_txt
            // 
            this.Message_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message_txt.Location = new System.Drawing.Point(569, 264);
            this.Message_txt.Multiline = true;
            this.Message_txt.Name = "Message_txt";
            this.Message_txt.Size = new System.Drawing.Size(463, 160);
            this.Message_txt.TabIndex = 2;
            this.Message_txt.TextChanged += new System.EventHandler(this.Message_txt_TextChanged);
            // 
            // Send_btn
            // 
            this.Send_btn.BackColor = System.Drawing.Color.Maroon;
            this.Send_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Send_btn.Location = new System.Drawing.Point(661, 465);
            this.Send_btn.Name = "Send_btn";
            this.Send_btn.Size = new System.Drawing.Size(227, 67);
            this.Send_btn.TabIndex = 3;
            this.Send_btn.Text = "Send";
            this.Send_btn.UseVisualStyleBackColor = false;
            this.Send_btn.Click += new System.EventHandler(this.Send_btn_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(232, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Member ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_id
            // 
            this.cmb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_id.FormattingEnabled = true;
            this.cmb_id.Location = new System.Drawing.Point(569, 126);
            this.cmb_id.Name = "cmb_id";
            this.cmb_id.Size = new System.Drawing.Size(128, 39);
            this.cmb_id.TabIndex = 0;
            this.cmb_id.SelectedIndexChanged += new System.EventHandler(this.cmb_id_SelectedIndexChanged);
            // 
            // Whatsapp_message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1249, 603);
            this.Controls.Add(this.cmb_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Send_btn);
            this.Controls.Add(this.Message_txt);
            this.Controls.Add(this.Number_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Whatsapp_message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Whatsapp_message";
            this.Load += new System.EventHandler(this.Whatsapp_message_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Number_txt;
        private System.Windows.Forms.TextBox Message_txt;
        private System.Windows.Forms.Button Send_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_id;
    }
}