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
    public partial class FrmYeniMusteri : Form
    {
        User _user = null;
        public FrmYeniMusteri(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            if (txtYeniAd == null || txtYeniAdres == null)
            {
                MessageBox.Show("Müşteri eklemek için tüm alanları doldurmalıdısınız!");
                return;
            }
            List<Customer> customerSearchResult = null;
            using (MyDBEntities db = new MyDBEntities())
            {
                customerSearchResult = db.Customers
                   .Where(c => db.Connections.Any(a => c.CustomerID == a.CustomerID && a.ConnectionDetail == txtYeniTel.Text))
                   .ToList();
            }
            if (customerSearchResult.Count != 0)
            {
                if (MessageBox.Show("Dikkat! Bu telefon numarası en az bir müşteride kayıtlı. Mükerrer ekleme yapmadığınızdan emin olunuz.", "Dikkat", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                using (TransactionScope tran = new TransactionScope())
                {
                    using (MyDBEntities db = new MyDBEntities())
                    {
                        try
                        {
                            Customer customer = new Customer()
                            {
                                CustomerName = txtYeniAd.Text,
                                ModifiedDate = DateTime.Now,
                                UserID = _user.UserID
                            };
                            Customer newCustomer = db.Customers.Add(customer);
                            Connection connection = new Connection()
                            {
                                ConnectionDetail = txtYeniTel.Text,
                                CustomerID = newCustomer.CustomerID,
                                ConnectionTypeID = 1,
                                ModifiedDate = DateTime.Now,
                                UserID = _user.UserID
                            };
                            Connection connection2 = new Connection()
                            {
                                ConnectionDetail = txtYeniAdres.Text,
                                CustomerID = newCustomer.CustomerID,
                                ConnectionTypeID = 2,
                                ModifiedDate = DateTime.Now,
                                UserID = _user.UserID
                            };

                            db.Connections.Add(connection);
                            db.Connections.Add(connection2);
                            db.SaveChanges();
                            tran.Complete();
                            MessageBox.Show("Eklendi");
                        }
                        catch (Exception ex)
                        {
                            tran.Dispose();
                            MessageBox.Show("Hata :" + ex.Message);
                        }
                    }
                }
                this.Close();
            }



        }

        private void txtYeniTel_TextChanged(object sender, EventArgs e)
        {
            if (txtYeniTel.MaskCompleted)
            {
                btnMusteriEkle.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AnaMenuyeDon()
        {
            FrmMain frm = new FrmMain(_user);
            frm.Show();
        }
    }
}
