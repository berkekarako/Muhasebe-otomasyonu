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

namespace WinFormGiris
{
    public partial class frmGiris : Form
    {
        //Database e bağlanmak için entity vasıtasıyla db adında bir nesne oluşturdum. Artık db nesnesini kullanarak database in özelliklerine(Attribute) ve database de oluşturduğum tablolara ulaşabilirim.
        WinFormDbEntities1 db = new WinFormDbEntities1();
        public int kulId=0;
        bool kontrol = false;
        public frmGiris()
        {
            InitializeComponent();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
           
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //string kul = txtKulAdi.Text;
            //string sif = txtSifre.Text;
            if (txtKulAdi.Text!="" && txtSifre.Text!="")
            {
                var srg = (from s in db.tblUsers select s).ToList();

                foreach (var k in srg)
                {
                    if (k.UserName==txtKulAdi.Text && k.Password==txtSifre.Text)
                    {
                        kulId = k.Id;
                        Giris();
                        kontrol = true;
                        return;
                    }
                }
                if (kontrol == false)
                {
                    MessageBox.Show("Kullanıcı adı veya şifreniz hatalı.");
                }

            }
            else
            {
                MessageBox.Show("Eksik giriş yaptınız.Lütfen kontrol edin.");
            }
        }

        private void Giris()
        {
            frmAnaSayfa ana = new frmAnaSayfa();
            ana.lblUser.Text = kulId.ToString();
            ana.Show();
            Hide();
            txtSifre.Text = "";
            kulId = 0;
        }

        private void frmGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
