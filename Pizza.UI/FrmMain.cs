using Pizza.Core.Context;
using Pizza.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Pizza.UI
{
    public partial class FrmMain : Form
    {
        User _user = null;
        public FrmMain(User user)
        {
            InitializeComponent();
            _user = user;
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            PizzaDoldur();
            IcecekDoldur();
            MalzemeDoldur();
            MusteriDoldur();
        }
        private void PizzaDoldur()
        {
            cmbPizza.SelectedIndexChanged -= cmbPizza_SelectedIndexChanged; //selectedindexchanged eventini gecici sureyle uyutuyoruz.
            using (var db = new MyDBEntities())
            {
                cmbPizza.DataSource = db.Products.Where(p => p.CategoryID == 1).OrderBy(p => p.ProductName).ToList();
            }
            cmbPizza.SelectedItem = null;
            cmbPizza.SelectedIndexChanged += cmbPizza_SelectedIndexChanged; //yukeme tamamlaninca tekrar aktiflestiriyoruz
        }
        private void MusteriDoldur()
        {
            lstMusteri.Items.Clear();
            using (MyDBEntities db = new MyDBEntities())
            {
                var customers = db.Customers.ToList();
                foreach (var customer in customers.OrderBy(c => c.CustomerName))
                {
                    lstMusteri.Items.Add(customer);
                }
            }
            lstMusteri.SelectedItem = null;
        }
        private void IcecekDoldur()
        {
            cmbIcecek.SelectedIndexChanged -= cmbIcecek_SelectedIndexChanged; //selectedindexchanged eventini gecici sureyle uyutuyoruz.
            using (var db = new MyDBEntities())
            {
                cmbIcecek.DataSource = db.Products.Where(a => a.CategoryID == 2).OrderBy(a => a.ProductName).ToList();
            }
            cmbIcecek.SelectedItem = null;
            cmbIcecek.SelectedIndexChanged += cmbIcecek_SelectedIndexChanged; //yukeme tamamlaninca tekrar aktiflestiriyoruz
        }
        private void MalzemeDoldur()
        {
            using (var db = new MyDBEntities())
            {
                var result2 = from mtr in db.Materials
                              join mpr in db.MaterialPrices
                              on new { mtr.MaterialID } equals new { mpr.MaterialID }
                              select new
                              {
                                  MalzemeAdi = mtr.MaterialName,
                                  MalzemeFiyati = mpr.MaterialUnitPrice,
                                  MalzemeID= mpr.MaterialID
                              };

                foreach (var item in result2.OrderBy(r => r.MalzemeAdi))
                {
                    System.Windows.Forms.CheckBox chk = new System.Windows.Forms.CheckBox();
                    chk.Text = item.MalzemeFiyati + "-" + item.MalzemeAdi;
                    decimal fiyat = item.MalzemeFiyati;
                    chk.Tag = item.MalzemeID.ToString();
                    chk.CheckedChanged += Chk_CheckedChanged;
                    flwMaterials.Controls.Add(chk);
                }
            }
        }
        private void IcerikDoldur() // icine vscode araciligi ile deneme amacli  (02.07.2023)
        {
            flwContents.Controls.Clear();
            Product product = cmbPizza.SelectedItem as Product;
            if (product != null)
            {
                using (var db = new MyDBEntities())
                {
                    var result = from p in db.Products
                                 join c in db.Contents
                                 on new { A = p.ProductID } equals new { A = c.ProductID }
                                 join m in db.Materials
                                 on new { A = c.MaterialID } equals new { A = m.MaterialID }
                                 join mp in db.MaterialPrices
                                 on new { A = m.MaterialID } equals new { A = mp.MaterialID }
                                 where p.ProductID == product.ProductID
                                 select new
                                 {
                                     Malzeme = m.MaterialName
                                 };
                    foreach (var item in result)
                    {
                        lblIcindekiler.Text += item.Malzeme + ", ";
                    }
                    flwContents.Controls.Add(lblIcindekiler);
                }
            }
        }
        private void FiyatHesapla()
        {
            Product pizza = cmbPizza.SelectedItem as Product;
            int pizzaBoy = rdbS.Checked == true ? 1 : rdbM.Checked == true ? 2 : rdbL.Checked == true ? 3 : 4;
            decimal pizzaFiyati = 0;
            decimal pizzaAdet = nmrPizza.Value;

            Product icecek = cmbIcecek.SelectedItem as Product;
            int icecekBoy = 1;
            decimal icecekFiyati = 0;
            decimal icecekAdet = nmrIcecek.Value;

            decimal malzemeFiyatToplam = 0;

            using (var db = new MyDBEntities())
            {
                if (pizza != null)
                {
                    pizzaFiyati = (from up in db.Prices
                                   where up.ProductClassID == pizza.ProductClassID && up.SizeID == pizzaBoy && up.CategoryID == pizza.CategoryID
                                   select up.UnitPrice).Single();
                }
                else
                {
                    pizzaFiyati = 0;
                }
                if (icecek != null)
                {
                    icecekFiyati = (from up in db.Prices
                                    where up.ProductClassID == icecek.ProductClassID && up.SizeID == icecekBoy && up.CategoryID == icecek.CategoryID
                                    select up.UnitPrice).Single();
                }
                else
                {
                    icecekFiyati = 0;
                }
            }


            //todo tag dolu olmasina ragmen bu blokta null geliyor. incele ve duzelt
            foreach (System.Windows.Forms.CheckBox chk in flwMaterials.Controls)
            {
                if (chk.Checked)
                {                    
                    int dashIndex = chk.Text.IndexOf("-");
                    if (dashIndex != -1)
                    {
                        malzemeFiyatToplam += Convert.ToDecimal(chk.Text.Substring(0, dashIndex).Trim());
                    }
                }

            }
            decimal araToplam = ((pizzaFiyati + malzemeFiyatToplam) * pizzaAdet) + (icecekFiyati * icecekAdet);
            lblAraToplam.Text = araToplam.ToString();
            araToplam = 0;

        }
        private void MalzemeleriTemizle()
        {
            foreach (System.Windows.Forms.CheckBox chk in flwMaterials.Controls)
            {
                chk.CheckedChanged -= Chk_CheckedChanged;
                chk.Checked = false;
                chk.CheckedChanged += Chk_CheckedChanged;
            }
        }
        private void FormuTemizle()
        {
            rdbM.Checked = true;
            lblAraToplam.Text = lblSiparisToplami.Text = lblIcindekiler.Text = "0";
            txtTel.Text = string.Empty;
            lstCart.Items.Clear();
            nmrPizza.Value = nmrIcecek.Value = 1;
            cmbIcecek.SelectedItem = null;
            cmbPizza.SelectedItem = null;
            MalzemeleriTemizle();
            lstCart.Items.Clear();
            if (lstMusteri.Enabled == false) { lstMusteri.Enabled = true; }
            order = null;
            orderDetail = null;
            orderDetail2 = null;
            orderDetailExtra = null;
            orderDetails = null;
            orderDetails2 = null;
            orderDetailExtras = null;
        }
        private void btnCleanForm_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }
        private void cmbPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            errPizza.Clear();
            nmrPizza.Value = 1;
            rdbM.Checked = true;
            lblIcindekiler.Text = string.Empty;
            MalzemeleriTemizle();
            IcerikDoldur();
            FiyatHesapla();
        }
        private void cmbIcecek_SelectedIndexChanged(object sender, EventArgs e)
        {
            errPizza.Clear();
            nmrIcecek.Value = 1;
            FiyatHesapla();
        }
        private void Chk_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox chk = sender as System.Windows.Forms.CheckBox;
            Product product = cmbPizza.SelectedItem as Product;
            if (product == null)
            {
                errPizza.SetError(chk, "Önce pizza seçiniz!");
                chk.Checked = false;
                return;
            }
            FiyatHesapla();
        }
        private void nmrIcecek_ValueChanged(object sender, EventArgs e)
        {
            Product product = cmbIcecek.SelectedItem as Product;
            if (product == null)
            {
                errPizza.SetError(nmrIcecek, "Önce içecek seçiniz!");
                nmrIcecek.Value = 1;
                return;
            }
            FiyatHesapla();
        }
        private void nmrPizza_ValueChanged(object sender, EventArgs e)
        {
            Product product = cmbPizza.SelectedItem as Product;
            if (product == null)
            {
                errPizza.SetError(nmrPizza, "Önce pizza seçiniz!");
                nmrPizza.Value = 1;
                return;
            }
            FiyatHesapla();
        }
        private void rdbS_Click(object sender, EventArgs e)
        {
            FiyatHesapla();
        }
        private void rdbM_Click(object sender, EventArgs e)
        {
            FiyatHesapla();
        }
        private void rdbL_Click(object sender, EventArgs e)
        {
            FiyatHesapla();
        }
        private void rdbXL_Click(object sender, EventArgs e)
        {
            FiyatHesapla();
        }
        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            lstMusteri.Items.Clear();
            using (MyDBEntities db = new MyDBEntities())
            {
                var customers = db.Customers
                    .Where(c => db.Connections.Any(a => c.CustomerID == a.CustomerID && a.ConnectionDetail.Contains(txtTel.Text)))
                    .ToList();
                foreach (var customer in customers.OrderBy(c => c.CustomerName))
                {
                    lstMusteri.Items.Add(customer);
                }
            }
        }
        private void txtIsimAra_TextChanged(object sender, EventArgs e)
        {
            lstMusteri.Items.Clear();
            using (MyDBEntities db = new MyDBEntities())
            {
                var customers = db.Customers
                                .Where(c => c.CustomerName.Contains(txtIsimAra.Text))
                                .ToList();
                foreach (var customer in customers.OrderBy(c => c.CustomerName))
                {
                    lstMusteri.Items.Add(customer);
                }
            }
        }
        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri frm = new FrmYeniMusteri(_user);
            frm.Show();
            txtTel.Text = null;
        }
        private void lstMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            errOrder.Clear();
        }
        Order order = null;
        OrderDetail orderDetail = null;
        OrderDetail orderDetail2 = null; //malzemeler orderdetailexta'ya ekleniyor. mukerrer id uyarisi nedeniyle pizza ve icecek detaylari ayrildi
        OrderDetailExtra orderDetailExtra = null;
        List<OrderDetail> orderDetails = null;
        List<OrderDetail> orderDetails2 = null;
        List<OrderDetailExtra> orderDetailExtras = null;
        private void btnISepeteEkle_Click(object sender, EventArgs e)
        {
            Customer customer = lstMusteri.SelectedItem as Customer;
            if (customer != null)
            {
                if (order == null) 
                { 
                    order = new Order();
                    order.OrderID = Guid.NewGuid();
                    order.CustomerID = customer.CustomerID;
                    order.OrderDate = DateTime.Now;
                    order.UserID = _user.UserID;
                }
                lstMusteri.Enabled = false;
                lblSiparisToplami.Text = (Convert.ToDecimal(lblSiparisToplami.Text) + Convert.ToDecimal(lblAraToplam.Text)).ToString();
                if (orderDetails == null)
                {
                    orderDetails = new List<OrderDetail>();
                }
                if (orderDetailExtras == null)
                {
                    orderDetailExtras = new List<OrderDetailExtra>();
                }
                if (cmbPizza.SelectedItem != null)
                {
                    if (orderDetail == null)
                    {
                        orderDetail = new OrderDetail();
                    }
                    Product pizza = cmbPizza.SelectedItem as Product;
                    orderDetail.OrderID = order.OrderID;
                    orderDetail.ProductID = pizza.ProductID;
                    orderDetail.Quantity = Convert.ToInt32(nmrPizza.Value);
                    orderDetail.SizeID = rdbS.Checked == true ? 1 : rdbM.Checked == true ? 2 : rdbL.Checked == true ? 3 : 4;
                    orderDetail.UserID = _user.UserID;
                    orderDetails.Add(orderDetail);

                    foreach (System.Windows.Forms.CheckBox chk in flwMaterials.Controls)
                    {
                        if (chk.Checked)
                        {
                            orderDetailExtra = new OrderDetailExtra();
                            orderDetailExtra.MaterialID = Convert.ToInt32(chk.Tag);
                            orderDetailExtra.OrderDetailID = orderDetail.OrderDetailID;
                            orderDetailExtras.Add(orderDetailExtra);
                            orderDetailExtra = null;
                        }
                    }
                    
                    ListViewItem li = new ListViewItem();
                    li.Text = pizza.ProductName;
                    li.SubItems.Add(orderDetail.SizeID == 1 ? "Küçük" : orderDetail.SizeID == 2 ? "Orta" : orderDetail.SizeID == 3 ? "Büyük" : "XL");
                    li.SubItems.Add(nmrPizza.Value.ToString());
                    lstCart.Items.Add(li);
                    orderDetail = null;
                }
                if (cmbIcecek.SelectedItem != null)
                {
                    if (orderDetails2 == null)
                    {
                        orderDetails2 = new List<OrderDetail>();
                    }
                    if (orderDetail2 == null)
                    {
                        orderDetail2 = new OrderDetail();
                    }
                    Product icecek = cmbIcecek.SelectedItem as Product;
                    orderDetail2.OrderID = order.OrderID;
                    orderDetail2.ProductID = icecek.ProductID;
                    orderDetail2.Quantity = Convert.ToInt32(nmrIcecek.Value);
                    orderDetail2.SizeID = 1;
                    orderDetail2.UserID = _user.UserID;
                    orderDetails2.Add(orderDetail2);
                    ListViewItem li = new ListViewItem();
                    li.Text = icecek.ProductName;
                    li.SubItems.Add("-");
                    li.SubItems.Add(nmrIcecek.Value.ToString());
                    lstCart.Items.Add(li);
                    orderDetail2 = null;
                }
                nmrIcecek.Value = 1;
                nmrPizza.Value = 1;
                cmbIcecek.SelectedItem = null;
                cmbPizza.SelectedItem = null;
                rdbM.Checked = true;
                lblAraToplam.Text = "0";
            }
            else
            {
                errOrder.SetError(btnISepeteEkle, "Müşteri seçiniz!");
            }
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (order == null)
            {
                errOrder.SetError(btnOrder, "Sepete ekleme yapmadınız!");
                return;
            }
            using (TransactionScope tran = new TransactionScope())
            {
                using (var db = new MyDBEntities())
                {
                    try
                    {
                        db.Orders.Add(new Order()
                        {
                            OrderID = order.OrderID,
                            CustomerID = order.CustomerID,
                            OrderDate = order.OrderDate,
                            UserID = order.UserID
                        });
                        if (orderDetails!=null)
                        {
                            db.OrderDetails.AddRange(orderDetails);                            
                        }
                        if (orderDetailExtras != null)
                        {
                            foreach (var item in orderDetailExtras)
                            {
                                db.OrderDetailExtras.Add(new OrderDetailExtra()
                                {
                                    MaterialID = item.MaterialID,
                                    OrderDetailID = item.OrderDetailID
                                });
                            }
                        }
                        db.SaveChanges();
                        if (orderDetails2!=null)
                        {
                            db.OrderDetails.AddRange(orderDetails2);
                        }                        
                        
                        db.SaveChanges();
                        tran.Complete();
                        MessageBox.Show("Sipariş alındı.");
                        if (lstMusteri.Enabled == false) { lstMusteri.Enabled = true; }
                    }
                    catch (Exception ex)
                    {
                        tran.Dispose();
                        MessageBox.Show("Sipariş alınırken hata oluştu. Hata: " + ex.Message);
                    }
                }
            }
            lblAraToplam.Text = "0";
            lblSiparisToplami.Text = "0";
            FormuTemizle();
            MusteriDoldur();
        }

        private void lblGC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn frm = new LogIn();
            frm.Show();
            this.Close();
        }
    }
}
