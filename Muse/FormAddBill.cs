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
            if (txtCustomerCode.Text != "")
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
                    //db.SaveChanges();
                }

                btnAssignCustomer.Enabled = false;
                DialogResult = DialogResult.OK;
            }
        }

        private void FormAddBill_Load(object sender, EventArgs e)
        {

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            var quatity = int.Parse(txtQuantity.Text);
            var now = DateTime.Now;
            var product = int.Parse(txtProductCode.Text);
            using (var db = new RestoContext())
            {
                //db.Orders.Add(new Order
                //{
                //    Quantity = quatity,
                //    CreatedAt = now,
                //    UpdatedAt = now
                //});
                var order = new Order
                {
                    ProductId = product,
                    Quantity = quatity,
                    CreatedAt = now,
                    UpdatedAt = now
                };
                db.Orders.Add(order);
                db.SaveChanges();
            }
            //bindingSource.DataSource = _db.Bills.Local.Select(x => new { x.Id, x.Customer.Name, x.Paid, x.Tax, x.CreatedAt, x.UpdatedAt })
            //    .Where(x => x.Paid == false).OrderByDescending(x => x.UpdatedAt).ToList();
            //dataGridView1.DataSource = _db.Orders.Local.Select(x => new { x.
        }
    }
}
