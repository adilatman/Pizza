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
    public partial class FrmYeniKullanici : Form
    {
        /// <summary>
        /// Bu form hem yönetici paneline giriş için kullanılır hem de yeni kullanıcı atamak için.
        /// Admin şifresi gerektirir.
        /// </summary>
        public FrmYeniKullanici()
        {
            InitializeComponent();
        }
        User _user = null;
        //Yeni kullanıcı şifresi belirlendiğinde "Ekle" butonu aktifleşir
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.MaskCompleted)
            {
                btnAdd.Enabled = true;
            }
        }
        //Ekle butonuna basıldığında admin şifresinin doğruluğu ve kullanıcı adının mevcut olup olmadığı kontrol edilir.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            User admin = null;
            User IsNewUser = null;
            using (MyDBEntities db = new MyDBEntities())
            {
                admin = db.Users.SingleOrDefault(u => u.UserName == "admin");                
                IsNewUser = db.Users.SingleOrDefault(u => u.UserName == txtUser.Text);
            }
            if (IsNewUser != null)
            {
                MessageBox.Show("Bu kullanıcı adı mevcut. Ana ekrandan giriş yapınız. Yeni kullanıcıysanız başka bir kullanıcı adı deneyiniz!");
                txtAdmin.Text = txtUser.Text = txtPassword.Text = null;
                return;
            }
            if (admin.Password == txtAdmin.Text)
            {   
                if (txtUser.Text != null)
                {

                    using (MyDBEntities db = new MyDBEntities())
                    {
                        try
                        {
                            User user = new User();
                            user.UserName = txtUser.Text;
                            user.Password = txtPassword.Text;
                            user.ModifiedDate = DateTime.Now;
                            var newUser = db.Users.Add(user);
                            if (newUser != null)
                            {
                                db.SaveChanges();
                                MessageBox.Show("Kullanıcı eklendi!");
                                OncekiFormaDon();
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı eklenemedi!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Bu işlem için admin gerekiyor. Girilen admin şifresi hatalı!");
            }

        }

        private void OncekiFormaDon()
        {
            this.Hide();
            LogIn frm = new LogIn();
            frm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OncekiFormaDon();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnAdd.PerformClick();
                e.Handled = true;
            }
        }
        //admin şifresi girildiği an kontrol edilir, doğruysa yönetici paneli butonu aktifleşir
        private void txtAdmin_TextChanged(object sender, EventArgs e)
        {
            if (txtAdmin.MaskCompleted)
            {
                using (var db = new MyDBEntities())
                {
                    string password = (from u in db.Users
                                      where u.UserName == "admin"
                                      select u.Password).Single();

                    //string password = db.Users.Single(u => u.UserName == "admin").Password.ToString();

                    if (password == txtAdmin.Text)
                    {
                        btnYonetici.Enabled = true;
                    }
                    
                }
            }
        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            using (var db =new MyDBEntities())
            {
                _user = db.Users.Single(u => u.UserName == "admin");
            }
            FrmYoneticiPaneli frm = new FrmYoneticiPaneli(_user);
            frm.Show();
            this.Hide();
        }
    }
}
