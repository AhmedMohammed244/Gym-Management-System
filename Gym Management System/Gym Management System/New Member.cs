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

namespace Gym_Management_System
{
    public partial class New_Member : Form
    {
        private readonly DBConnection sqd;
        public New_Member()
        {
            InitializeComponent();
            sqd = new sqdbConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Join_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void New_Member_Load(object sender, EventArgs e)
        {
            sqd.OpenConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqd.Connection;
            cmd.CommandText = "select mid from N_Member";
            cmd.CommandType = CommandType.Text;

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmb_Id.Items.Add(dr[0]);
            }
            dr.Close();
            sqd.CloseConnection();
        }

        private void cmb_Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqd.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqd.Connection;
            cmd.CommandText = "select first_name , last_name , phone , Maddress ,join_date from N_Member where mid=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", cmb_Id.SelectedItem.ToString());



            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                First_Name.Text = dr[0].ToString();
                Last_Name.Text = dr[1].ToString();
                phone.Text = dr[2].ToString();
                address.Text = dr[3].ToString();
                join_date.Text = dr[4].ToString();
            }
            dr.Close();
            sqd.CloseConnection();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            sqd.OpenConnection();

            if (cmb_Id.Text != "" && First_Name.Text != "" && Last_Name.Text != "" && phone.Text != "" && address.Text != "" && join_date.Text != "" )
            {
                    SqlCommand c = new SqlCommand();
                    c.Connection = sqd.Connection;
                    c.CommandText = "select count(*) from N_Member where MID=@id";
                    c.Parameters.AddWithValue("@id", cmb_Id.Text);
                    int count = (int)c.ExecuteScalar();
                    if (count == 0)
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = sqd.Connection;
                        cmd.CommandText = "insert into N_Member values (@id,@f_name,@l_name,@ph,@add,@j_date); insert into Expiration_Date (Mid,First_name,Last_name) values (@id,@f_name,@l_name)";
                        cmd.Parameters.AddWithValue("@id", cmb_Id.Text);
                        cmd.Parameters.AddWithValue("@f_name", First_Name.Text);
                        cmd.Parameters.AddWithValue("@l_name", Last_Name.Text);
                        cmd.Parameters.AddWithValue("@ph", int.Parse(phone.Text));
                        cmd.Parameters.AddWithValue("@add", address.Text);
                        cmd.Parameters.AddWithValue("@j_date", join_date.Text);

                        int r = cmd.ExecuteNonQuery();
                        if (r != -1)
                        {
                            cmb_Id.Items.Add(cmb_Id.Text);
                            MessageBox.Show("New Member is add", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Member_ID is already exists", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                

            }
            else {
                MessageBox.Show("Please complete the data ", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            sqd.OpenConnection();

            cmb_Id.Text = "";
            First_Name.Text = "";
            Last_Name.Text = "";
            phone.Text = "";
            address.Text = "";
            join_date.Text = "";

            sqd.CloseConnection();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            sqd.OpenConnection();

            if (cmb_Id.Text != "" && First_Name.Text != "" && Last_Name.Text != "" && phone.Text != "" && address.Text != ""&& join_date.Text != "" )
            {
                SqlCommand c = new SqlCommand();
                c.Connection = sqd.Connection;

                c.CommandText = "update N_Member set first_name=@f_name , last_name=@l_name , phone=@pho ,Maddress=@add, join_date=@j_date where mid=@id";
                c.Parameters.AddWithValue("@f_name", First_Name.Text);
                c.Parameters.AddWithValue("@l_name", Last_Name.Text);
                c.Parameters.AddWithValue("@pho", phone.Text.ToString());
                c.Parameters.AddWithValue("@add", address.Text);
                c.Parameters.AddWithValue("@j_date", join_date.Text.ToString());
                c.Parameters.AddWithValue("@id", cmb_Id.SelectedItem.ToString());

                int r = c.ExecuteNonQuery();

                if (r != -1)
                {
                    MessageBox.Show("Updated successufully", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                sqd.CloseConnection();

            }
            else
            {
                MessageBox.Show("Member fields is empty ", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
