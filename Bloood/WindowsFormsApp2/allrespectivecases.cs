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

namespace WindowsFormsApp2
{
    public partial class allrespectivecases : Form
    {
        SqlDataAdapter adpt;
        System.Data.DataTable dt;
        SqlCommand cmd;
        SqlConnection con;
        string path = @"Data Source=DESKTOP-65VB84J\MSSQLSERVER01;Initial Catalog=bloodbond1;Integrated Security=True";
        string city, province;

        public allrespectivecases()
        {
            InitializeComponent();
        }

        public allrespectivecases(string city, string province)
        {
            this.city = city;
            this.province = province;
            InitializeComponent();

        }

        private void allrespectivecases_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(path);
            con.Open();
            string sql = "select * from AcceptorDetails where City='" + city + "' and province='" + province + "'";
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            adpt = new SqlDataAdapter(sql, con);
            dt = new System.Data.DataTable();
            adpt.Fill(dt);

            int temp = dt.Rows.Count;
            string tempmsg = temp.ToString();
            MessageBox.Show(tempmsg);

            con.Close();

           casesgrid.DataSource = dt;
        }
    }
}
