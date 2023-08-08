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

namespace WinFormGiris.CariIslemleri
{
    public partial class frmCariListe : Form
    {
        WinFormDbEntities1 db = new WinFormDbEntities1();
        public frmCariListe()
        {
            InitializeComponent();
        }

        private void frmCariListe_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = (from s in db.tblCaris
                       where s.CariAd.Contains(txtCariAdi.Text)
                       //where s.CariAd==txtCariAdi.Text
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

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            frmAnaSayfa.AktarmaS = Liste.CurrentRow.Cells[2].Value.ToString();
            Close();
        }
    }
}
