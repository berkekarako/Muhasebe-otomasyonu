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
using WinFormGiris.UrunIslemleri;

namespace WinFormGiris
{
    public partial class frmAnaSayfa : Form //Form sınıfının özellikleri ana sayfaya miras olara verilir.
    {
        WinFormDbEntities1 db = new WinFormDbEntities1();
        frmGiris grs = new frmGiris();
        public static string AktarmaS = "";
        public static string UrunKodBul = "";
        object window;
        object window1;

        public frmAnaSayfa()
        {
            
            InitializeComponent();
        }
        

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblUser.Text);
            //MessageBox.Show("Hoşgeldiniz.");
            //var kontrolName = db.tblUsers.FirstOrDefault(x => x.Id == id);
            //if (kontrolName != null)
            //{
            //    lblUser.Text = kontrolName.UserName;
            //}

            lblUser.Text = db.tblUsers.Find(id).UserName;

            var role = db.tblUsers.Find(id).Role;

            //if (role==0)
            //{
            //    btnAdmin.Visible = true;
            //}
            //else if(role>0)
            //{
            //    btnAdmin.Visible = false;
            //}
            btnAdmin.Visible = role == 0 ? true : false; //TurneryIf
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            gbLeft.Text = "One";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            gbLeft.Text = "Two";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            gbLeft.Text = "Three";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
            gbLeft.Text = "Fore";
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
            gbLeft.Text = "Admin"; 
        }
        private void btnAppClose_Click(object sender, EventArgs e)
        {
            //this.Close();//eski kodlama
            //Close();//yeni kısa yol

            //Application.Exit();//Uygulamadan çıkma komutu
            //Application.ExitThread();//Uygulamadan çıkarken arka planda çalışan bağlantılarıda kapatarak çıkan kod.

            
            //grs.Show();
            Close();

        }
        
        private void btnOneOpen_Click(object sender, EventArgs e)
        {
              window = Application.OpenForms.OfType<frmOne>().SingleOrDefault();
            frmOne one = new frmOne();
            if (window == null && window1 == null)
            {                
                one.MdiParent = frmAnaSayfa.ActiveForm;
                one.WindowState = FormWindowState.Maximized;
                one.Show();
            }
            else
            {
                MessageBox.Show("Bu form daha önce açılmış.");
            }
        }
        
        private void btnOne1Open_Click(object sender, EventArgs e)
        {
             window1 = Application.OpenForms.OfType<frmOne1>().SingleOrDefault();

            frmOne1 one1 = new frmOne1();
            if (window1==null && window==null)
            {                
                one1.MdiParent = frmAnaSayfa.ActiveForm;
                one1.WindowState = FormWindowState.Maximized;
                one1.Show();                
            }
            else
            {
                MessageBox.Show("Bu form daha önce açılmış.");
            }
        }

        private void frmAnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            grs.Show();
            
        }

        private void btnUserGiris_Click(object sender, EventArgs e)
        {
            frmUserEntry usr = new frmUserEntry();
            usr.MdiParent = frmAnaSayfa.ActiveForm;
            usr.WindowState = FormWindowState.Maximized;
            usr.Show();
        }

        private void btnCariGiris_Click(object sender, EventArgs e)
        {
            
            frmCariGiris cari = new frmCariGiris();
            cari.MdiParent = frmAnaSayfa.ActiveForm;
            cari.WindowState = FormWindowState.Maximized;
            cari.Show();
        }

        private void btnUrunKayit_Click(object sender, EventArgs e)
        {
            frmUrunKayit urun = new frmUrunKayit();
            urun.MdiParent = frmAnaSayfa.ActiveForm;
            urun.WindowState = FormWindowState.Maximized;
            urun.Show();
        }

        private void btnStokGiris_Click(object sender, EventArgs e)
        {
            frmStokGiris stokGiris = new frmStokGiris();
            stokGiris.MdiParent = frmAnaSayfa.ActiveForm;
            stokGiris.WindowState = FormWindowState.Maximized;
            stokGiris.Show();
        }

        private void btnStokCikis_Click(object sender, EventArgs e)
        {
            frmStokCikis stokCikis = new frmStokCikis();
            stokCikis.MdiParent = frmAnaSayfa.ActiveForm;
            stokCikis.WindowState = FormWindowState.Maximized;
            stokCikis.Show();
        }
    }
}
