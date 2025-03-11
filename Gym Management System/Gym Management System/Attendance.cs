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
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;
using System.IO;
using AForge;
using ZXing.Aztec;

namespace Gym_Management_System
{
    public partial class Attendance : Form
    {
        private readonly DBConnection sqd;
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice finalframe;


        public Attendance()
        {
            InitializeComponent();
            sqd = new sqdbConnection();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                cmb_cam.Items.Add(Device.Name);

            }
            cmb_cam.SelectedIndex = 0;
            finalframe = new VideoCaptureDevice();
            att_date_txt.Text = DateTime.Now.ToString();

        }

        private void open_btn_Click(object sender, EventArgs e)
        {
           
            finalframe = new VideoCaptureDevice(CaptureDevice[cmb_cam.SelectedIndex].MonikerString);
            finalframe.NewFrame += new NewFrameEventHandler(finalframe_newframe);
            finalframe.Start();
        }

        private void finalframe_newframe(object sender, NewFrameEventArgs eventArgs)
        {
            Scanner_pic.Image = (Image)eventArgs.Frame.Clone();
        }

        private void Scan_btn_Click(object sender, EventArgs e)
        {
           
           timer1.Start();  
        }

        private void Attendance_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (finalframe.IsRunning == true)
            {
                finalframe.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            

        }
    

        private void timer2_Tick(object sender, EventArgs e)
        {
           
            
           
            
        }

        // function attendace done
        private void attendance_done()
        {
            SqlCommand c = new SqlCommand();
            c.Connection = sqd.Connection;
            c.CommandText = "select * from attendance where mid LIKE '%" + Mid_txt.Text + "%' and attendance_date = cast(GETDATE() as date)";
            int record = Convert.ToInt32(c.ExecuteScalar());
            if (record <= 0)
            {
                c.CommandText = "insert into attendance values (@f_name,@l_name,@phone,@add,@att_date,@id)";
                c.Parameters.AddWithValue("@id", Mid_txt.Text);
                c.Parameters.AddWithValue("@f_name", f_name_txt.Text);
                c.Parameters.AddWithValue("@l_name", L_name_txt.Text);
                c.Parameters.AddWithValue("@phone", Phone_txt.Text);
                c.Parameters.AddWithValue("@add", Address_txt.Text);
                c.Parameters.AddWithValue("@att_date", att_date_txt.Text);
                c.ExecuteNonQuery();
                MessageBox.Show("Member is attendance", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You must be Attendace Member only once a day ", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //expreation date
        private void expreation_date()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqd.Connection;
            cmd.CommandText = "select count(*) from Expiration_Date where mid = '" + Mid_txt.Text + "' and Expire_date <= CAST(GETDATE() as date)";
            int rec = Convert.ToInt32(cmd.ExecuteScalar());

            if (rec == 1)
            {
                MessageBox.Show("I can not scan it , because this member Expired date", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //check owner complete or not
                if (MessageBox.Show("This is member is attendance. Confirm?", "attendance data", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    attendance_done();
                }

            }
            else
            {
                //attendace done
                attendance_done();
            }

        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sqd.OpenConnection();
                //check id is exsit
                SqlCommand cm = new SqlCommand();
                cm.Connection = sqd.Connection;
                cm.CommandText = "select count(*) from N_Member where MID=@id";
                cm.Parameters.AddWithValue("@id", Mid_txt.Text);
                int count = (int)cm.ExecuteScalar();
            if (count == 0)
            {
                MessageBox.Show("ID is not exsit", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //check all data entriy
                if (Mid_txt.Text != "" && f_name_txt.Text != "" && L_name_txt.Text != "" && Phone_txt.Text != "" && Address_txt.Text != "")
                {

                    //expire attandance
                    expreation_date();

                }
                else
                {
                    MessageBox.Show("fields is empty", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            sqd.CloseConnection();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqd.OpenConnection();
            timer1.Stop();
            if (Mid_txt.Text != "")
            {
                if (finalframe.IsRunning == true)
                {
                    finalframe.Stop();
                }

                //if id is not exist
                SqlCommand cm = new SqlCommand();
                cm.Connection = sqd.Connection;
                cm.CommandText = "select count(*) from N_Member where MID=@id";
                cm.Parameters.AddWithValue("@id", Mid_txt.Text);
                int count = (int)cm.ExecuteScalar();
                if (count == 0)
                {
                    MessageBox.Show("ID is not exsit", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    View_attendance va = new View_attendance(this);
                    va.Show();
                }
                Mid_txt.Text = " ";
                f_name_txt.Text = " ";
                L_name_txt.Text = " ";
                Phone_txt.Text = " ";
                Address_txt.Text = " ";
            }
            else
            {
                MessageBox.Show("Member ID filed is empty","warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            sqd.CloseConnection();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
                BarcodeReader reader = new BarcodeReader();
                Result rs = reader.Decode((Bitmap)Scanner_pic.Image);

                if (rs != null)
                {
                    string decode = rs.ToString().Trim();
                    Mid_txt.Text = decode;
                    if (decode != null)
                    {

                        sqd.OpenConnection();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = sqd.Connection;
                        cmd.CommandText = "select First_name , Last_name , Phone , Maddress from N_Member where mid=@id ";
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@id", Mid_txt.Text);

                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            f_name_txt.Text = dr[0].ToString();
                            L_name_txt.Text = dr[1].ToString();
                            Phone_txt.Text = dr[2].ToString();
                            Address_txt.Text = dr[3].ToString();
                        }
                        sqd.CloseConnection();
                    }
                }
                else
                {
                    //MessageBox.Show("No QR Code Found","warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                }
        }

        private void cmb_cam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
