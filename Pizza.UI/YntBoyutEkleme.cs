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
    public partial class YntBoyutEkleme : Form
    {
        User _user = null;
        public YntBoyutEkleme(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void YntBoyutEkleme_Load(object sender, EventArgs e)
        {
            BoyutYukle();
        }

        private void BoyutYukle()
        {
            lstSize.Items.Clear();
            using (var db = new MyDBEntities())
            {
                var sizes = db.Sizes.ToList();
                foreach (var size in sizes.OrderBy(p => p.SizeName))
                {
                    lstSize.Items.Add(size);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSize.Text))
            {
                using (var db = new MyDBEntities())
                {
                    if (db.Sizes.Where(m => m.SizeName == txtSize.Text).SingleOrDefault() != null)
                    {
                        MessageBox.Show("Boyut mevcut! Güncelleme yapınız.");
                        BoyutYukle();
                        txtSize.Text = string.Empty;
                        return;
                    }
                    db.Sizes.Add(new Core.Entity.Size()
                    {
                        SizeName = txtSize.Text,
                        ModifiedDate = DateTime.Now,
                        UserID = _user.UserID
                    });
                    db.SaveChanges();
                    MessageBox.Show("Eklendi");
                }
            }
            else
            {
                MessageBox.Show("Boyut adı boş olamaz");
            }
            txtSize.Text = string.Empty;
            BoyutYukle();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSize.Text != null)
            {
                using (var db = new MyDBEntities())
                {
                    Core.Entity.Size boyut = lstSize.SelectedItem as Core.Entity.Size;
                    if (boyut != null)
                    {
                        Core.Entity.Size dbBoyut = db.Sizes.Single(s => s.SizeID == boyut.SizeID);
                        dbBoyut.SizeName= txtSize.Text;
                        dbBoyut.ModifiedDate = DateTime.Now;
                        dbBoyut.UserID = _user.UserID;
                        db.SaveChanges();
                    }
                }
                MessageBox.Show("Güncellendi");
            }
            else
            {
                MessageBox.Show("Boyut adı boş olamaz");
            }
            txtSize.Text = string.Empty;
            BoyutYukle();
        }

        private void lstSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Core.Entity.Size boyut = lstSize.SelectedItem as Core.Entity.Size;
            if (boyut != null)
            {
                txtSize.Text = boyut.SizeName;
            }
        }
    }
}
