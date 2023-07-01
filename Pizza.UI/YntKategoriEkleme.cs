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
    public partial class YntKategoriEkleme : Form
    {
        User _user = null;
        public YntKategoriEkleme(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void YntKategoriEkleme_Load(object sender, EventArgs e)
        {
            KategoriDoldur();
        }

        private void KategoriDoldur()
        {
            lstCategories.Items.Clear();
            using (var db = new MyDBEntities())
            {
                var categories = db.Categories.ToList();
                foreach (var category in categories)
                {
                    lstCategories.Items.Add(category);
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                using (var db = new MyDBEntities())
                {
                    if (db.Categories.Where(m => m.CategoryName == txtCategory.Text).SingleOrDefault() != null)
                    {
                        MessageBox.Show("Kategori mevcut! Güncelleme yapınız.");
                        KategoriDoldur();
                        txtCategory.Text = string.Empty;
                        return;
                    }
                    db.Categories.Add(new Category()
                    {
                        CategoryName = txtCategory.Text,
                        ModifiedDate = DateTime.Now,
                        UserID = _user.UserID
                    });
                    if (db.SaveChanges() > 0) { MessageBox.Show("Eklendi"); }
                    KategoriDoldur();
                }
            }
        }

        private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category category = lstCategories.SelectedItem as Category;
            if (category != null)
            {
                txtCategory.Text = category.CategoryName;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text != null)
            {
                using (var db = new MyDBEntities())
                {
                    Category category= lstCategories.SelectedItem as Category;
                    if (category != null)
                    {
                        Category dbCategory = db.Categories.Single(s => s.CategoryID == category.CategoryID);
                        dbCategory.CategoryName = txtCategory.Text;
                        dbCategory.ModifiedDate = DateTime.Now;
                        dbCategory.UserID = _user.UserID;
                        db.SaveChanges();
                    }
                }
                MessageBox.Show("Güncellendi");
            }
            else
            {
                MessageBox.Show("Kategori adı boş olamaz");
            }
            txtCategory.Text = string.Empty;
            KategoriDoldur();
        }
    }
}
