
namespace BloodDonation_application
{
    public partial class Form1 : Form
    {
        string ans;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Form2 obj = new Form2();
            //obj.ShowDialog();

            bloodbond_app.AcceptorDetail obj = new bloodbond_app.AcceptorDetail();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CaseNumber cs = new CaseNumber();
            cs.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //WindowsFormsApp2.Form1 obj2 = new WindowsFormsApp2.Form1();
            WindowsFormsApp2.Ask ask = new WindowsFormsApp2.Ask();

            ask.ShowDialog();
            //obj2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void urgentneed_Click(object sender, EventArgs e)
        {
            
           bloodbond_app.SOSDetails sOS = new bloodbond_app.SOSDetails();
           sOS.ShowDialog();



           

            
        }

        private void donorsignin_Click(object sender, EventArgs e)
        {
           WindowsFormsApp2.DonorLogin donorLogin = new WindowsFormsApp2.DonorLogin();  
            donorLogin.ShowDialog();
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ans = "How long does it take to donate blood?\nWhole blood donation takes about 45-60 minutes.\nApheresis blood donation (double red cells, platelets, plasma) takes about 1 1/2-2 hours.\nDouble red cell donation takes about 30 minutes longer than a whole blood donation";
            info q2 = new info(ans);
            q2.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ans = "Drink extra fluids.\nAvoid strenuous physical activity or heavy lifting for about five hours.\nIf you feel lightheaded, lie down with your feet up until the feeling passes.\nKeep your bandage on and dry for the next five hours";
            info q2 = new info(ans);
            q2.ShowDialog();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            ans = "The blood volume is typically replaced within 24 hours.\nRed blood cells take between four to six weeks for complete replacement,\nwhich is why the FDA requires an eight-week wait between blood donations.\nYour body will not be affected adversely by the loss of the pint of blood.";
            info q2 = new info(ans);
            q2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ans = "Whole blood donors can donate up to 6 times a year.\nPlatelet apheresis donors may give every 7 days up to 24 times per year.";
            info q2 = new info(ans);
            q2.ShowDialog();
        }
    }
}