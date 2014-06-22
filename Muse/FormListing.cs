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
        private RestoContext _db;
        private int _rowIndex;

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
            _db = new RestoContext();

            switch (_contract)
            {
                case Contract.Customer:
                    Text += " Pelanggan";
                    _db.Customers.Load();
                    bindingSource.DataSource = _db.Customers.Local.ToBindingList();
                    break;
                case Contract.Product:
                    Text += " Produk";
                    _db.Products.Load();
                    bindingSource.DataSource = _db.Products.Local.ToBindingList();
                    break;
                case Contract.User:
                    Text += " Pengguna";
                    _db.Users.Load();
                    bindingSource.DataSource = _db.Users.Local.ToBindingList();
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (_contract)
            {
                case Contract.Customer:
                    new FormAddCustomer(customer => _db.Customers.Add(customer)).ShowDialog();
                    break;
                case Contract.Product:
                    new FormAddProduct(product => _db.Products.Add(product)).ShowDialog();
                    break;
                case Contract.User:
                    new FormAddUser(user => _db.Users.Add(user)).ShowDialog();
                    break;
            }

            _db.SaveChanges();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var id = int.Parse(dgv.Rows[_rowIndex].Cells["id"].Value.ToString());

            switch (_contract)
            {
                case Contract.Customer:
                    new FormAddCustomer(_db.Customers.Find(id) ,customer =>
                    {
                        _db.Customers.Attach(customer);
                        _db.Entry(customer).State = EntityState.Modified;
                    }).ShowDialog();
                    break;
                case Contract.Product:
                    new FormAddProduct(product =>
                    {
                        _db.Products.Attach(product);
                        _db.Entry(product).State = EntityState.Modified;
                    }).ShowDialog();
                    break;
                case Contract.User:
                    new FormAddUser(user =>
                    {
                        _db.Users.Attach(user);
                        _db.Entry(user).State = EntityState.Modified;
                    }).ShowDialog();
                    break;
            }

            _db.SaveChanges();
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

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _rowIndex = e.RowIndex;
        }
    }
}
