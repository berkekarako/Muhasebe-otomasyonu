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
using WinFormGiris.UrunIslemleri;


namespace WinFormGiris.Fatura
{
    public partial class frmFatura : Form
    {
        WinFormDbEntities1 db = new WinFormDbEntities1();
        public string HangiForm;
        public frmFatura()
        {
            InitializeComponent();
        }

        private void frmFatura_Load(object sender, EventArgs e)
        {
            switch (HangiForm)
            {
                case "StokCikis":
                    StokCikis();
                    break;
                default:
                    break;
            }
        }

        private void StokCikis()
        {
            frmStokCikis stokCikis = Application.OpenForms["frmStokCikis"] as frmStokCikis;
            StokCikisFatura cr = new StokCikisFatura();
            var result = (from s in db.vwStokCikisHepsis
                          where s.CikisKod == txtKod.Text
                          select s).ToList();

            if (result != null)
            {
                FaturaYardim crHelp = new FaturaYardim();
                DataTable dt = crHelp.ConvertTo(result);
                cr.SetDataSource(dt);
                crystalPrint.ReportSource = cr;
            }
        }
    }
}
