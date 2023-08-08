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

namespace WinFormGiris.CariIslemleri
{
    public partial class frmCariGiris : Form
    {
        WinFormDbEntities1 db = new WinFormDbEntities1();
        Numaralar N = new Numaralar();

        int secimId = -1;
        bool edit = false;

        public frmCariGiris()
        {
            InitializeComponent();
        }

        private void frmCariGiris_Load(object sender, EventArgs e)
        {
            Combo();
        }

        private void Combo()
        {
            Listele();
            txtCariKod.Text = N.CariNo();
            /***************1.ALTERNATİF**************/
            //txtSehir.ValueMember = "id";
            //txtSehir.DisplayMember = "Sehir";
            //txtSehir.DataSource = db.illers.ToList();
            //txtSehir.SelectedIndex = -1;
            /***************1.ALTERNATİF**************/

            /***************2.ALTERNATİF**************/
            var lst = (from s in db.illers select new { shr = s.sehir }).ToList();
            foreach (var il in lst)
            {
                txtSehir.Items.Add(il.shr);
            }
            /***************2.ALTERNATİF**************/
            txtSehir.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSehir.AutoCompleteSource = AutoCompleteSource.ListItems;
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
            txtCariKod.Text = N.CariNo();
            Listele();
        }
        void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = (from s in db.tblCaris
                       select s);
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.CariTip;
                Liste.Rows[i].Cells[2].Value = k.CariAd;
                Liste.Rows[i].Cells[3].Value = k.iller.sehir;
                Liste.Rows[i].Cells[4].Value = k.Email;
                Liste.Rows[i].Cells[5].Value = k.Tel;

                i++;
            }
            Liste.AllowUserToAddRows = false;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit && secimId > 0 && MessageBox.Show("Seçili olan kayıt güncellenecektir\n Güncelleme işlemini onaylıyormusunuz?","Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Guncelle();
            else if (!edit) YeniKaydet();
           
        }

        private void YeniKaydet()
        {
            try
            {
                tblCari cari = new tblCari();
                cari.Adres = txtAdres.Text;
                cari.CariAd = txtCariAd.Text;
                cari.CariKod = txtCariKod.Text;
                cari.CariTip = 1;
                cari.Email = txtEmail.Text;
                cari.SehirId = db.illers.First(x => x.sehir == txtSehir.Text).id;
                cari.UlkeKodu = txtUlkeKodu.Text;
                cari.VDaire = txtVd.Text;
                cari.VNo_Tc = txtVn.Text;
                cari.Tel = txtTel.Text;

                db.tblCaris.Add(cari);
                db.SaveChanges();
                MessageBox.Show("Kayıt Başarılı");
                Temizle();
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: CariGiris-101" + e.Message);
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
                tblCari cari = db.tblCaris.Find(secimId);
                cari.Adres = txtAdres.Text;
                cari.CariAd = txtCariAd.Text;
                cari.CariKod = txtCariKod.Text;
                cari.CariTip = 1;
                cari.Email = txtEmail.Text;
                cari.SehirId = db.illers.First(x => x.sehir == txtSehir.Text).id;
                cari.UlkeKodu = txtUlkeKodu.Text;
                cari.VDaire = txtVd.Text;
                cari.VNo_Tc = txtVn.Text;
                cari.Tel = txtTel.Text;

                db.SaveChanges();

                MessageBox.Show("Güncelleme başarılı.");
                Temizle();                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSehir_SelectedIndexChanged(object sender, EventArgs e)
        {          
            
            if (txtSehir.SelectedIndex>=0 && txtSehir.Text!="")
            {
                var sehirid = db.illers.First(x => x.sehir == txtSehir.Text).id;

                txtIlce.DataSource = (from s in db.ilcelers where s.sehir == sehirid select s).ToList();
                txtIlce.ValueMember = "id";
                txtIlce.DisplayMember = "ilce";               
            }
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
            tblCari cari = db.tblCaris.First(s => s.Id == id);
            txtAdres.Text = cari.Adres;
            txtCariAd.Text = cari.CariAd;
            txtCariKod.Text = cari.CariKod;
            txtCariTip.Text = cari.CariTip.ToString();
            txtEmail.Text = cari.Email;
            txtSehir.Text = cari.iller.sehir;
            txtTel.Text = cari.Tel;
            txtUlkeKodu.Text = cari.UlkeKodu;
            txtVd.Text = cari.VDaire;
            txtVn.Text = cari.VNo_Tc;
            
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (edit && secimId > 0 && MessageBox.Show("Seçili olan kayıt kalıcı olarak silinecektir.\n Silme işlemini onaylıyormusunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) Sil();
        }
        private void Sil()
        {
            try
            {
                tblCari entity = db.tblCaris.Find(secimId);
                db.tblCaris.Remove(entity);
                db.SaveChanges();
                MessageBox.Show("Kayıt kalıcı olarak silinmiştir.");
                Temizle();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}

