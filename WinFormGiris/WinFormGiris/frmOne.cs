using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormGiris
{
    public partial class frmOne : Form
    {
        int[] DiziFor = { 10, 20, 30, 40, 50 };
        string[] DiziWhile = { "Hale", "Jale", "Hasan", "Hüseyin", "Yaşar", "Ne Yaşar" };
        object[] DiziDo = { "Fenerbahçe", 1907, "Beşiktaş", 1903, "Sivas", 1958, "Eskişehir Spor", 1965 };
        int Toplam = 0;
        public frmOne()
        {
            InitializeComponent();
        }

        private void frmOne_Load(object sender, EventArgs e)
        {

        }

        private void Temizle(string sample)
        {
            Toplam = 0;

            switch (sample)
            {
                case "for":
                    lstBoxFor.Items.Clear();
                    break;

                case "while":
                    lstBoxWhile.Items.Clear();
                    break;

                case "dowhile":
                    lstBoxDoWhile.Items.Clear();
                    break;

                case "Ienum":
                    lstBoxIEnum.Items.Clear();
                    break;

                case "foreach":
                    lstBoxForeach.Items.Clear();
                    break;

                default:
                    break;
            }



        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            //göndereceğim form açılmalı 


            frmOne1 one1 = new frmOne1();
            one1.MdiParent = frmAnaSayfa.ActiveForm;
            one1.WindowState = FormWindowState.Maximized;
            one1.txtAlici.Text = txtVerici.Text;
            one1.Show();
            //çalıştığım for kapanmalı
            Close();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            ForDongusu();

        }

        private void ForDongusu()
        {
            Temizle("for");


            for (int i = 0; i < DiziFor.Length; i++)
            {
                Toplam = Toplam + DiziFor[i];
                lstBoxFor.Items.Add(DiziFor[i]);
            }
            lstBoxFor.Items.Add("------------------");
            lstBoxFor.Items.Add("Toplam : " + Toplam);
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            Temizle("while");
            int i = 0;
            lstBoxWhile.Items.Clear();
            //while (DiziWhile.Length>i)
            //{
            //    lstBoxWhile.Items.Add(DiziWhile[i]);
            //    //Toplam += DiziWhile[i]; String tipinde bir array olduğundan toplam hesaplaması yapılamaz.
            //    i++;
            //}

            //lstBoxWhile.Items.Add("------------------");
            //lstBoxWhile.Items.Add("Eleman Sayısı : " + DiziWhile.Length);

            while (DiziFor.Length > i)
            {
                lstBoxWhile.Items.Add(DiziFor[i]);
                Toplam += DiziFor[i];
                //Toplam = Toplam + DiziFor[i];
                //i = i + 1;
                i++;
            }
            lstBoxWhile.Items.Add("------------------");
            lstBoxWhile.Items.Add("Toplam : " + Toplam);            
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            Temizle("dowhile");
            DoWhileDongusu();
        }

        private void DoWhileDongusu()
        {
            int i = 0;
            do
            {
                lstBoxDoWhile.Items.Add(DiziFor[i]);
                Toplam += DiziFor[i];
                i++;
            } while (DiziFor.Length > i);
            lstBoxDoWhile.Items.Add("------------------");
            lstBoxDoWhile.Items.Add("Toplam : " + Toplam);
        }

        private void btnIEnum_Click(object sender, EventArgs e)
        {
            Temizle("Ienum");
            IEnumDongusu();
        }

        private void IEnumDongusu()
        {
            int i = 0;
            IEnumerator IEnum = DiziFor.GetEnumerator();
            while (IEnum.MoveNext())
            {
                lstBoxIEnum.Items.Add(IEnum.Current);
                Toplam += DiziFor[i];
                i++;
            }
            lstBoxIEnum.Items.Add("------------------");
            lstBoxIEnum.Items.Add("Toplam : " + Toplam);
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            Temizle("foreach");
            ForeachDongusu();
        }

        private void ForeachDongusu()
        {
            foreach (var item in DiziDo)
            {
                lstBoxForeach.Items.Add(item);
                //Toplam += (int)item;
            }
            lstBoxForeach.Items.Add("------------------");
            lstBoxForeach.Items.Add("Eleman Sayısı : " + DiziDo.Length);
        }
    }
}
