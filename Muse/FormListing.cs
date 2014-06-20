using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Muse
{
    public partial class FormListing : Form
    {
        private Contract _contract;
        private Action<string, string> _assignData;
        private RestoContext _context;

        public FormListing(Contract contract)
        {
            InitializeComponent();
            _contract = contract;
        }

        public FormListing(Contract contract, Action<string, string> assignData)
        {
            InitializeComponent();
            _contract = contract;
            _assignData = assignData;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dgv.AutoGenerateColumns = true;
            _context = new RestoContext();

            switch (_contract)
            {
                case Contract.Customer:
                    Text += " Pelanggan";
                    _context.Customers.Load();
                    bindingSource.DataSource = _context.Customers.Local.ToBindingList();
                    break;
                case Contract.Product:
                    Text += " Produk";
                    _context.Products.Load();
                    bindingSource.DataSource = _context.Products.Local.ToBindingList();
                    break;
                case Contract.User:
                    Text += " Pengguna";
                    _context.Users.Load();
                    bindingSource.DataSource = _context.Users.Local.ToBindingList();
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (_contract)
            {
                case Contract.Customer:
                    new FormAddCustomer(customer => _context.Customers.Add(customer)).ShowDialog();
                    break;
                case Contract.Product:
                    new FormAddProduct(product => _context.Products.Add(product)).ShowDialog();
                    break;
                case Contract.User:
                    new FormAddUser(user => _context.Users.Add(user)).ShowDialog();
                    break;
            }
            _context.SaveChanges();
        }

        private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_assignData != null)
            {
                var cells = dgv.Rows[e.RowIndex].Cells;
                _assignData(cells["id"].Value.ToString(), cells["name"].Value.ToString());
                Close();
            }
        }
    }
}
