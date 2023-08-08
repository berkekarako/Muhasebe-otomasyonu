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
using WinFormGiris.Fatura;

namespace WinFormGiris.UrunIslemleri
{
    public partial class frmStokCikis : Form
    {
        WinFormDbEntities1 db = new WinFormDbEntities1();
        Numaralar N = new Numaralar();
        bool edit = false;

        public string[] MyArray { get; set; }
        public frmStokCikis()
        {
            InitializeComponent();
        }

        private void frmStokCikis_Load(object sender, EventArgs e)
        {
            txtCikisKod.Text = N.CikisKod();
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

        protected override void OnLoad(EventArgs e)
        {
            /******************Giriş No İçin*********************************/
            var btnCikisNo = new Button();
            btnCikisNo.Size = new Size(25, txtCikisKod.ClientSize.Height + 2);
            btnCikisNo.Location = new Point(txtCikisKod.ClientSize.Width - btnCikisNo.Width, -1);
            btnCikisNo.Cursor = Cursors.Default;
            btnCikisNo.Image = Properties.Resources.pngwave_;
            txtCikisKod.Controls.Add(btnCikisNo);
            btnCikisNo.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

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
            btnCikisNo.Click += btnCikisNo_Click;
        }

        private void btnCikisNo_Click(object sender, EventArgs e)
        {
            frmStokCikisListesi stkList = new frmStokCikisListesi();
            stkList.ShowDialog();
            if (frmAnaSayfa.AktarmaS != "")
            {
                txtCikisKod.Text = frmAnaSayfa.AktarmaS;
                Ac(txtCikisKod.Text);
            }

            frmAnaSayfa.AktarmaS = "";
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

        private void Ac(string cikisKod)
        {
            edit = true;
            Liste.Rows.Clear();
            Liste.AllowUserToAddRows = false;
            edit = true;
            tblStokCikisUst ust = db.tblStokCikisUsts.First(x => x.CikisKod == cikisKod);
            txtAciklama.Text = ust.Aciklama;
            txtCariAdi.Text = ust.tblCari.CariAd;
            txtFaturaNo.Text = ust.FaturaNo;
            txtCikisTarih.Text = ust.CikisTarih.ToString();
            txtCikisTur.Text = ust.CikisTur;
            txtAraToplam.Text = ust.AraToplam.ToString();
            txtGenelToplam.Text = ust.GenelToplam.ToString();
            txtIskonto.Text = ust.Iskonto.ToString();
            txtKdvToplam.Text = ust.KdvToplam.ToString();
            var srg = from x in db.tblStokCikisAlts
                      where x.CikisKod == cikisKod
                      select x;
            //var srg1 = db.tblStokCikisAlts.Where(x => x.CikisKod == cikisKod);
            //var srg2 = db.tblStokCikisAlts.AsNoTracking().Where(x => x.CikisKod == cikisKod);

            int i = 0;
            foreach (tblStokCikisAlt k in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.Barkod;
                Liste.Rows[i].Cells[2].Value = k.UrunKod;
                Liste.Rows[i].Cells[4].Value = k.LotSeriNo;
                Liste.Rows[i].Cells[5].Value = k.Birim;
                Liste.Rows[i].Cells[6].Value = k.Miktar;
                Liste.Rows[i].Cells[7].Value = k.SatisFiyat;
                Liste.Rows[i].Cells[8].Value = k.BirimFiyat;
                Liste.Rows[i].Cells[9].Value = k.BirimFiyat*1.2m;
                Liste.Rows[i].Cells[10].Value = k.KdvOran;
                Liste.Rows[i].Cells[11].Value = k.KdvDahil;

                i++;
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

        private void Liste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Liste.CurrentRow!=null && (e.ColumnIndex==3 && Liste.CurrentRow.Cells[2].Value!=null && Liste.CurrentRow.Cells[2].Value.ToString()!=""))
            {
                var i = Liste.CurrentRow.Index;

                frmAnaSayfa.UrunKodBul = Liste.CurrentRow.Cells[2].Value.ToString();

                var brkd = StokCikisLot(true);

                if (brkd != "")
                {
                    LotAc(brkd);
                }
            }
        }

        private void LotAc(string brkd)
        {
            try
            {
                var stok = db.tblStokDurums.First(s => s.Barkod == brkd);
                var bFiyat = db.tblStokGirisAlts.First(x => x.Barkod == brkd).BirimFiyat;
                var kdvOran = db.tblUrunKayits.First(x => x.UrunKodu==stok.UrunKod).KdvOran;
                
                if (Liste.CurrentRow!=null)
                {
                    Liste.CurrentRow.Cells[1].Value = stok.Barkod;
                    Liste.CurrentRow.Cells[4].Value = stok.LotSeriNo;
                    Liste.CurrentRow.Cells[5].Value = stok.Birim;
                    Liste.CurrentRow.Cells[6].Value = stok.Miktar;
                    Liste.CurrentRow.Cells[8].Value = bFiyat;
                    Liste.CurrentRow.Cells[9].Value = bFiyat*1.2m;
                    Liste.CurrentRow.Cells[10].Value = kdvOran;
                    Liste.CurrentRow.Cells[11].Value = (kdvOran+100)*(bFiyat*1.2m)/100;
                    
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string StokCikisLot(bool secim = false)
        {
            frmLotBul lotBul = new frmLotBul();
            if (secim)
            {
                lotBul.Secim = true;
                lotBul.Lot = "StokCikis";
                lotBul.ShowDialog();
            }
            return frmAnaSayfa.AktarmaS;
        }

        private void Liste_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Liste.AllowUserToAddRows = false;

            if (e.ColumnIndex == 7)
            {
                int satisMiktar = int.Parse(Liste.CurrentRow.Cells[7].Value.ToString());
                decimal satisFiyat = decimal.Parse(Liste.CurrentRow.Cells[9].Value.ToString());
                decimal kdvOra = int.Parse(Liste.CurrentRow.Cells[10].Value.ToString());
                Liste.CurrentRow.Cells[12].Value = (satisMiktar * satisFiyat).ToString();
                Liste.CurrentRow.Cells[11].Value = ((satisMiktar * satisFiyat) * (kdvOra / 100)).ToString();

                decimal top = 0;
                decimal ktop = 0;

                foreach (DataGridViewRow row in Liste.Rows)
                {

                    string nullCheck = row.Cells[12].Value.ToString();

                    if (!String.IsNullOrWhiteSpace(nullCheck))
                    {

                        top += decimal.Parse(row.Cells[12].Value.ToString());
                        ktop += decimal.Parse(row.Cells[11].Value.ToString());
                    }
                    else
                    {
                        top = 0;
                        ktop = 0;
                    }
                }

                txtAraToplam.Text = top.ToString();
                txtKdvToplam.Text = ktop.ToString();
                txtIskonto.Text = "0";
                Liste.AllowUserToAddRows = true;
                txtGenelToplam.Text = ((decimal.Parse(txtAraToplam.Text.ToString()) * (100 - decimal.Parse(txtIskonto.Text)) / 100) + (decimal.Parse(txtKdvToplam.Text))).ToString(); 
            }

            if (e.ColumnIndex == 8)
            {
                decimal birimfiyat = decimal.Parse(Liste.CurrentRow.Cells[8].Value.ToString());
                decimal hesapla = birimfiyat * 1.2m;
                Liste.CurrentRow.Cells[9].Value = hesapla;
            }
            if (e.ColumnIndex == 9)
            {
                decimal sfiyat = decimal.Parse(Liste.CurrentRow.Cells[9].Value.ToString());
                decimal kdvOra = int.Parse(Liste.CurrentRow.Cells[10].Value.ToString());
                decimal hesapla = sfiyat * (kdvOra + 100) / 100;
                Liste.CurrentRow.Cells[11].Value = hesapla;

            }
        }



        private void Liste_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //if (e.ColumnIndex == 8)
            //{
            //    decimal birimfiyat = decimal.Parse(Liste.CurrentRow.Cells[8].Value.ToString());
            //    decimal hesapla = birimfiyat * 1.2m;
            //    Liste.CurrentRow.Cells[9].Value = hesapla;
            //}
        }

        private void YeniKaydet()
        {
            Liste.AllowUserToAddRows = false;
            try
            {
                tblStokCikisUst ust = new tblStokCikisUst();
                ust.Aciklama = txtAciklama.Text;
                ust.CariId = db.tblCaris.First(x => x.CariAd == txtCariAdi.Text).Id;
                ust.FaturaNo = txtFaturaNo.Text;
                ust.CikisKod = txtCikisKod.Text;
                //Önemli aşağıdaki value yu kontrol et!!!!!!!!!!!!!!!!!!!
                //Value değer çalışıyor.
                ust.CikisTarih = txtCikisTarih.Value;
                ust.CikisTur = txtCikisTur.Text;
                ust.AraToplam = decimal.Parse(txtAraToplam.Text.ToString());
                if(String.IsNullOrWhiteSpace(txtIskonto.Text))
                {
                    ust.Iskonto = 0;
                }

                else
                {
                    ust.Iskonto = int.Parse(txtIskonto.Text);
                }
                ust.KdvToplam = decimal.Parse(txtKdvToplam.Text);
                ust.GenelToplam = decimal.Parse(txtGenelToplam.Text);

                db.tblStokCikisUsts.Add(ust);

                tblStokCikisAlt[] alt = new tblStokCikisAlt[Liste.RowCount];
                tblStokDurum[] stk = new tblStokDurum[Liste.RowCount];
                for (int i = 0; i < Liste.RowCount; i++)
                {
                    alt[i] = new tblStokCikisAlt();
                    alt[i].CikisKod = txtCikisKod.Text;
                    alt[i].CikisSira = i + 1;//int.Parse(Liste.Rows[i].Cells[0].Value.ToString())
                    
                    alt[i].Barkod = Liste.Rows[i].Cells[1].Value.ToString();
                    alt[i].UrunKod = Liste.Rows[i].Cells[2].Value.ToString();
                    alt[i].LotSeriNo = Liste.Rows[i].Cells[4].Value.ToString();
                    alt[i].Birim = Liste.Rows[i].Cells[5].Value.ToString();
                    alt[i].Miktar = int.Parse(Liste.Rows[i].Cells[6].Value.ToString());
                    alt[i].SatisMiktar = int.Parse(Liste.Rows[i].Cells[7].Value.ToString());
                    alt[i].BirimFiyat = decimal.Parse(Liste.Rows[i].Cells[8].Value.ToString());
                    alt[i].SatisFiyat = decimal.Parse(Liste.Rows[i].Cells[9].Value.ToString());
                    alt[i].KdvOran = int.Parse(Liste.Rows[i].Cells[10].Value.ToString());
                    alt[i].KdvDahil = decimal.Parse(Liste.Rows[i].Cells[11].Value.ToString());

                    db.tblStokCikisAlts.Add(alt[i]);
                    string brkd = Liste.Rows[i].Cells[1].Value.ToString();
                    stk[i] = new tblStokDurum();
                    var srg = (from s in db.tblStokDurums
                               where s.Barkod == brkd
                               select s).ToList();

                    if (srg.Count == 0)
                    {
                        stk[i].Barkod = brkd;
                        stk[i].UrunKod = Liste.Rows[i].Cells[2].Value.ToString();
                        stk[i].LotSeriNo = Liste.Rows[i].Cells[3].Value.ToString();              //Buraya Dön
                        stk[i].Birim = Liste.Rows[i].Cells[4].Value.ToString();
                        stk[i].Miktar = int.Parse(Liste.Rows[i].Cells[5].Value.ToString());

                        db.tblStokDurums.Add(stk[i]);
                        db.SaveChanges();
                    }
                    else
                    {
                        tblStokDurum sdurum = db.tblStokDurums.First(s => s.Barkod == brkd);
                        sdurum.Miktar -= int.Parse(Liste.Rows[i].Cells[7].Value.ToString());             // ? emin değilim
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

        private void txtIskonto_TextChanged(object sender, EventArgs e)
        {
            if (!edit)
            {
                if (String.IsNullOrWhiteSpace(txtIskonto.Text))
                {
                    txtIskonto.Text = "0";
                }
                else
                {
                    txtGenelToplam.Text = ((decimal.Parse(txtAraToplam.Text.ToString()) * (100 - decimal.Parse(txtIskonto.Text)) / 100) +
                        (decimal.Parse(txtKdvToplam.Text))).ToString();
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            FaturaYaz();
        }

        private void FaturaYaz()
        {
            frmFatura print = new frmFatura();
            print.HangiForm = "StokCikis";
            print.txtKod.Text = txtCikisKod.Text;
            print.Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
