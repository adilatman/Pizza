using Pizza.Core.Context;
using Pizza.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza.UI
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        User user = null;
        private void btnEntry_Click(object sender, EventArgs e)
        {
            using (MyDBEntities db = new MyDBEntities())
            {
                string userName = txtUser.Text;
                string password = txtPassword.Text;
                user = db.Users.Where(u=>u.UserName == userName).FirstOrDefault();
                
                if (user != null)
                {
                    if (user.Password == password)
                    {
                        this.Hide();
                        FrmMain frm = new FrmMain(user);
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Şifreniz hatalı. Lütfen kontrol ediniz!");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı!");
                }
            }
        }

        private void lblYeni_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmYeniKullanici frm = new FrmYeniKullanici();
            frm.Show();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.MaskCompleted)
            {
                btnEntry.Enabled = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntry.PerformClick();
                e.Handled = true;
            }
        }
    }
}
