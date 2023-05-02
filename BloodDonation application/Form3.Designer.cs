namespace BloodDonation_application
{
    partial class Form4
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
            this.donortable = new System.Windows.Forms.DataGridView();
            this.bloodgroup = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.donortable)).BeginInit();
            this.SuspendLayout();
            // 
            // donortable
            // 
            this.donortable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.donortable.Location = new System.Drawing.Point(113, 159);
            this.donortable.Name = "donortable";
            this.donortable.RowHeadersWidth = 51;
            this.donortable.RowTemplate.Height = 29;
            this.donortable.Size = new System.Drawing.Size(584, 259);
            this.donortable.TabIndex = 5;
            // 
            // bloodgroup
            // 
            this.bloodgroup.AutoSize = true;
            this.bloodgroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bloodgroup.ForeColor = System.Drawing.Color.Red;
            this.bloodgroup.Location = new System.Drawing.Point(511, 36);
            this.bloodgroup.Name = "bloodgroup";
            this.bloodgroup.Size = new System.Drawing.Size(135, 28);
            this.bloodgroup.TabIndex = 4;
            this.bloodgroup.Text = "BLood Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Available Donors For Blood Group: ";
            // 
            // SOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.donortable);
            this.Controls.Add(this.bloodgroup);
            this.Controls.Add(this.label1);
            this.Name = "SOS";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.donortable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView donortable;
        private Label bloodgroup;
        private Label label1;
    }
}