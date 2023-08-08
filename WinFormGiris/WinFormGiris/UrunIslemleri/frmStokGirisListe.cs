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

namespace WinFormGiris.UrunIslemleri
{
    public partial class frmStokGirisListe : Form
    {
        WinFormDbEntities1 db = new WinFormDbEntities1();

        int secimId = -1;
        public frmStokGirisListe()
        {
            InitializeComponent();
        }

        private void frmStokGirisListe_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = (from s in db.tblStokGirisUsts
                       where s.tblCari.CariAd.Contains(txtCariAdi.Text)
                       //where s.CariAd==txtCariAdi.Text
                       select s);
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.GirisKod;
                Liste.Rows[i].Cells[2].Value = k.tblCari.CariAd;
                Liste.Rows[i].Cells[3].Value = k.GirisTur;
                Liste.Rows[i].Cells[4].Value = k.FaturaNo;
                Liste.Rows[i].Cells[5].Value = k.GirisTarih;

                i++;
            }
            Liste.AllowUserToAddRows = false;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secimId > 0)
            {
                frmAnaSayfa.AktarmaS = Liste.CurrentRow.Cells[1].Value.ToString();
                Close();
            }
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
    }
}
