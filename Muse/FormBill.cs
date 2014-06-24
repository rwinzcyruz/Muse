using Muse.Model;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Muse
{
    public partial class FormBill : Form
    {
        private RestoContext _db;

        public FormBill()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dgv.AutoGenerateColumns = true;
            
            _db = new RestoContext();
            _db.Bills.Where(x => x.Paid == false).OrderByDescending(x => x.UpdatedAt).Load();
            bindingSource.DataSource = _db.Bills.Local.ToBindingList();
            //bindingSource.DataSource = _db.Bills.Local.Select(x => new { x.Id, x.Customer.Name, x.Paid, x.Tax, x.CreatedAt, x.UpdatedAt }).ToList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this._db.Dispose();
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            var result = new FormAddBill().ShowDialog();
            //mUtilities.Validate(dgv.
            if (result == DialogResult.OK)
            {
                _db.Bills.Load();
                bindingSource.DataSource = _db.Bills.Local.Select(x => new { x.Id, x.Customer.Name, x.Paid, x.Tax, x.CreatedAt, x.UpdatedAt })
                    .Where(x => x.Paid == false).OrderByDescending(x => x.UpdatedAt).ToList();
            }
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            FormAddBill frmAddBill = new FormAddBill();
            //var result = new FormAddBill().ShowDialog();
            var result = frmAddBill.ShowDialog();
            frmAddBill.btnAssignCustomer.Enabled = false;
            frmAddBill.btnBrowseCustomer.Enabled = false;
            frmAddBill.btnBrowseProduct.Enabled = false;
            
            if (result == DialogResult.OK)
            {
                _db.Bills.Load();
                //bindingSource.DataSource = _db.Bills.Local.Select(x => new { x.Id, x.Customer.Name, x.Paid, x.Tax, x.CreatedAt, x.UpdatedAt })
                //    .Where(x => x.Paid == false).OrderByDescending(x => x.UpdatedAt).ToList();
            }
        }
    }
}