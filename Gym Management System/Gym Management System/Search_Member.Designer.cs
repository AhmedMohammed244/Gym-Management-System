namespace Gym_Management_System
{
    partial class Search_Member
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Member));
            this.label1 = new System.Windows.Forms.Label();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.View_member_searched = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.View_member_searched)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(315, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member_Id";
            // 
            // ID_txt
            // 
            this.ID_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_txt.Location = new System.Drawing.Point(584, 127);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(178, 38);
            this.ID_txt.TabIndex = 1;
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.Color.Maroon;
            this.Search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Search_btn.Location = new System.Drawing.Point(468, 208);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(156, 50);
            this.Search_btn.TabIndex = 2;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // View_member_searched
            // 
            this.View_member_searched.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.View_member_searched.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.View_member_searched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.View_member_searched.DefaultCellStyle = dataGridViewCellStyle1;
            this.View_member_searched.Location = new System.Drawing.Point(29, 284);
            this.View_member_searched.Name = "View_member_searched";
            this.View_member_searched.ReadOnly = true;
            this.View_member_searched.RowHeadersWidth = 51;
            this.View_member_searched.RowTemplate.Height = 24;
            this.View_member_searched.Size = new System.Drawing.Size(1085, 285);
            this.View_member_searched.TabIndex = 3;
            // 
            // Search_Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1149, 603);
            this.Controls.Add(this.View_member_searched);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search_Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search_Member";
            this.Load += new System.EventHandler(this.Search_Member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_member_searched)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.DataGridView View_member_searched;
    }
}