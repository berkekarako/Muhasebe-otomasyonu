using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormGiris.Entity;
using WinFormGiris.Fonksiyonlar;

namespace WinFormGiris.UrunIslemleri
{
    public partial class frmUrunKayit : Form
    {
        WinFormDbEntities1 db = new WinFormDbEntities1();
        Numaralar N = new Numaralar();

        int secimId = -1;
        bool edit = false;
        public frmUrunKayit()
        {
            InitializeComponent();
        }

        private void frmUrunKayit_Load(object sender, EventArgs e)
        {
            Combo();
            Listele();
        }
       

        private void Combo()
        {
            txtBirim.ValueMember = "Id";
            txtBirim.DisplayMember = "Adi";
            txtBirim.DataSource = db.tblBirims.ToList();

            
        }

        void Temizle()
        {

            secimId = -1;
            edit = false;
            foreach (Control ct in splitContainer2.Panel1.Controls)
            {
                if (ct is TextBox || ct is ComboBox)
                {
                    ct.Text = "";
                }
            }
            
            Listele();
        }


        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = (from s in db.tblUrunKayits
                       select s);
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.UrunKodu;
                Liste.Rows[i].Cells[2].Value = k.LotSeriNo;
                Liste.Rows[i].Cells[3].Value = k.Mensei;
                Liste.Rows[i].Cells[4].Value = k.tblBirim.Adi;
                Liste.Rows[i].Cells[5].Value = k.MarkaId;

                i++;
            }
            Liste.AllowUserToAddRows = false;
        }

        private void YeniKaydet()
        {
            try
            {
                tblUrunKayit urun = new tblUrunKayit();
                urun.Aciklama = txtAciklama.Text;
                urun.UrunKodu = txtUrunKod.Text;
                urun.LotSeriNo = txtLotSeri.Text;
               
                urun.Mensei = txtMensei.Text;

                urun.BirimId = db.tblBirims.First(x => x.Adi == txtBirim.Text).Id;
                urun.MarkaId = txtMarka.Text;
                urun.KdvOran = byte.Parse(txtOran.Text);
                

                db.tblUrunKayits.Add(urun);
                db.SaveChanges();
                MessageBox.Show("Kayıt Başarılı");
                Temizle();

            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: ÜrünKayıt-101" + e.Message);
            }


            //tblCari cari1 = new tblCari()
            //{
            //    Adres = txtAdres.Text,
            //    CariAd = txtCariAd.Text,
            //    CariKod = txtCariKod.Text,
            //    CariTip = int.Parse(txtCariTip.Text),
            //    Email = txtEmail.Text,
            //    //SehirId = int.Parse(txtSehir.Text),
            //    UlkeKodu = txtUlkeKodu.Text,
            //    VDaire = txtVd.Text,
            //    VNo_Tc = txtVn.Text,
            //    Tel = txtTel.Text
            //};

        }
        private void Guncelle()
        {
            try
            {
                tblUrunKayit urun = db.tblUrunKayits.Find(secimId);
                urun.Aciklama = txtAciklama.Text;
                urun.UrunKodu = txtUrunKod.Text;
                urun.LotSeriNo = txtLotSeri.Text;

                urun.Mensei = txtMensei.Text;

                urun.BirimId = db.tblBirims.First(x => x.Adi == txtBirim.Text).Id; 
                urun.MarkaId = txtMarka.Text;
                urun.KdvOran = byte.Parse(txtOran.Text);

                db.SaveChanges();

                MessageBox.Show("Güncelleme başarılı.");
                Temizle();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit && secimId > 0 && MessageBox.Show("Seçili olan kayıt güncellenecektir\n Güncelleme işlemini onaylıyormusunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Guncelle();
            else if (!edit) YeniKaydet();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secimId > 0)
            {
                Ac(secimId);
            }
        }
        void Ac(int id)
        {
            edit = true;
            tblUrunKayit urun = db.tblUrunKayits.First(s => s.Id == id);
            txtAciklama.Text = urun.Aciklama;
            txtUrunKod.Text = urun.UrunKodu;
            txtLotSeri.Text = urun.LotSeriNo;
            txtMarka.Text = urun.MarkaId;
            txtMensei.Text = urun.Mensei;
            txtBirim.Text = urun.tblBirim.Adi;
            txtOran.Text = urun.KdvOran.ToString();

        }
        private void Sec()
        {
            try
            {
                secimId = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                secimId = -1;
            }
        }

        private void Sil()
        {
            try
            {
                tblUrunKayit entity = db.tblUrunKayits.Find(secimId);
                db.tblUrunKayits.Remove(entity);
                db.SaveChanges();
                MessageBox.Show("Kayıt kalıcı olarak silinmiştir.");
                Temizle();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (edit && secimId > 0 && MessageBox.Show("Seçili olan kayıt kalıcı olarak silinecektir.\n Silme işlemini onaylıyormusunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
