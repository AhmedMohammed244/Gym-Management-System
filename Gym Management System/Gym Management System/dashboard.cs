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

    public partial class dashboard : Form
    {
        private readonly DBConnection sqd;
        SqlCommand cmd;
        public dashboard()
        {
            InitializeComponent();
            sqd = new sqdbConnection();
        }

        private void dashboard_Load(object sender, EventArgs e)
        { 
            //total players
            sqd.OpenConnection();
            cmd = new SqlCommand();
            cmd.Connection = sqd.Connection;
            cmd.CommandText = "select count(*) from N_Member";
            int count = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            sqd.CloseConnection();
            total_p_lab.Text ="Total Players =  " + count.ToString();

            //total price
            sqd.OpenConnection();
            cmd = new SqlCommand();
            cmd.Connection = sqd.Connection;
            cmd.CommandText = "select SUM(Amount) from Pay ";
            int record =Convert.ToInt32( cmd.ExecuteScalar());
            cmd.Dispose();
            sqd.CloseConnection();
            Total_money_lab.Text = "Total Money =  " + record.ToString();

            //total Remaining
            sqd.OpenConnection();
            cmd = new SqlCommand();
            cmd.Connection = sqd.Connection;
            cmd.CommandText = "select count(*) from Expiration_Date where Expire_date <= CAST(GETDATE() as date) ";
            int rec = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            sqd.CloseConnection();
            tot_remain.Text = "Total Expiration Date =  " + rec.ToString();

        }

        private void tot_remain_Click(object sender, EventArgs e)
        {

        }
    }
}
