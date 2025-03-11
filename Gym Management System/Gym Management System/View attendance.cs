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
    
    public partial class View_attendance : Form
    {
        private readonly DBConnection sqd;
        Attendance att;
        public View_attendance(Attendance atte)
        {
            InitializeComponent();
            sqd = new sqdbConnection();
            this.att = atte;
        }

        private void View_attendance_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void View_attendance_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void view_att_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void View_attendance_Load(object sender, EventArgs e)
        {
            cid_txt.Text=att.Mid_txt.Text;
            sqd.OpenConnection();
            if (cid_txt.Text != "")
            {
                //view all attendance
                string cmd = "select first_name,last_name,phone,attendance_date from attendance where mid =@id ";

                SqlDataAdapter ad = new SqlDataAdapter(cmd, sqd.Connection);
                ad.SelectCommand.Parameters.AddWithValue("@id", cid_txt.Text);

                DataSet ds = new DataSet();
                ad.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

                //View Days , Months , Years
                SqlCommand c = new SqlCommand();
                c.Connection = sqd.Connection;
                c.CommandText = "select count(*) from attendance where mid = '"+cid_txt.Text+"'";
                int record = Convert.ToInt32(c.ExecuteScalar());

                int day, month ,year ;
                year = (record / 365);
                month = ((record % 365)/30);
                day = ((record % 365)%30);
                years_txt.Text=year.ToString();
                months_txt.Text = month.ToString();
                days_txt.Text = day.ToString();

            }
            else
            {
                MessageBox.Show("Member Id is empty ", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sqd.CloseConnection();
        }

        private void days_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
