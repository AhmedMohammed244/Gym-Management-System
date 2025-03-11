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
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void Login_Page_Load(object sender, EventArgs e)
        {

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if(User_txt.Text=="admin" && Password_txt.Text == "admin")
            {
                this.Hide();
                Main fm=new Main();
                fm.Show();
            }
            else
            {
                MessageBox.Show("Incorrect user name or Password , Please Try again","message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void Login_Page_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Login_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
