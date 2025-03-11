using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Gym_Management_System
{
    public partial class Search_Member : Form
    {
        private readonly DBConnection sqd;

        public Search_Member()
        {
            InitializeComponent();
            sqd = new sqdbConnection();
        }

        private void Search_Member_Load(object sender, EventArgs e)
        {
            sqd.OpenConnection();
            string cmd = "select * from N_Member ";

            SqlDataAdapter ad = new SqlDataAdapter(cmd, sqd.Connection);

            DataSet ds = new DataSet();
            ad.Fill(ds);

            View_member_searched.DataSource = ds.Tables[0];

            sqd.CloseConnection();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            sqd.OpenConnection();
            if (ID_txt.Text != "")
            {
                string cmd= "select * from N_Member where mid =@id ";

                SqlDataAdapter ad = new SqlDataAdapter(cmd,sqd.Connection);
                ad.SelectCommand.Parameters.AddWithValue("@id",ID_txt.Text);

                DataSet ds = new DataSet();
                ad.Fill(ds);

                View_member_searched.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Member Id is empty ","message", MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }
            sqd.CloseConnection();
        }
    }
}
