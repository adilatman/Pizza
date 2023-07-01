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
using System.Transactions;
using System.Windows.Forms;

namespace Pizza.UI
{
    public partial class YntMalzemeEkleme : Form
    {
        User _user = null;
        public YntMalzemeEkleme(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void YntMalzemeEkleme_Load(object sender, EventArgs e)
        {
            MalzemeleriDoldur();
        }

        private void MalzemeleriDoldur()
        {
            lstMaterial2.Items.Clear();
            using (var db = new MyDBEntities())
            {
                var materials = db.Materials.ToList();
                var materialPrices = db.MaterialPrices.ToList();
                foreach (var material in materials.OrderBy(m => m.MaterialName))
                {
                    foreach (var price in materialPrices)
                    {
                        if (material.MaterialID == price.MaterialID)
                        {
                            lstMaterial.Items.Add(material);
                            ListViewItem li = new ListViewItem();
                            li.Text=material.MaterialName;
                            li.SubItems.Add(price.MaterialUnitPrice.ToString());
                            lstMaterial2.Items.Add(li);
                        }
                    }
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        { 
            if(decimal.TryParse(txtMaterialPrice.Text, out var price)) 
            {
                if (string.IsNullOrWhiteSpace(txtMaterialName.Text))
                {
                    MessageBox.Show("Malzeme adı boş olamaz!");
                    return;
                }
                using (TransactionScope tran = new TransactionScope())
                {
                    using (var db = new MyDBEntities())
                    {
                        if (db.Materials.Where(m=>m.MaterialName==txtMaterialName.Text).SingleOrDefault()!=null)
                        {
                            MessageBox.Show("Malzeme mevcut! Güncelleme yapınız.");
                            MalzemeleriDoldur();
                            txtMaterialName.Text = txtMaterialPrice.Text = string.Empty;
                            return;
                        }
                        try
                        {
                            Material newMaterial = db.Materials.Add(new Material
                            {
                                MaterialName = txtMaterialName.Text,
                                ModifiedDate = DateTime.Now,
                                UserID = _user.UserID
                            });
                            db.MaterialPrices.Add(new MaterialPrice
                            {
                                MaterialID = newMaterial.MaterialID,
                                MaterialUnitPrice = price,
                                ModifiedDate = DateTime.Now,
                                UserID = _user.UserID
                            });
                            db.SaveChanges();
                            tran.Complete();
                            MessageBox.Show("Eklendi");
                        }
                        catch (Exception ex)
                        {
                            tran.Dispose();
                            MessageBox.Show("Hata: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Fiyat formatı hatalı!");
                return;
            }
            txtMaterialName.Text = txtMaterialPrice.Text=string.Empty;
            MalzemeleriDoldur();
        }

        private void lstMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            Material material = lstMaterial.SelectedItem as Material;
            if (material != null)
            {
                txtMaterialName.Text = material.MaterialName;
                using (var db = new MyDBEntities())
                {
                    txtMaterialPrice.Text = db.MaterialPrices.Where(m => m.MaterialID == material.MaterialID).Single().ToString();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMaterialPrice.Text, out decimal price))
            {
                using (var db = new MyDBEntities())
                {
                    Material material = lstMaterial.SelectedItem as Material;
                    if (material != null)
                    {
                        MaterialPrice materialPrice = db.MaterialPrices.Single(m => m.MaterialID == material.MaterialID);
                        materialPrice.MaterialUnitPrice = price;
                        materialPrice.ModifiedDate= DateTime.Now;
                        db.SaveChanges();
                    }
                }
                MessageBox.Show("Güncellendi");
            }
            else
            {
                MessageBox.Show("Mazleme fiyatını hatalı girdiniz!");
            }
            MalzemeleriDoldur();
            txtMaterialName.Text = txtMaterialPrice.Text = string.Empty;
        }
    }
}
