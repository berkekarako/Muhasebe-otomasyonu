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
    public partial class frmUserEntry : Form
    {
        WinFormDbEntities1 db = new WinFormDbEntities1();

        public frmUserEntry()
        {
            InitializeComponent();
        }

        private void frmUserEntry_Load(object sender, EventArgs e)
        {

        }

        void YeniKaydet()
        {
            try
            {
                tblUser usr = new tblUser();
                usr.UserName = txtUserName.Text;
                usr.Age = byte.Parse(txtAge.Text);
                usr.Email = txtEmail.Text;
                usr.Gender = txtGender.Text;
                usr.Password = txtPassword.Text;
                //if (txtRole.Text == "Admin")
                //{
                //    usr.Role = 0;
                //}
                //else
                //{
                //    usr.Role = 1;
                //}

                usr.Role = byte.Parse(txtRole.Text == "Admin" ? "0" : "1");

                db.tblUsers.Add(usr);
                db.SaveChanges();
                MessageBox.Show("Kayıt Başırıyla gerçekleşti.");
                Temizle();
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt sırasında bir hata oluştu.");
            }
        }

        private void Temizle()
        {
            //txtAge.Text = "";
            //txtEmail.Text = "";
            //txtGender.Text = "";
            //txtPassword.Text = "";
            //txtRole.Text = "";
            //txtUserName.Text = "";

            foreach (Control ct in splitContainer1.Panel1.Controls)
            {
               if(ct is TextBox || ct is ComboBox)
                {
                    ct.Text = "";                    
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
