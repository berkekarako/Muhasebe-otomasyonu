namespace WinFormGiris.UrunIslemleri
{
    partial class frmStokCikis
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
            this.txtCariAdi = new System.Windows.Forms.TextBox();
            this.txtCikisKod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGenelToplam = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKdvToplam = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIskonto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAraToplam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrun = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCikisTarih = new System.Windows.Forms.DateTimePicker();
            this.txtCikisTur = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFaturaNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotBul = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LotSeriNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatisFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KdvOran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KdvDahil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Toplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KDVToplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.btnFatura = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlAlt.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCariAdi
            // 
            this.txtCariAdi.Location = new System.Drawing.Point(86, 88);
            this.txtCariAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtCariAdi.Name = "txtCariAdi";
            this.txtCariAdi.Size = new System.Drawing.Size(144, 20);
            this.txtCariAdi.TabIndex = 2;
            // 
            // txtCikisKod
            // 
            this.txtCikisKod.Location = new System.Drawing.Point(86, 63);
            this.txtCikisKod.Margin = new System.Windows.Forms.Padding(2);
            this.txtCikisKod.Name = "txtCikisKod";
            this.txtCikisKod.Size = new System.Drawing.Size(144, 20);
            this.txtCikisKod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Çıkış Kod :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtGenelToplam);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtKdvToplam);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtIskonto);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtAraToplam);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtUrun);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 537);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 102);
            this.panel1.TabIndex = 16;
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.Location = new System.Drawing.Point(470, 77);
            this.txtGenelToplam.Margin = new System.Windows.Forms.Padding(2);
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.Size = new System.Drawing.Size(144, 20);
            this.txtGenelToplam.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(373, 76);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Genel Toplam :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKdvToplam
            // 
            this.txtKdvToplam.Location = new System.Drawing.Point(470, 54);
            this.txtKdvToplam.Margin = new System.Windows.Forms.Padding(2);
            this.txtKdvToplam.Name = "txtKdvToplam";
            this.txtKdvToplam.Size = new System.Drawing.Size(144, 20);
            this.txtKdvToplam.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Red;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(373, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "Kdv Toplam :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIskonto
            // 
            this.txtIskonto.Location = new System.Drawing.Point(470, 32);
            this.txtIskonto.Margin = new System.Windows.Forms.Padding(2);
            this.txtIskonto.Name = "txtIskonto";
            this.txtIskonto.Size = new System.Drawing.Size(144, 20);
            this.txtIskonto.TabIndex = 11;
            this.txtIskonto.TextChanged += new System.EventHandler(this.txtIskonto_TextChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(373, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "İskonto :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAraToplam
            // 
            this.txtAraToplam.Location = new System.Drawing.Point(470, 9);
            this.txtAraToplam.Margin = new System.Windows.Forms.Padding(2);
            this.txtAraToplam.Name = "txtAraToplam";
            this.txtAraToplam.Size = new System.Drawing.Size(144, 20);
            this.txtAraToplam.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(373, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ara Toplam :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUrun
            // 
            this.txtUrun.FormattingEnabled = true;
            this.txtUrun.Location = new System.Drawing.Point(147, 9);
            this.txtUrun.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(144, 21);
            this.txtUrun.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 102);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtCikisTarih
            // 
            this.txtCikisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtCikisTarih.Location = new System.Drawing.Point(86, 185);
            this.txtCikisTarih.Margin = new System.Windows.Forms.Padding(2);
            this.txtCikisTarih.Name = "txtCikisTarih";
            this.txtCikisTarih.Size = new System.Drawing.Size(144, 20);
            this.txtCikisTarih.TabIndex = 9;
            // 
            // txtCikisTur
            // 
            this.txtCikisTur.FormattingEnabled = true;
            this.txtCikisTur.Items.AddRange(new object[] {
            "Normal Çıkış",
            "Konsinye Çıkış",
            "İade Edilen Çıkış"});
            this.txtCikisTur.Location = new System.Drawing.Point(86, 110);
            this.txtCikisTur.Margin = new System.Windows.Forms.Padding(2);
            this.txtCikisTur.Name = "txtCikisTur";
            this.txtCikisTur.Size = new System.Drawing.Size(144, 21);
            this.txtCikisTur.TabIndex = 8;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(2, 245);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(2);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(229, 65);
            this.txtAciklama.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.SteelBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 217);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Açıklama :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Çıkış Tarihi :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.SteelBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fatura No :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.SteelBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 87);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cari Adı :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.Location = new System.Drawing.Point(86, 149);
            this.txtFaturaNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(144, 20);
            this.txtFaturaNo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok Çıkış Kartı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Liste
            // 
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Barkod,
            this.UrunKodu,
            this.LotBul,
            this.LotSeriNo,
            this.Birim,
            this.StokMiktar,
            this.Miktar,
            this.BFiyat,
            this.SatisFiyat,
            this.KdvOran,
            this.KdvDahil,
            this.Toplam,
            this.KDVToplam});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 37);
            this.Liste.Margin = new System.Windows.Forms.Padding(2);
            this.Liste.MultiSelect = false;
            this.Liste.Name = "Liste";
            this.Liste.RowTemplate.Height = 24;
            this.Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Liste.Size = new System.Drawing.Size(1033, 602);
            this.Liste.TabIndex = 15;
            this.Liste.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Liste_CellBeginEdit);
            this.Liste.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellClick);
            this.Liste.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellEndEdit);
            this.Liste.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Liste_EditingControlShowing);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 41;
            // 
            // Barkod
            // 
            this.Barkod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Barkod.HeaderText = "Barkod";
            this.Barkod.Name = "Barkod";
            this.Barkod.Width = 66;
            // 
            // UrunKodu
            // 
            this.UrunKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunKodu.HeaderText = "UrunKodu";
            this.UrunKodu.Name = "UrunKodu";
            // 
            // LotBul
            // 
            this.LotBul.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LotBul.HeaderText = "Lot Bul";
            this.LotBul.Name = "LotBul";
            this.LotBul.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LotBul.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.LotBul.Width = 65;
            // 
            // LotSeriNo
            // 
            this.LotSeriNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LotSeriNo.HeaderText = "Lot Seri No";
            this.LotSeriNo.Name = "LotSeriNo";
            // 
            // Birim
            // 
            this.Birim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Birim.HeaderText = "Birim";
            this.Birim.Name = "Birim";
            this.Birim.ReadOnly = true;
            this.Birim.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Birim.Width = 54;
            // 
            // StokMiktar
            // 
            this.StokMiktar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.StokMiktar.HeaderText = "Stok Miktar";
            this.StokMiktar.Name = "StokMiktar";
            this.StokMiktar.Width = 86;
            // 
            // Miktar
            // 
            this.Miktar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Miktar.HeaderText = "Satış Miktar";
            this.Miktar.Name = "Miktar";
            this.Miktar.Width = 87;
            // 
            // BFiyat
            // 
            this.BFiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BFiyat.HeaderText = "Birim Fiyat";
            this.BFiyat.Name = "BFiyat";
            this.BFiyat.Width = 79;
            // 
            // SatisFiyat
            // 
            this.SatisFiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SatisFiyat.HeaderText = "Şatış Fiyatı";
            this.SatisFiyat.Name = "SatisFiyat";
            this.SatisFiyat.Width = 82;
            // 
            // KdvOran
            // 
            this.KdvOran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.KdvOran.HeaderText = "Kdv Oranı";
            this.KdvOran.Name = "KdvOran";
            this.KdvOran.Width = 79;
            // 
            // KdvDahil
            // 
            this.KdvDahil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.KdvDahil.HeaderText = "Kdv Dahil";
            this.KdvDahil.Name = "KdvDahil";
            this.KdvDahil.Width = 78;
            // 
            // Toplam
            // 
            this.Toplam.HeaderText = "Toplam";
            this.Toplam.Name = "Toplam";
            this.Toplam.Visible = false;
            // 
            // KDVToplam
            // 
            this.KDVToplam.HeaderText = "KDVToplam";
            this.KDVToplam.Name = "KDVToplam";
            this.KDVToplam.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.Liste);
            this.splitContainer1.Panel1.Controls.Add(this.pnlAlt);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.btnFatura);
            this.splitContainer1.Panel2.Controls.Add(this.txtCikisTarih);
            this.splitContainer1.Panel2.Controls.Add(this.txtCikisTur);
            this.splitContainer1.Panel2.Controls.Add(this.txtAciklama);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.btnKaydet);
            this.splitContainer1.Panel2.Controls.Add(this.txtFaturaNo);
            this.splitContainer1.Panel2.Controls.Add(this.txtCariAdi);
            this.splitContainer1.Panel2.Controls.Add(this.btnKapat);
            this.splitContainer1.Panel2.Controls.Add(this.txtCikisKod);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1356, 643);
            this.splitContainer1.SplitterDistance = 1037;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 4;
            // 
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.Color.Red;
            this.pnlAlt.Controls.Add(this.label1);
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAlt.Location = new System.Drawing.Point(0, 0);
            this.pnlAlt.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(1033, 37);
            this.pnlAlt.TabIndex = 14;
            // 
            // btnFatura
            // 
            this.btnFatura.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFatura.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFatura.Location = new System.Drawing.Point(0, 546);
            this.btnFatura.Margin = new System.Windows.Forms.Padding(2);
            this.btnFatura.Name = "btnFatura";
            this.btnFatura.Size = new System.Drawing.Size(312, 44);
            this.btnFatura.TabIndex = 11;
            this.btnFatura.Text = "Fatura Yaz";
            this.btnFatura.UseVisualStyleBackColor = false;
            this.btnFatura.Click += new System.EventHandler(this.btnFatura_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKaydet.Image = global::WinFormGiris.Properties.Resources.arrow;
            this.btnKaydet.Location = new System.Drawing.Point(0, 590);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(312, 49);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kayıt";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKapat.Location = new System.Drawing.Point(0, 0);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(312, 51);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "Formu Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Çıkış Türü :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmStokCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 643);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStokCikis";
            this.Text = "frmStokCikis";
            this.Load += new System.EventHandler(this.frmStokCikis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlAlt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCariAdi;
        private System.Windows.Forms.TextBox txtCikisKod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txtUrun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker txtCikisTarih;
        private System.Windows.Forms.ComboBox txtCikisTur;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtFaturaNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGenelToplam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKdvToplam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIskonto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAraToplam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKodu;
        private System.Windows.Forms.DataGridViewButtonColumn LotBul;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotSeriNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birim;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn BFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatisFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn KdvOran;
        private System.Windows.Forms.DataGridViewTextBoxColumn KdvDahil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Toplam;
        private System.Windows.Forms.DataGridViewTextBoxColumn KDVToplam;
        private System.Windows.Forms.Button btnFatura;
    }
}