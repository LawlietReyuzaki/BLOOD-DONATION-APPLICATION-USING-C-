namespace BloodDonation_application
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.donorsignup = new System.Windows.Forms.Button();
            this.ourvol = new System.Windows.Forms.Button();
            this.findblood = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.urgentneed = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.donorsignin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.home.SuspendLayout();
            this.SuspendLayout();
            // 
            // donorsignup
            // 
            this.donorsignup.BackColor = System.Drawing.Color.White;
            this.donorsignup.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.donorsignup.Location = new System.Drawing.Point(297, 37);
            this.donorsignup.Name = "donorsignup";
            this.donorsignup.Size = new System.Drawing.Size(135, 74);
            this.donorsignup.TabIndex = 0;
            this.donorsignup.Text = "Donate Blood";
            this.donorsignup.UseVisualStyleBackColor = false;
            this.donorsignup.Click += new System.EventHandler(this.button1_Click);
            // 
            // ourvol
            // 
            this.ourvol.BackColor = System.Drawing.Color.White;
            this.ourvol.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ourvol.Location = new System.Drawing.Point(438, 37);
            this.ourvol.Name = "ourvol";
            this.ourvol.Size = new System.Drawing.Size(123, 74);
            this.ourvol.TabIndex = 1;
            this.ourvol.Text = "Appointment";
            this.ourvol.UseVisualStyleBackColor = false;
            this.ourvol.Click += new System.EventHandler(this.button2_Click);
            // 
            // findblood
            // 
            this.findblood.BackColor = System.Drawing.Color.White;
            this.findblood.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.findblood.Location = new System.Drawing.Point(567, 37);
            this.findblood.Name = "findblood";
            this.findblood.Size = new System.Drawing.Size(118, 74);
            this.findblood.TabIndex = 3;
            this.findblood.Text = "Find Blood";
            this.findblood.UseVisualStyleBackColor = false;
            this.findblood.Click += new System.EventHandler(this.button4_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Red;
            this.home.Controls.Add(this.label3);
            this.home.Controls.Add(this.panel6);
            this.home.Controls.Add(this.urgentneed);
            this.home.Controls.Add(this.label2);
            this.home.Controls.Add(this.donorsignin);
            this.home.Controls.Add(this.label1);
            this.home.Controls.Add(this.panel4);
            this.home.Controls.Add(this.donorsignup);
            this.home.Controls.Add(this.ourvol);
            this.home.Controls.Add(this.findblood);
            this.home.Location = new System.Drawing.Point(2, 25);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(1108, 220);
            this.home.TabIndex = 4;
            this.home.Paint += new System.Windows.Forms.PaintEventHandler(this.home_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(836, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "www.bloodbond.com";
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::BloodDonation_application.Properties.Resources.pic3;
            this.panel6.Location = new System.Drawing.Point(836, 149);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(221, 51);
            this.panel6.TabIndex = 9;
            // 
            // urgentneed
            // 
            this.urgentneed.BackColor = System.Drawing.Color.Gold;
            this.urgentneed.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.urgentneed.Location = new System.Drawing.Point(567, 149);
            this.urgentneed.Name = "urgentneed";
            this.urgentneed.Size = new System.Drawing.Size(164, 55);
            this.urgentneed.TabIndex = 8;
            this.urgentneed.Text = "Urgent Need";
            this.urgentneed.UseVisualStyleBackColor = false;
            this.urgentneed.Click += new System.EventHandler(this.urgentneed_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(297, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "For Urgent Need For Blood\r\n";
            // 
            // donorsignin
            // 
            this.donorsignin.BackColor = System.Drawing.Color.DeepPink;
            this.donorsignin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.donorsignin.ForeColor = System.Drawing.Color.AliceBlue;
            this.donorsignin.Location = new System.Drawing.Point(1001, 55);
            this.donorsignin.Name = "donorsignin";
            this.donorsignin.Size = new System.Drawing.Size(94, 29);
            this.donorsignin.TabIndex = 6;
            this.donorsignin.Text = "SIgn in";
            this.donorsignin.UseVisualStyleBackColor = false;
            this.donorsignin.Click += new System.EventHandler(this.donorsignin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(741, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Already Have a Donor account? ";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::BloodDonation_application.Properties.Resources.logo;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(10, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 125);
            this.panel4.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::BloodDonation_application.Properties.Resources.pic1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(2, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 425);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::BloodDonation_application.Properties.Resources.pic2;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(622, 265);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 417);
            this.panel3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(268, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(607, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "Blood Donation Process";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(268, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(607, 54);
            this.button2.TabIndex = 7;
            this.button2.Text = "How does donation process work?";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Snow;
            this.button3.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(268, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(607, 54);
            this.button3.TabIndex = 7;
            this.button3.Text = "What should I do after donating blood?";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Snow;
            this.button4.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(268, 448);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(607, 54);
            this.button4.TabIndex = 7;
            this.button4.Text = "How long does blood donation take";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Snow;
            this.button5.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(268, 508);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(607, 54);
            this.button5.TabIndex = 7;
            this.button5.Text = "How long will it take to replenish the pint of blood I donate?";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Snow;
            this.button6.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(268, 565);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(607, 54);
            this.button6.TabIndex = 7;
            this.button6.Text = "How often can I donate blood";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Snow;
            this.button7.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(268, 625);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(607, 54);
            this.button7.TabIndex = 7;
            this.button7.Text = "Is it painful to donate blood?";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1109, 673);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.home);
            this.Name = "Form1";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.home.ResumeLayout(false);
            this.home.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button donorsignup;
        private Button ourvol;
        private Button findblood;
        private Panel home;
        private Panel panel2;
        private Panel panel3;
        private Button donorsignin;
        private Label label1;
        private Panel panel4;
        private Label label3;
        private Panel panel6;
        private Button urgentneed;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}