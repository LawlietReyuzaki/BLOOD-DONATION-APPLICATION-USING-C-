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
    public partial class AvlCases : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        System.Data.DataTable table;
        string path = @"Data Source=DESKTOP-65VB84J\MSSQLSERVER01;Initial Catalog=bloodbond1;Integrated Security=True";

        public AvlCases()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AvlCases_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(path);

            con.Open();

            //blood_label.Text = bloodgroup;
            //bloodgroup = "B+";
            //blood_label.Text = bloodgroup;

            //string sql = "select FirstName, LastName, EmailAddress,DOB,Phone_number,Blood_Group from Signup where Blood_Group = '" + bloodgroup + "'and City = '" + city_match + "' and Province = '" + prov_match + "'";

            string sql = "select * from Acceptordetails";
            table = new System.Data.DataTable();
            adpt = new SqlDataAdapter(sql, con);
            adpt.Fill(table);
            acceptorsmatch.DataSource = table;



            con.Close();
        }
    }
}
