using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing.Imaging;
using AForge.Video.DirectShow;
using System.IO;

namespace Gym_Management_System
{
    public partial class Generate_QR_code : Form
    {
        private readonly DBConnection sqd;
        public Generate_QR_code()
        {
            InitializeComponent();
            sqd = new sqdbConnection();
        }

        private void Generate_QR_code_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqd.OpenConnection();
            if (Mid_txt.Text != "")
            {
                SqlCommand c = new SqlCommand();
                c.Connection = sqd.Connection;
                c.CommandText = "select count(*) from N_Member where MID=@id";
                c.Parameters.AddWithValue("@id", Mid_txt.Text);
                int count = (int)c.ExecuteScalar();
                if (count == 0)
                {
                    MessageBox.Show("ID is not exist", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqd.Connection;
                    cmd.CommandText = "select first_name , Last_name , phone from N_Member where mid=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", Mid_txt.Text);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        F_name.Text = dr[0].ToString();
                        L_name.Text = dr[1].ToString();
                        phone_txt.Text = dr[2].ToString();
                    }
                    dr.Close();
                }
            }
            else
            {
                MessageBox.Show("Enter Id", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
           


            sqd.CloseConnection();

        }

        private void Generate_btn_Click(object sender, EventArgs e)
        {
            sqd.OpenConnection();
            if (Mid_txt.Text != "")
            {
                SqlCommand c = new SqlCommand();
                c.Connection = sqd.Connection;
                c.CommandText = "select count(*) from N_Member where MID=@id";
                c.Parameters.AddWithValue("@id", Mid_txt.Text);
                int count = (int)c.ExecuteScalar();
                if (count == 0)
                {
                    MessageBox.Show("ID is not exist", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
                    var mydata = QG.CreateQrCode(Mid_txt.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
                    var code = new QRCoder.QRCode(mydata);
                    QRCode_Image.Image = code.GetGraphic(50);
                }
            }
            else
            {
                MessageBox.Show("Enter Id", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sqd.CloseConnection();

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (Mid_txt.Text != "")
            {
                string initialty = @"D:\Gym Management system\QR code";
                var dialog = new SaveFileDialog();
                dialog.InitialDirectory = initialty;
                dialog.Filter = "PNG|*.png|JPEG|*.jpeg|BMP|*.bmp|GIF|*.gif";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    QRCode_Image.Image.Save(dialog.FileName);
                }
            }
            else
            {
                MessageBox.Show(" ID is empty", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
