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
    public partial class YntUrunEkleme : Form
    {
        User _user = null;
        public YntUrunEkleme(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void YntUrunEkleme_Load(object sender, EventArgs e)
        {
            UrunleriYukle();
            KategorileriYukle();
            SiniflariYukle();
        }

        private void SiniflariYukle()
        {
            cmbProductClasses.Items.Clear();
            using (var db = new MyDBEntities())
            {
                cmbProductClasses.DataSource = db.ProductClasses.ToList();
            }
        }

        private void KategorileriYukle()
        {
            cmbCategories.Items.Clear();
            using (var db = new MyDBEntities())
            {
                cmbCategories.DataSource = db.Categories.ToList();
            }
        }

        private void UrunleriYukle()
        {
            lstProducts.Items.Clear();
            Category category = cmbCategories.SelectedItem as Category;

            if (category!=null)
            {
                using (var db = new MyDBEntities())
                {
                    var products = (from p in db.Products
                                    where p.CategoryID == category.CategoryID
                                    select p).ToList();

                    foreach (var product in products.OrderBy(p => p.ProductName))
                    {
                        lstProducts.Items.Add(product);
                    }
                } 
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                var category = cmbCategories.SelectedItem as Category;
                var productClass = cmbProductClasses.SelectedItem as ProductClass;
                using (var db = new MyDBEntities())
                {
                    if (db.Products.Where(m => m.ProductName == txtProductName.Text).SingleOrDefault() != null)
                    {
                        MessageBox.Show("Ürün mevcut! Güncelleme yapınız.");
                        UrunleriYukle();
                        txtProductName.Text = string.Empty;
                        return;
                    }
                    db.Products.Add(new Product()
                    {
                        ProductName = txtProductName.Text,
                        CategoryID = category.CategoryID,
                        ProductClassID = productClass.ProductClassID,
                        ModifiedDate = DateTime.Now,
                        UserID = _user.UserID
                    });
                    db.SaveChanges();
                    MessageBox.Show("Eklendi");
                }
            }
            else
            {
                MessageBox.Show("Ürün adı boş olamaz");
            }
            txtProductName.Text = string.Empty;
            UrunleriYukle();
        }
        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product product = lstProducts.SelectedItem as Product;
            if (product!=null)
            {
                cmbCategories.SelectedIndex = product.CategoryID - 1;
                cmbProductClasses.SelectedIndex = product.ProductClassID - 1;
                txtProductName.Text = product.ProductName;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product=lstProducts.SelectedItem as Product;
            if (product!=null)
            {
                if (!string.IsNullOrWhiteSpace(txtProductName.Text))
                {
                    using (var db = new MyDBEntities())
                    {
                        Product product1 = db.Products.Single(p => p.ProductID == product.ProductID);
                        product1.ProductName = txtProductName.Text;
                        product1.CategoryID=cmbCategories.SelectedIndex+1;
                        product1.ProductClassID=cmbProductClasses.SelectedIndex+1;
                        product1.ModifiedDate=DateTime.Now;
                        product1.UserID=_user.UserID;
                        db.SaveChanges();
                    }
                    MessageBox.Show("Güncellendi");
                    txtProductName.Text=string.Empty;
                    UrunleriYukle();
                }
            }
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrunleriYukle();
        }
    }
}
