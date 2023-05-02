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

namespace BloodDonation_application
{
    

    public partial class CaseNumber : Form
    {
        SqlConnection con;
        SqlDataAdapter adpt;
        SqlCommand cmd;
        System.Data.DataTable dt;
        public CaseNumber()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag = 1;

            if(textBox1.Text == "")
            {
                flag = 0;
                MessageBox.Show("You haven't entered any case number");
            }


            if (flag == 1)
            {
                string Case = textBox1.Text;
                WindowsFormsApp2.MakeAppointment obj = new WindowsFormsApp2.MakeAppointment(Case);
                obj.Show();
                this.Hide();
            }
        }

        private void CaseNumber_Load(object sender, EventArgs e)
        {
            string path = @"Data Source=DESKTOP-65VB84J\MSSQLSERVER01;Initial Catalog=bloodbond1;Integrated Security=True";
            con = new SqlConnection(path);
        }

        private void CNICsearch_Click(object sender, EventArgs e)
        {

            int flag = 1;

            if (cnicbx.Text == "")
            {
                flag = 0;
                MessageBox.Show("You haven't entered any case number");
            }


            if (flag == 1)
            {
                try
                {
                    string sqlstr = "select * from Signup where donorid in (select donorID from Cases where acceptorID in (select patientID from AcceptorDetails where CNIC="+cnicbx.Text+"))";

                    con.Open();
                    cmd = new SqlCommand(sqlstr, con);
                    cmd.ExecuteNonQuery();
                    adpt = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adpt.Fill(dt);
                    con.Close();

                    string fname = dt.Rows[0]["FirstName"].ToString();
                    string lname = dt.Rows[0]["LastName"].ToString();
                    string blood = dt.Rows[0]["Blood_Group"].ToString();
                    string city = dt.Rows[0]["City"].ToString();
                    string province = dt.Rows[0]["Province"].ToString();
                    string did = dt.Rows[0]["DonorID"].ToString();
                    //  byte[] pic = dt.Rows[0]["donorpic"].ToString();
                    string accinc = cnicbx.Text;
                    showdonortopat obj = new showdonortopat(did, fname, lname, blood, city, province, accinc);
                    obj.ShowDialog();
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Wrong CNIC entered");
                }

                /*
                con.Open();
                string sql = "select caseID from Cases where acceptorID = (select patientID from AcceptorDetails where CNIC =" + cnicbx.Text + ")";


                MessageBox.Show(sql);
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                adpt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adpt.Fill(dt);
                con.Close();

                string pass = dt.Rows[0]["caseID"].ToString();
                WindowsFormsApp2.MakeAppointment obj2 = new WindowsFormsApp2.MakeAppointment(pass);
                obj2.Show();
                this.Hide();*/
            }

        }
    }
}
