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
    public partial class SOSDetails : Form
    {
      
        public SOSDetails()
        {
            InitializeComponent();
        }



        private void SOSDetails_Load(object sender, EventArgs e)
        {
            bloodgroup.Items.Add("A+");
            bloodgroup.Items.Add("A-");
            bloodgroup.Items.Add("B+");
            bloodgroup.Items.Add("B-");
            bloodgroup.Items.Add("O+");
            bloodgroup.Items.Add("O-");
            bloodgroup.Items.Add("AB+");
            bloodgroup.Items.Add("AB-");

            provcomboBox1.Items.Add("Punjab");
            provcomboBox1.Items.Add("Sindh");
            provcomboBox1.Items.Add("Blchstan");
            provcomboBox1.Items.Add("NWFP");
           

        }

        private void submit_Click(object sender, EventArgs e)
        {
            string pname = patient_txtbx.Text;

            pname_error.Text = "";


            for (int i = 0; i < pname.Length; i++)
            {
                if (pname[i] >= 'A' && pname[i] <= 'Z')
                    continue;
                else if (pname[i] >= 'a' && pname[i] <= 'z')
                    continue;
                else if (pname[i] == ' ')
                    continue;
                else
                {
                    pname_error.Text = "Invalid Name";
                    patient_txtbx.Text = "";
                    break;
                }


            }


            string blg, prov, city;

            blg = bloodgroup.Text;
            prov = provcomboBox1.SelectedItem.ToString();
            city = citybox.Text;

            urgentmatch obj = new urgentmatch(city,prov,blg);
            obj.ShowDialog();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
