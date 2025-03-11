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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


       
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Member nm= new New_Member();
            nm.Show();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Member sm=new Search_Member();
            sm.Show();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_Member dm=new Delete_Member();
            dm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("LOG OUT !! , Confirm?", "Log Out", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
                Login_Page lg=new Login_Page();
                lg.Show();
            }
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment py=new Payment();
            py.Show();
        }

        private void expiredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expire_Date ex=new Expire_Date();
            ex.Show();
        }

        private void generateQRCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generate_QR_code qr=new Generate_QR_code();
            qr.Show();
        }

        private void scanQRCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendance ad=new Attendance();
            ad.Show();
        }

        private void toolStripMenuItem1_BackColorChanged(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dashboard dsh=new dashboard();
            dsh.Show();
        }
    }
}
