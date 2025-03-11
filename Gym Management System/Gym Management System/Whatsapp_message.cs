using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;
using WhatsAppApi.Parser;
using System.Data.SqlClient;

namespace Gym_Management_System
{
    public partial class Whatsapp_message : Form
    {
        string message = "عميلنا العزيز: يرجي العلم ان اشتراك الجيم انتهي في تاريخ ...... ويرجي دفعه المره القادمة نتمني لكم يوم سعيد  ";
        private readonly DBConnection sqd;
        public Whatsapp_message()
        {
            InitializeComponent();
            sqd = new sqdbConnection();
        }
        
        private void sendM(string number)
        {
            
            if(number == "")
            {
                MessageBox.Show("no number found","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if(number.Length <=15){
                number = "+20" + number;
            }
            number = number.Replace(" "," ");
            System.Diagnostics.Process.Start("http://api.whatsapp.com/send?phone=" + number +"&text="+ Message_txt.Text); 
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Whatsapp_message_Load(object sender, EventArgs e)
        {
            sqd.OpenConnection();
            Message_txt.Text = message;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqd.Connection;
            cmd.CommandText = "select ex.Mid from N_Member N ,Expiration_Date ex where N.MID = ex.Mid and ex.Expire_date <= GETDATE() order by ex.MID ASC; ";
            cmd.CommandType = CommandType.Text;

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmb_id.Items.Add(dr[0]);
            }
            dr.Close();
            sqd.CloseConnection();
        }

        private void Send_btn_Click(object sender, EventArgs e)
        {
            if (cmb_id.Text != "" && Number_txt.Text != "")
            {
                sendM(Number_txt.Text);
            }
            else
            {
                MessageBox.Show("Id or Phone number is empty","error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void cmb_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqd.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqd.Connection;
            cmd.CommandText = "select phone  from N_Member where mid=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", cmb_id.SelectedItem.ToString());



            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Number_txt.Text = dr[0].ToString();
            }
            dr.Close();
            sqd.CloseConnection();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Message_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
