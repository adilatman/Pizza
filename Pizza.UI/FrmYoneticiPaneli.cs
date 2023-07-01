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
    public partial class FrmYoneticiPaneli : Form
    {
        User _user = null;
        public FrmYoneticiPaneli(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void urunEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YntUrunEkleme frm = new YntUrunEkleme(_user);
            frm.MdiParent = this;
            frm.Show();
        }

        private void malzemeEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YntMalzemeEkleme frm = new YntMalzemeEkleme(_user);
            frm.MdiParent = this;
            frm.Show();
        }

        private void boyutEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YntBoyutEkleme frm = new YntBoyutEkleme(_user);
            frm.MdiParent = this;
            frm.Show();
        }

        private void kategoriEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YntKategoriEkleme frm = new YntKategoriEkleme(_user);
            frm.MdiParent = this;
            frm.Show();
        }

        private void sinifEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YntSinifEkleme frm = new YntSinifEkleme(_user);
            frm.MdiParent = this;
            frm.Show();
        }

        private void logInEkraninaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn frm = new LogIn();
            frm.Show();
        }

        private void ıcerikEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YntIcerikEkleme frm = new YntIcerikEkleme(_user);
            frm.MdiParent = this;
            frm.Show();
        }

        private void fiyatEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YntFiyatEkleme frm = new YntFiyatEkleme(_user);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
