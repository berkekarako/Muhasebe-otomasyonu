namespace WinFormGiris.Fatura
{
    partial class frmFatura
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crystalPrint = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.txtKod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(811, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 547);
            this.panel1.TabIndex = 0;
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(31, 137);
            this.txtKod.Margin = new System.Windows.Forms.Padding(2);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(134, 20);
            this.txtKod.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kod No :";
            // 
            // crystalPrint
            // 
            this.crystalPrint.ActiveViewIndex = -1;
            this.crystalPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalPrint.Location = new System.Drawing.Point(0, 0);
            this.crystalPrint.Name = "crystalPrint";
            this.crystalPrint.Size = new System.Drawing.Size(811, 547);
            this.crystalPrint.TabIndex = 1;
            // 
            // frmFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 547);
            this.Controls.Add(this.crystalPrint);
            this.Controls.Add(this.panel1);
            this.Name = "frmFatura";
            this.Text = "frmFatura";
            this.Load += new System.EventHandler(this.frmFatura_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalPrint;
    }
}