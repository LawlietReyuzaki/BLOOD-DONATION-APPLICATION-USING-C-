namespace BloodDonation_application
{
    partial class CaseNumber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cnicbx = new System.Windows.Forms.TextBox();
            this.CNICsearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(87, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Case Number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 27);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(543, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(87, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "CNIC";
            // 
            // cnicbx
            // 
            this.cnicbx.Location = new System.Drawing.Point(264, 200);
            this.cnicbx.Name = "cnicbx";
            this.cnicbx.Size = new System.Drawing.Size(239, 27);
            this.cnicbx.TabIndex = 3;
            // 
            // CNICsearch
            // 
            this.CNICsearch.BackColor = System.Drawing.Color.Red;
            this.CNICsearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CNICsearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CNICsearch.Location = new System.Drawing.Point(543, 190);
            this.CNICsearch.Name = "CNICsearch";
            this.CNICsearch.Size = new System.Drawing.Size(106, 52);
            this.CNICsearch.TabIndex = 4;
            this.CNICsearch.Text = "Submit";
            this.CNICsearch.UseVisualStyleBackColor = false;
            this.CNICsearch.Click += new System.EventHandler(this.CNICsearch_Click);
            // 
            // CaseNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(712, 332);
            this.Controls.Add(this.CNICsearch);
            this.Controls.Add(this.cnicbx);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CaseNumber";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.CaseNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private TextBox cnicbx;
        private Button CNICsearch;
    }
}