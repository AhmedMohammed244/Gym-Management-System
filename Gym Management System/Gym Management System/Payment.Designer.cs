namespace Gym_Management_System
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.mem_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.remain_pay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Payment_Date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.pay_btn = new System.Windows.Forms.Button();
            this.Mem_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.payment_grid_view = new System.Windows.Forms.DataGridView();
            this.mem_l_name = new System.Windows.Forms.TextBox();
            this.Expire_date = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.payment_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(29, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member_Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mem_id
            // 
            this.mem_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mem_id.Location = new System.Drawing.Point(306, 145);
            this.mem_id.Name = "mem_id";
            this.mem_id.Size = new System.Drawing.Size(99, 38);
            this.mem_id.TabIndex = 1;
            this.mem_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mem_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(106, 556);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // amount
            // 
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(380, 557);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(167, 38);
            this.amount.TabIndex = 3;
            // 
            // remain_pay
            // 
            this.remain_pay.BackColor = System.Drawing.Color.White;
            this.remain_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remain_pay.Location = new System.Drawing.Point(380, 638);
            this.remain_pay.Name = "remain_pay";
            this.remain_pay.Size = new System.Drawing.Size(167, 38);
            this.remain_pay.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(86, 638);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Remaining";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Payment_Date
            // 
            this.Payment_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_Date.Location = new System.Drawing.Point(342, 330);
            this.Payment_Date.Name = "Payment_Date";
            this.Payment_Date.Size = new System.Drawing.Size(331, 38);
            this.Payment_Date.TabIndex = 7;
            this.Payment_Date.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(29, 330);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(291, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "Payment_Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(29, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 43);
            this.label5.TabIndex = 8;
            this.label5.Text = "Expire_Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Maroon;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search_btn.Location = new System.Drawing.Point(476, 145);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(176, 56);
            this.search_btn.TabIndex = 10;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // pay_btn
            // 
            this.pay_btn.BackColor = System.Drawing.Color.Maroon;
            this.pay_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pay_btn.Location = new System.Drawing.Point(590, 719);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(265, 78);
            this.pay_btn.TabIndex = 11;
            this.pay_btn.Text = "Pay";
            this.pay_btn.UseVisualStyleBackColor = false;
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
            // 
            // Mem_name
            // 
            this.Mem_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mem_name.Location = new System.Drawing.Point(1056, 229);
            this.Mem_name.Name = "Mem_name";
            this.Mem_name.ReadOnly = true;
            this.Mem_name.Size = new System.Drawing.Size(222, 38);
            this.Mem_name.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(732, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 36);
            this.label6.TabIndex = 13;
            this.label6.Text = "Member_Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // payment_grid_view
            // 
            this.payment_grid_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payment_grid_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.payment_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.payment_grid_view.DefaultCellStyle = dataGridViewCellStyle2;
            this.payment_grid_view.Location = new System.Drawing.Point(732, 288);
            this.payment_grid_view.Name = "payment_grid_view";
            this.payment_grid_view.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payment_grid_view.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.payment_grid_view.RowHeadersWidth = 51;
            this.payment_grid_view.RowTemplate.Height = 24;
            this.payment_grid_view.RowTemplate.ReadOnly = true;
            this.payment_grid_view.Size = new System.Drawing.Size(789, 388);
            this.payment_grid_view.TabIndex = 14;
            // 
            // mem_l_name
            // 
            this.mem_l_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mem_l_name.Location = new System.Drawing.Point(1268, 229);
            this.mem_l_name.Name = "mem_l_name";
            this.mem_l_name.ReadOnly = true;
            this.mem_l_name.Size = new System.Drawing.Size(253, 38);
            this.mem_l_name.TabIndex = 16;
            // 
            // Expire_date
            // 
            this.Expire_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expire_date.Location = new System.Drawing.Point(342, 440);
            this.Expire_date.Name = "Expire_date";
            this.Expire_date.Size = new System.Drawing.Size(331, 38);
            this.Expire_date.TabIndex = 17;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1617, 830);
            this.Controls.Add(this.Expire_date);
            this.Controls.Add(this.mem_l_name);
            this.Controls.Add(this.payment_grid_view);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Mem_name);
            this.Controls.Add(this.pay_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Payment_Date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.remain_pay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mem_id);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payment_grid_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mem_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox remain_pay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Payment_Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button pay_btn;
        private System.Windows.Forms.TextBox Mem_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView payment_grid_view;
        private System.Windows.Forms.TextBox mem_l_name;
        private System.Windows.Forms.TextBox Expire_date;
    }
}