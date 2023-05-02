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
using System.IO;

namespace WindowsFormsApp2
{
    public partial class appointdonor : Form
    {
        string path = @"Data Source=DESKTOP-65VB84J\MSSQLSERVER01;Initial Catalog=bloodbond1;Integrated Security=True";

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        System.Data.DataTable dt, dt2;
        string donorid;
        string sql;
        public appointdonor()
        {
            InitializeComponent();
        }

        public appointdonor(string id)
        {
            donorid = id;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sql = "select * from Appointment where DonorID="+donorid;
            dt = new System.Data.DataTable();
            dt2 = new System.Data.DataTable();
            con = new SqlConnection(path);
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            adpt = new SqlDataAdapter(sql, con);
            adpt.Fill(dt);
            hosptiallabel.Text = dt.Rows[0]["hostpitalname"].ToString();
            hospitaladdress.Text = dt.Rows[0]["hospitaladdress"].ToString();
            floorlabel.Text = dt.Rows[0]["floornumber"].ToString();
            roomlabel.Text = dt.Rows[0]["roomnumber"].ToString();
            messagelabel.Text = dt.Rows[0]["additionalnote"].ToString();
            datelabel.Text = dt.Rows[0]["appointmentdate"].ToString();
            timelable.Text = dt.Rows[0]["appointmenttime"].ToString();
            string patid = dt.Rows[0]["AcceptorID"].ToString();


            string sql2 = "select * from AcceptorDetails where patientID=" + patid;
            cmd = new SqlCommand(sql2, con);
            cmd.ExecuteNonQuery();
            adpt = new SqlDataAdapter(sql2, con);
            adpt.Fill(dt2);

              firstname.Text = dt2.Rows[0]["PatientName"].ToString();
              bloodgroup.Text = dt2.Rows[0]["BloodGroup"].ToString();
              citylabel.Text = dt2.Rows[0]["City"].ToString();
              hosptiallabel.Text = dt2.Rows[0]["HospitalName"].ToString();
              provincelabel.Text = dt2.Rows[0]["Province"].ToString();

            int count = dt2.Rows.Count;

            if (count > 0)
            {
                MessageBox.Show("hello");
                var data = (Byte[])dt2.Rows[count - 1]["picture"];
                var stream = new MemoryStream(data);
                accpicbox.Image = Image.FromStream(stream);
            }




            con.Close();
        }
    }
}
