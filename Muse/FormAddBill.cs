using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Muse.Model;

namespace Muse
{
    public partial class FormAddBill : Form
    {   
        public FormAddBill()
        {
            InitializeComponent();
            txtCustomerName.Enabled = false;
            txtCustomerCode.Enabled = false;
            txtProductName.Enabled = false;
            txtProductCode.Enabled = false;
        }

        private void assignCustomer(string id, string name)
        {
            txtCustomerCode.Text = id;
            txtCustomerName.Text = name;
        }

        private void assignProduct(string id, string name)
        {
            txtProductCode.Text = id;
            txtProductName.Text = name;
        }

        private void btnBrowseCustomer_Click(object sender, EventArgs e)
        {
            new FormListing(Contract.Customer, assignCustomer).ShowDialog();
        }

        private void btnBrowseProduct_Click(object sender, EventArgs e)
        {
            new FormListing(Contract.Product, assignProduct).ShowDialog();
        }

        private void btnAssignCustomer_Click(object sender, EventArgs e)
        {
            var customerId = int.Parse(txtCustomerCode.Text);
            var now = DateTime.Now;

            using (var db = new RestoContext())
            {
                var bill = new Bill
                {
                    CustomerId = customerId,
                    Tax = 0,
                    Paid = false,
                    CreatedAt = now,
                    UpdatedAt = now
                };

                db.Bills.Add(bill);
                db.SaveChanges();
            }
        }
    }
}
