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
    public partial class Delete_Member : Form
    {
        private readonly DBConnection sqd;
        public Delete_Member()
        {
            InitializeComponent();
            sqd = new sqdbConnection();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            sqd.OpenConnection();
            if (ID_txt.Text!="")
            {

                SqlCommand c = new SqlCommand();
                c.Connection = sqd.Connection;
                c.CommandText = "select count(*) from N_Member where MID=@id";
                c.Parameters.AddWithValue("@id", ID_txt.Text);
                int count = (int)c.ExecuteScalar();
                if (count == 0)
                {
                    MessageBox.Show("ID is not exsit","warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("This is will delete your data. Confirm?", "Delete data", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        string cmd = "delete from N_Member where mid=@id; delete from pay where mid=@id;delete from Expiration_Date where mid=@id; delete from attendance where mid=@id; ";

                        SqlDataAdapter ad = new SqlDataAdapter(cmd, sqd.Connection);
                        ad.SelectCommand.Parameters.AddWithValue("@id", ID_txt.Text);

                        DataSet ds = new DataSet();
                        ad.Fill(ds);

                        MessageBox.Show("Member is deleted", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ID_txt.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter the Member_Id ", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sqd.CloseConnection();
        }

        private void Delete_Member_Load(object sender, EventArgs e)
        {

        }

        private void ID_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
