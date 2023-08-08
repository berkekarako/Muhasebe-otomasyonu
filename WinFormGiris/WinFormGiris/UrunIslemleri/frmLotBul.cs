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
    public partial class frmLotBul : Form
    {
        WinFormDbEntities1 db = new WinFormDbEntities1();
        public bool Secim = false;
        public string Lot;
        string secimBarkod = "";

        public frmLotBul()
        {
            InitializeComponent();
        }

        frmStokCikis sCikis = Application.OpenForms["frmStokCikis"] as frmStokCikis;

        private void frmLotBul_Load(object sender, EventArgs e)
        {
            switch (Lot)
            {
                case "StokCikis":
                    txtUrunKod.Text = frmAnaSayfa.UrunKodBul;
                    break;
                default:
                    break;
            }
        }

        private void txtUrunKod_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            var lst = from s in db.tblStokDurums
                      where s.UrunKod == txtUrunKod.Text
                      where s.Miktar != 0
                      select s;
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.UrunKod;
                Liste.Rows[i].Cells[1].Value = k.LotSeriNo;
                Liste.Rows[i].Cells[2].Value = k.Miktar;
                Liste.Rows[i].Cells[3].Value = k.Birim;
                Liste.Rows[i].Cells[4].Value = k.Barkod;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Tmm();
        }

        private void Tmm()
        {
            Sec();
            if (Secim && secimBarkod != "")
            {
                frmAnaSayfa.AktarmaS = secimBarkod;
                Close();
            }
        }

        private void Sec()
        {
            try
            {
                //secimBarkod = Liste.CurrentRow.Cells["Barkod"].Value.ToString(); Alternatif olarak kulanılabilir.
                secimBarkod = Liste.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                secimBarkod = "";
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Tmm();
        }

        private void Liste_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)||(Keys)e.KeyChar==Keys.NumPad0)
            {
                e.Handled = true;
                Tmm();
            }
        }
    }
}
