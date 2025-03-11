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
using System.Globalization;

namespace Gym_Management_System
{
    public partial class Payment : Form
    {
        private readonly DBConnection sqd;

        DataSet ds;
        SqlDataAdapter ad;
        public Payment()
        {
            InitializeComponent();
            sqd = new sqdbConnection();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            sqd.OpenConnection();

            Payment_Date.Text = DateTime.Now.ToString();
            Expire_date.Text = DateTime.Now.AddDays(30).ToString();
            sqd.CloseConnection();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            sqd.OpenConnection();
            if (mem_id.Text != "")
            {
                SqlCommand cm = new SqlCommand();
                cm.Connection = sqd.Connection;
                cm.CommandText = "select count(*) from N_Member where MID=@id";
                cm.Parameters.AddWithValue("@id", mem_id.Text);
                int count = (int)cm.ExecuteScalar();
                if (count == 0)
                {
                    MessageBox.Show("Id is not Exist", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqd.Connection;
                    cmd.CommandText = "select first_name , Last_name from N_Member where MID=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", mem_id.Text);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Mem_name.Text = dr[0].ToString();
                        mem_l_name.Text = dr[1].ToString();
                    }
                    dr.Close();


                    string c = "select Amount , Remaining , Payment_Date , Expire_Date  from Pay where mid =@id ";

                    ad = new SqlDataAdapter(c, sqd.Connection);
                    ad.SelectCommand.Parameters.AddWithValue("@id", mem_id.Text);

                    ds = new DataSet();
                    ad.Fill(ds);
                    payment_grid_view.DataSource = ds.Tables[0];
                }
                
            }
            else
            {
                MessageBox.Show("Enter the Id", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sqd.CloseConnection();
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            sqd.OpenConnection();
            if (amount.Text != "" && remain_pay.Text != "" && mem_id.Text != "")
            {
                SqlCommand cm = new SqlCommand();
                cm.Connection = sqd.Connection;
                cm.CommandText = "select count(*) from N_Member where MID=@id";
                cm.Parameters.AddWithValue("@id", mem_id.Text);
                int count = (int)cm.ExecuteScalar();
                if (count == 0)
                {
                    MessageBox.Show("Id is not Exist", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqd.Connection;
                    cmd.CommandText = "insert into Pay (payment_Date,Expire_Date,Amount,Remaining,MID) values (@pay_date,@expire_date,@amount,@remain,@id); update Expiration_Date set Expire_date=@expire_date , Remaining=@remain where Mid=@id";
                    cmd.Parameters.AddWithValue("@amount", int.Parse(amount.Text));
                    cmd.Parameters.AddWithValue("@remain", int.Parse(remain_pay.Text));
                    cmd.Parameters.AddWithValue("@pay_date", Convert.ToDateTime(Payment_Date.Text));
                    cmd.Parameters.AddWithValue("@expire_date", Convert.ToDateTime(Expire_date.Text));
                    cmd.Parameters.AddWithValue("@id", int.Parse(mem_id.Text));

                    int r = cmd.ExecuteNonQuery();
                    if (r != -1)
                    {
                        mem_id.Text = "";
                        Mem_name.Text = "";
                        mem_l_name.Text = "";
                        amount.Text = "";
                        remain_pay.Text = "";
                        MessageBox.Show("Payment Successefully", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string c = "select Amount , Remaining , Payment_Date , Expire_Date  from Pay where mid =@id ";

                        ad = new SqlDataAdapter(c, sqd.Connection);
                        ad.SelectCommand.Parameters.AddWithValue("@id", mem_id.Text);

                        ds = new DataSet();
                        ad.Fill(ds);
                        payment_grid_view.DataSource = ds.Tables[0];
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter Missing Data", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            sqd.CloseConnection();
        }
    }
}
