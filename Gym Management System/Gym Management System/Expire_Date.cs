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
    public partial class Expire_Date : Form
    {
        private readonly DBConnection sqd;
        public Expire_Date()
        {
            InitializeComponent();
            sqd = new sqdbConnection();
        }

        private void Expire_Date_Load(object sender, EventArgs e)
        {
            sqd.OpenConnection();
            //string cmd = "select N.MID , N.First_name , N.Last_name, p.Remaining , p.Expire_Date from N_Member N , Pay p where p.Expire_Date < GETDATE() and N.MID=p.MID ";
            string c = "select Ex.mid , Ex.First_name , Ex.Last_name , Ex.Remaining , Ex.Expire_date from Expiration_Date Ex,N_Member N where Ex.mid=N.mid and Ex.expire_date < GETDATE() ";
            SqlDataAdapter ad = new SqlDataAdapter(c, sqd.Connection);
            
            DataTable table = new DataTable();
            ad.Fill(table);
            view_expired_date.DataSource=table;

            sqd.CloseConnection();
            
        }

        private void view_expired_date_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Whatsapp_message wa=new Whatsapp_message();
            wa.Show();
        }
    }
        
}
