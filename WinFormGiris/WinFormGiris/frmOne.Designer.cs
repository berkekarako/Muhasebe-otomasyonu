namespace WinFormGiris
{
    partial class frmOne
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtVerici = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBoxFor = new System.Windows.Forms.ListBox();
            this.lstBoxWhile = new System.Windows.Forms.ListBox();
            this.lstBoxDoWhile = new System.Windows.Forms.ListBox();
            this.lstBoxIEnum = new System.Windows.Forms.ListBox();
            this.lstBoxForeach = new System.Windows.Forms.ListBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnIEnum = new System.Windows.Forms.Button();
            this.btnForeach = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlTop.Controls.Add(this.btnGonder);
            this.pnlTop.Controls.Add(this.txtVerici);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 42);
            this.pnlTop.TabIndex = 1;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(542, 12);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(75, 23);
            this.btnGonder.TabIndex = 3;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtVerici
            // 
            this.txtVerici.Location = new System.Drawing.Point(623, 12);
            this.txtVerici.Name = "txtVerici";
            this.txtVerici.Size = new System.Drawing.Size(177, 22);
            this.txtVerici.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // lstBoxFor
            // 
            this.lstBoxFor.FormattingEnabled = true;
            this.lstBoxFor.ItemHeight = 16;
            this.lstBoxFor.Location = new System.Drawing.Point(15, 96);
            this.lstBoxFor.Name = "lstBoxFor";
            this.lstBoxFor.Size = new System.Drawing.Size(120, 260);
            this.lstBoxFor.TabIndex = 3;
            // 
            // lstBoxWhile
            // 
            this.lstBoxWhile.FormattingEnabled = true;
            this.lstBoxWhile.ItemHeight = 16;
            this.lstBoxWhile.Location = new System.Drawing.Point(166, 96);
            this.lstBoxWhile.Name = "lstBoxWhile";
            this.lstBoxWhile.Size = new System.Drawing.Size(120, 260);
            this.lstBoxWhile.TabIndex = 3;
            // 
            // lstBoxDoWhile
            // 
            this.lstBoxDoWhile.FormattingEnabled = true;
            this.lstBoxDoWhile.ItemHeight = 16;
            this.lstBoxDoWhile.Location = new System.Drawing.Point(315, 96);
            this.lstBoxDoWhile.Name = "lstBoxDoWhile";
            this.lstBoxDoWhile.Size = new System.Drawing.Size(120, 260);
            this.lstBoxDoWhile.TabIndex = 3;
            // 
            // lstBoxIEnum
            // 
            this.lstBoxIEnum.FormattingEnabled = true;
            this.lstBoxIEnum.ItemHeight = 16;
            this.lstBoxIEnum.Location = new System.Drawing.Point(469, 96);
            this.lstBoxIEnum.Name = "lstBoxIEnum";
            this.lstBoxIEnum.Size = new System.Drawing.Size(120, 260);
            this.lstBoxIEnum.TabIndex = 3;
            // 
            // lstBoxForeach
            // 
            this.lstBoxForeach.FormattingEnabled = true;
            this.lstBoxForeach.ItemHeight = 16;
            this.lstBoxForeach.Location = new System.Drawing.Point(623, 96);
            this.lstBoxForeach.Name = "lstBoxForeach";
            this.lstBoxForeach.Size = new System.Drawing.Size(120, 260);
            this.lstBoxForeach.TabIndex = 3;
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(15, 362);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(120, 23);
            this.btnFor.TabIndex = 4;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(166, 362);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(120, 23);
            this.btnWhile.TabIndex = 4;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(315, 362);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(120, 23);
            this.btnDo.TabIndex = 4;
            this.btnDo.Text = "Do While";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnIEnum
            // 
            this.btnIEnum.Location = new System.Drawing.Point(469, 362);
            this.btnIEnum.Name = "btnIEnum";
            this.btnIEnum.Size = new System.Drawing.Size(120, 23);
            this.btnIEnum.TabIndex = 4;
            this.btnIEnum.Text = "IEnum";
            this.btnIEnum.UseVisualStyleBackColor = true;
            this.btnIEnum.Click += new System.EventHandler(this.btnIEnum_Click);
            // 
            // btnForeach
            // 
            this.btnForeach.Location = new System.Drawing.Point(623, 362);
            this.btnForeach.Name = "btnForeach";
            this.btnForeach.Size = new System.Drawing.Size(120, 23);
            this.btnForeach.TabIndex = 4;
            this.btnForeach.Text = "Foreach";
            this.btnForeach.UseVisualStyleBackColor = true;
            this.btnForeach.Click += new System.EventHandler(this.btnForeach_Click);
            // 
            // frmOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnForeach);
            this.Controls.Add(this.btnIEnum);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.lstBoxForeach);
            this.Controls.Add(this.lstBoxIEnum);
            this.Controls.Add(this.lstBoxDoWhile);
            this.Controls.Add(this.lstBoxWhile);
            this.Controls.Add(this.lstBoxFor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmOne";
            this.Text = "frmOne";
            this.Load += new System.EventHandler(this.frmOne_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtVerici;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBoxFor;
        private System.Windows.Forms.ListBox lstBoxWhile;
        private System.Windows.Forms.ListBox lstBoxDoWhile;
        private System.Windows.Forms.ListBox lstBoxIEnum;
        private System.Windows.Forms.ListBox lstBoxForeach;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnIEnum;
        private System.Windows.Forms.Button btnForeach;
    }
}