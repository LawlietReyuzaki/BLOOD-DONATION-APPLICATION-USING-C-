namespace WindowsFormsApp2
{
    partial class allrespectivecases
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
            this.casesgrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.casesgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // casesgrid
            // 
            this.casesgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.casesgrid.Location = new System.Drawing.Point(79, 51);
            this.casesgrid.Name = "casesgrid";
            this.casesgrid.RowHeadersWidth = 51;
            this.casesgrid.RowTemplate.Height = 24;
            this.casesgrid.Size = new System.Drawing.Size(631, 317);
            this.casesgrid.TabIndex = 0;
            // 
            // allrespectivecases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.casesgrid);
            this.Name = "allrespectivecases";
            this.Text = "ALL RESPECTIVE CASES";
            this.Load += new System.EventHandler(this.allrespectivecases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.casesgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView casesgrid;
    }
}