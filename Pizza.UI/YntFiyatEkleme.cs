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
    public partial class YntFiyatEkleme : Form
    {
        User _user = null;
        public YntFiyatEkleme(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void YntFiyatEkleme_Load(object sender, EventArgs e)
        {
            FiyatYukle();
            SiniflariYukle();
            KategoriYukle();
        }
        private void FiyatYukle()
        {
            lstPrices.Items.Clear();
            using (var db = new MyDBEntities())
            {
                var prices = (from p in db.Prices select p).ToList();
                foreach (var pr in prices)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text=pr.CategoryID.ToString();
                    listViewItem.SubItems.Add(pr.ProductClassID.ToString());
                    listViewItem.SubItems.Add(pr.SizeID.ToString());
                    listViewItem.SubItems.Add(pr.UnitPrice.ToString());
                    lstPrices.Items.Add(listViewItem);
                }
            }
        }
        private void KategoriYukle()
        {
            using (var db = new MyDBEntities())
            {
                cmbCategory.DataSource = db.Categories.ToList();
            }
        }
        private void SiniflariYukle()
        {
            using (var db = new MyDBEntities())
            {
                cmbClass.DataSource = db.ProductClasses.ToList();
            }
        }
        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiyatYukleText();
            FiyatYukle();
        }

        private void FiyatYukleText()
        {
            using (var db = new MyDBEntities())
            {
                txtS.Text = (from p in db.Prices
                             where p.ProductClassID == cmbClass.SelectedIndex + 1 && p.SizeID == 1 && p.CategoryID == cmbCategory.SelectedIndex + 1
                             select p.UnitPrice).FirstOrDefault().ToString();
                txtM.Text = (from p in db.Prices
                             where p.ProductClassID == cmbClass.SelectedIndex + 1 && p.SizeID == 2 && p.CategoryID == cmbCategory.SelectedIndex + 1
                             select p.UnitPrice).FirstOrDefault().ToString();
                txtL.Text = (from p in db.Prices
                             where p.ProductClassID == cmbClass.SelectedIndex + 1 && p.SizeID == 3 && p.CategoryID == cmbCategory.SelectedIndex + 1
                             select p.UnitPrice).FirstOrDefault().ToString();
                txtXL.Text = (from p in db.Prices
                              where p.ProductClassID == cmbClass.SelectedIndex + 1 && p.SizeID == 4 && p.CategoryID == cmbCategory.SelectedIndex + 1
                              select p.UnitPrice).FirstOrDefault().ToString();
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            int size = 1;
            if (decimal.TryParse(txtS.Text, out decimal price))
            {
                using (var db = new MyDBEntities())
                {
                    if ((from p in db.Prices
                         where p.ProductClassID == cmbClass.SelectedIndex + 1 && p.SizeID == size && p.CategoryID == cmbCategory.SelectedIndex + 1
                         select p.UnitPrice).FirstOrDefault() == 0)
                    {
                        db.Prices.Add(new Price()
                        {
                            ProductClassID = cmbClass.SelectedIndex + 1,
                            SizeID = size,
                            UnitPrice = price,
                            CategoryID = cmbCategory.SelectedIndex + 1,
                            ModifiedDate = DateTime.Now,
                            UserID = _user.UserID
                        });
                    }
                    else
                    {
                        db.Prices.FirstOrDefault(p => p.ProductClassID == cmbClass.SelectedIndex + 1 && p.SizeID == size).UnitPrice = price;
                        MessageBox.Show("Güncellendi");
                    }
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Fiyat hatalı girildi!");
            }
            FiyatYukle();
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            int size = 2;
            if (decimal.TryParse(txtM.Text, out decimal price))
            {
                using (var db = new MyDBEntities())
                {
                    if ((from p in db.Prices
                         where p.ProductClassID == cmbClass.SelectedIndex + 1 && p.SizeID == size && p.CategoryID == cmbCategory.SelectedIndex + 1
                         select p.UnitPrice).FirstOrDefault() == 0)
                    {
                        db.Prices.Add(new Price()
                        {
                            ProductClassID = cmbClass.SelectedIndex + 1,
                            SizeID = size,
                            UnitPrice = price,
                            CategoryID = cmbCategory.SelectedIndex + 1,
                            ModifiedDate = DateTime.Now,
                            UserID = _user.UserID
                        });
                    }
                    else
                    {
                        db.Prices.FirstOrDefault(p => p.ProductClassID == cmbClass.SelectedIndex + 1 && p.SizeID == size).UnitPrice = price;
                        MessageBox.Show("Güncellendi");
                    }
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Fiyat hatalı girildi!");
            }
            FiyatYukle();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            int size = 3;
            if (decimal.TryParse(txtL.Text, out decimal price))
            {
                using (var db = new MyDBEntities())
                {
                    if ((from p in db.Prices
                         where p.ProductClassID == cmbClass.SelectedIndex + 1 && p.SizeID == size && p.CategoryID == cmbCategory.SelectedIndex + 1
                         select p.UnitPrice).FirstOrDefault() == 0)
                    {
                        db.Prices.Add(new Price()
                        {
                            ProductClassID = cmbClass.SelectedIndex + 1,
                            SizeID = size,
                            UnitPrice = price,
                            CategoryID = cmbCategory.SelectedIndex + 1,
                            ModifiedDate = DateTime.Now,
                            UserID = _user.UserID
                        });
                    }
                    else
                    {
                        db.Prices.FirstOrDefault(p => p.ProductClassID == cmbClass.SelectedIndex + 1 && p.SizeID == size).UnitPrice = price;
                        MessageBox.Show("Güncellendi");
                    }
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Fiyat hatalı girildi!");
            }
            FiyatYukle();
        }

        private void btnXL_Click(object sender, EventArgs e)
        {
            int size = 4;
            if (decimal.TryParse(txtXL.Text, out decimal price))
            {
                using (var db = new MyDBEntities())
                {
                    if ((from p in db.Prices
                         where p.ProductClassID == cmbClass.SelectedIndex + 1 && p.SizeID == size && p.CategoryID == cmbCategory.SelectedIndex + 1
                         select p.UnitPrice).FirstOrDefault() == 0)
                    {
                        db.Prices.Add(new Price()
                        {
                            ProductClassID = cmbClass.SelectedIndex + 1,
                            SizeID = size,
                            UnitPrice = price,
                            CategoryID = cmbCategory.SelectedIndex + 1,
                            ModifiedDate = DateTime.Now,
                            UserID = _user.UserID
                        });
                    }
                    else
                    {
                        db.Prices.FirstOrDefault(p => p.ProductClassID == cmbClass.SelectedIndex + 1 && p.SizeID == size).UnitPrice = price;
                        MessageBox.Show("Güncellendi");
                    }
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Fiyat hatalı girildi!");
            }
            FiyatYukle();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiyatYukleText();
        }
    }
}
