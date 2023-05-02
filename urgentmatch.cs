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

namespace bloodbond_app
{
    public partial class urgentmatch : Form
    {
        string path = @"Data Source=DESKTOP-65VB84J\MSSQLSERVER01;Initial Catalog=bloodbond1;Integrated Security=True";

        SqlConnection con;

        SqlCommand cmd;

        SqlDataAdapter adpt;

        System.Data.DataTable dt;
        string p, c, b;

        public urgentmatch()
        {
            InitializeComponent();
        }

        public urgentmatch(string city, string prov, string blg)
        {
            p = prov;
            c = city;
            b = blg;

            con = new SqlConnection(path);
            InitializeComponent();
        }


      


        private void urgentmatch_Load(object sender, EventArgs e)
        {
            con.Open();
          
            SqlCommand cmd = new SqlCommand("select FirstName, LastName, EmailAddress,Blood_Group,City,Province  from Signup where Blood_Group='" + b + "'and City='" + c + "'and Province='"+p+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
    }
}
