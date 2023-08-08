using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormGiris.CariIslemleri;
using WinFormGiris.Entity;
using WinFormGiris.Fonksiyonlar;

namespace WinFormGiris.UrunIslemleri
{
    public partial class frmStokGiris : Form
    {
        WinFormDbEntities1 db = new WinFormDbEntities1();
        Numaralar N = new Numaralar();
        private bool edit = false;

        public string[] MyArray { get; set; }

        public frmStokGiris()
        {
            InitializeComponent();
        }

        private void frmStokGiris_Load(object sender, EventArgs e)
        {
            txtGirisKod.Text = N.GirisKod();
            Combo();

        }

        private void Combo()
        {
            try
            {
                var lst = db.tblUrunKayits.Select(i => i.UrunKodu).Distinct();
                foreach (string urun in lst)
                {
                    txtUrun.Items.Add(urun);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            try
            {
                int dgv;
                dgv = txtUrun.Items.Count;
                MyArray = new string[dgv];

                for (int i = 0; i < dgv; i++)
                {
                    MyArray[i] = txtUrun.Items[i].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void YeniKaydet()
        {
            Liste.AllowUserToAddRows = false;
            try
            {
                tblStokGirisUst ust = new tblStokGirisUst();
                ust.Aciklama = txtAciklama.Text;
                ust.CariId = db.tblCaris.First(x => x.CariAd == txtCariAdi.Text).Id;
                ust.FaturaNo = txtFaturaNo.Text;
                ust.GirisKod = txtGirisKod.Text;
                //Önemli aşağıdaki value yu kontrol et!!!!!!!!!!!!!!!!!!!
                //Value değer çalışıyor.
                ust.GirisTarih = txtGirisTarih.Value;
                ust.GirisTur = txtGirisTur.Text;

                db.tblStokGirisUsts.Add(ust);

                tblStokGirisAlt[] alt = new tblStokGirisAlt[Liste.RowCount];
                tblStokDurum[] stk = new tblStokDurum[Liste.RowCount];
                for (int i = 0; i < Liste.RowCount; i++)
                {
                    alt[i] = new tblStokGirisAlt();
                    alt[i].GirisKod = txtGirisKod.Text;
                    alt[i].GirisSira = i + 1;//int.Parse(Liste.Rows[i].Cells[0].Value.ToString());
                    alt[i].Barkod = Liste.Rows[i].Cells[1].Value.ToString();
                    alt[i].UrunKod = Liste.Rows[i].Cells[2].Value.ToString();
                    alt[i].LotSeriNo = Liste.Rows[i].Cells[3].Value.ToString();
                    alt[i].Birim = Liste.Rows[i].Cells[4].Value.ToString();
                    alt[i].Miktar = int.Parse(Liste.Rows[i].Cells[5].Value.ToString());
                    alt[i].BirimFiyat = decimal.Parse(Liste.Rows[i].Cells[6].Value.ToString());

                    db.tblStokGirisAlts.Add(alt[i]);
                    string brkd = Liste.Rows[i].Cells[1].Value.ToString();
                    stk[i] = new tblStokDurum();
                    var srg = (from s in db.tblStokDurums
                               where s.Barkod == brkd
                               select s).ToList();
                    
                    if (srg.Count == 0)
                    {
                        stk[i].Barkod = brkd;
                        stk[i].UrunKod = Liste.Rows[i].Cells[2].Value.ToString();
                        stk[i].LotSeriNo = Liste.Rows[i].Cells[3].Value.ToString();
                        stk[i].Birim = Liste.Rows[i].Cells[4].Value.ToString();
                        stk[i].Miktar = int.Parse(Liste.Rows[i].Cells[5].Value.ToString());

                        db.tblStokDurums.Add(stk[i]);
                        db.SaveChanges();
                    }
                    else
                    {
                        tblStokDurum sdurum = db.tblStokDurums.First(s => s.Barkod == brkd);
                        sdurum.Miktar += int.Parse(Liste.Rows[i].Cells[5].Value.ToString());
                        db.SaveChanges();
                    }

                }

                db.SaveChanges();
                MessageBox.Show("Başarıyla kaydedildi.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            /******************Giriş No İçin*********************************/
            var btnGirisNo = new Button();
            btnGirisNo.Size = new Size(25, txtGirisKod.ClientSize.Height + 2);
            btnGirisNo.Location = new Point(txtGirisKod.ClientSize.Width - btnGirisNo.Width, -1);
            btnGirisNo.Cursor = Cursors.Default;
            btnGirisNo.Image = Properties.Resources.pngwave_;
            txtGirisKod.Controls.Add(btnGirisNo);
            btnGirisNo.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            /******************CariAdı için*********************************/
            var btnCariAdi = new Button();
            btnCariAdi.Size = new Size(25, txtCariAdi.ClientSize.Height + 2);
            btnCariAdi.Location = new Point(txtCariAdi.ClientSize.Width - btnCariAdi.Width, -1);
            btnCariAdi.Cursor = Cursors.Default;
            btnCariAdi.Image = Properties.Resources.pngwave_;
            txtCariAdi.Controls.Add(btnCariAdi);
            btnCariAdi.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            base.OnLoad(e);

            btnCariAdi.Click += btnCariAdi_Click;
            btnGirisNo.Click += btnGirisNo_Click;
        }

        private void btnGirisNo_Click(object sender, EventArgs e)
        {
            frmStokGirisListe stkList = new frmStokGirisListe();
            stkList.ShowDialog();
            if (frmAnaSayfa.AktarmaS != "")
            {
                txtGirisKod.Text = frmAnaSayfa.AktarmaS;
                Ac(txtGirisKod.Text);
            }

            frmAnaSayfa.AktarmaS = "";
        }

        private void Ac(string girisKod)
        {
            Liste.Rows.Clear();
            Liste.AllowUserToAddRows = false;
            edit = true;
            tblStokGirisUst ust = db.tblStokGirisUsts.First(x => x.GirisKod == girisKod);
            txtAciklama.Text = ust.Aciklama;
            txtCariAdi.Text = ust.tblCari.CariAd;
            txtFaturaNo.Text = ust.FaturaNo;
            txtGirisTarih.Text = ust.GirisTarih.ToString();
            txtGirisTur.Text = ust.GirisTur;

            var srg = from x in db.tblStokGirisAlts
                      where x.GirisKod == girisKod
                      select x;
            var srg1 = db.tblStokGirisAlts.Where(x => x.GirisKod == girisKod);
            var srg2 = db.tblStokGirisAlts.AsNoTracking().Where(x => x.GirisKod == girisKod);
            int i = 0;
            foreach (tblStokGirisAlt k in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.GirisSira;
                Liste.Rows[i].Cells[1].Value = k.Barkod;
                Liste.Rows[i].Cells[2].Value = k.UrunKod;
                Liste.Rows[i].Cells[3].Value = k.LotSeriNo;
                Liste.Rows[i].Cells[4].Value = k.Birim;
                Liste.Rows[i].Cells[5].Value = k.Miktar;
                Liste.Rows[i].Cells[6].Value = k.BirimFiyat;

                i++;
            }
        }

        private void btnCariAdi_Click(object sender, EventArgs e)
        {
            frmCariListe carilist = new frmCariListe();
            carilist.ShowDialog();
            if (frmAnaSayfa.AktarmaS != "")
            {
                txtCariAdi.Text = frmAnaSayfa.AktarmaS;
                frmAnaSayfa.AktarmaS = "";
            }
        }

        private void Liste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;
            if (Liste.CurrentCell.ColumnIndex == 2 && txt != null)
            {
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt.AutoCompleteCustomSource.AddRange(MyArray);
            }
            else if (Liste.CurrentCell.ColumnIndex != 2 && txt != null)
            {
                txt.AutoCompleteMode = AutoCompleteMode.None;
            }
        }

        private void Liste_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2)
                {
                    var ukod = Liste.CurrentRow.Cells[2].Value.ToString();
                    var srg = db.tblUrunKayits.First(x => x.UrunKodu == ukod).tblBirim.Adi;


                    Liste.CurrentRow.Cells[4].Value = srg;
                }
                if (e.ColumnIndex == 3)
                {
                    var ukod = Liste.CurrentRow.Cells[2].Value.ToString();
                    var lot = Liste.CurrentRow.Cells[3].Value.ToString();
                    var barkod = ukod + "/" + lot;

                    Liste.CurrentRow.Cells[1].Value = barkod;

                }
            }
            catch (Exception)
            {
                Liste.CurrentRow.Cells[2].Value = "";

                MessageBox.Show("Girilen değerler hatalı. Lütfen kontrol ediniz!!!");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }

        private void txtGirisKod_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
