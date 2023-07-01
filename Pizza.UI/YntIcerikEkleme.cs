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
    public partial class YntIcerikEkleme : Form
    {
        User _user = null;
        public YntIcerikEkleme(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void YntIcerikEkleme_Load(object sender, EventArgs e)
        {
            UrunDoldur();
            MalzemeDoldur();
            IcerikDoldur();
        }

        private void IcerikDoldur()
        {
            lstContent.Items.Clear();
            using (var db = new MyDBEntities())
            {
                var contents = db.Contents.ToList();
                foreach (var item in contents)
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = db.Products.Where(p=>p.ProductID == item.ProductID).SingleOrDefault().ProductName;
                    li.SubItems.Add(db.Materials.Where(p => p.MaterialID == item.MaterialID).SingleOrDefault().MaterialName);
                    lstContent.Items.Add(li);
                }
            }
        }

        private void MalzemeDoldur()
        {
            cmbMaterial.Items.Clear();
            using (var db = new MyDBEntities())
            {
                cmbMaterial.DataSource = db.Materials.OrderBy(m=>m.MaterialName).ToList();
            }
        }

        private void UrunDoldur()
        {
            cmbProduct.Items.Clear();
            using (var db = new MyDBEntities())
            {
                cmbProduct.DataSource=db.Products.OrderBy(p=>p.ProductName).ToList();
            }
        }       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product=cmbProduct.SelectedItem as Product;
            Material material = cmbMaterial.SelectedItem as Material;
            using (var db = new MyDBEntities())
            {
                db.Contents.Add(new Content()
                {
                    ProductID= product.ProductID,
                    MaterialID= material.MaterialID,
                    UserID=_user.UserID,
                    ModifiedDate= DateTime.Now
                });
                db.SaveChanges();
            }
            MessageBox.Show("Eklendi");
            IcerikDoldur();
        }
    }
}
