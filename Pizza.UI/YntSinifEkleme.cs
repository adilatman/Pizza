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
    public partial class YntSinifEkleme : Form
    {
        User _user = null;
        public YntSinifEkleme(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void YntSinifEkleme_Load(object sender, EventArgs e)
        {
            SinifYukle();
        }

        private void SinifYukle()
        {
            lstSinif.Items.Clear();
            using (var db = new MyDBEntities())
            {
                var siniflar = db.ProductClasses.ToList();
                foreach (var c in siniflar.OrderBy(s => s.ProductClassName))
                {
                    lstSinif.Items.Add(c);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSinifAdi.Text))
            {
                using (var db = new MyDBEntities())
                {
                    if (db.ProductClasses.Where(m => m.ProductClassName == txtSinifAdi.Text).SingleOrDefault() != null)
                    {
                        MessageBox.Show("Sınıf mevcut! Güncelleme yapınız.");
                        SinifYukle();
                        txtSinifAdi.Text = string.Empty;
                        return;
                    }
                    db.ProductClasses.Add(new ProductClass()
                    {
                        ProductClassName = txtSinifAdi.Text,
                        ModifiedDate = DateTime.Now,
                        UserID = _user.UserID
                    });
                    db.SaveChanges();
                    MessageBox.Show("Eklendi");
                }
            }
            else
            {
                MessageBox.Show("Sınıf adı boş olamaz");
            }
            txtSinifAdi.Text=string.Empty;
            SinifYukle();
        }

        private void lstSinif_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductClass sinif = lstSinif.SelectedItem as ProductClass;
            if (sinif != null)
            {
                txtSinifAdi.Text = sinif.ProductClassName;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSinifAdi.Text != null)
            {
                using (var db = new MyDBEntities())
                {
                    ProductClass sinif = lstSinif.SelectedItem as ProductClass;
                    if (sinif != null)
                    {
                        ProductClass dbSinif = db.ProductClasses.Single(s => s.ProductClassID == sinif.ProductClassID);
                        dbSinif.ProductClassName = txtSinifAdi.Text;
                        dbSinif.ModifiedDate = DateTime.Now;
                        dbSinif.UserID = _user.UserID;
                        db.SaveChanges();
                    }
                }
                MessageBox.Show("Güncellendi");
            }
            else
            {
                MessageBox.Show("Sınıf adı boş olamaz");
            }
            txtSinifAdi.Text = string.Empty;
            SinifYukle();
        }

        
    }
}
