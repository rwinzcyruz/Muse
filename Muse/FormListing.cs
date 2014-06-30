using Muse.Model;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Muse {

    public partial class FormListing : Form {
        private Contract _contract;
        private Action<string, string> _assignData;
        private RestoContext _db;
        private int _rowIndex;

        public FormListing(Contract contract) {
            InitializeComponent();
            _contract = contract;
        }

        public FormListing(Contract contract, Action<string, string> assignData) {
            InitializeComponent();
            _contract = contract;
            _assignData = assignData;
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            dgv.AutoGenerateColumns = true;

            _db = new RestoContext();
            switch (_contract) {
                case Contract.Customer:
                    Text += " Pelanggan";
                    _db.Customers.OrderByDescending(x => x.UpdatedAt).Load();
                    bindingSource.DataSource = _db.Customers.Local.ToBindingList();
                    break;

                case Contract.Product:
                    Text += " Produk";
                    _db.Products.OrderByDescending(x => x.UpdatedAt).Load();
                    bindingSource.DataSource = _db.Products.Local.ToBindingList();
                    break;

                case Contract.User:
                    Text += " Pengguna";
                    _db.Users.OrderByDescending(x => x.UpdatedAt).Load();
                    bindingSource.DataSource = _db.Users.Local.ToBindingList();
                    break;
            }
        }

        protected override void OnClosing(CancelEventArgs e) {
            base.OnClosing(e);
            this._db.Dispose();
        }

        private int _getRowId() {
            return int.Parse(dgv.Rows[_rowIndex].Cells["Id"].Value.ToString());
        }

        # region Event Handler

        private void btnAdd_Click(object sender, EventArgs e) {
            switch (_contract) {
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

        private void btnEdit_Click(object sender, EventArgs e) {
            switch (_contract) {
                case Contract.Customer:
                    new FormAddCustomer(_db.Customers.Find(_getRowId()), customer => {
                        _db.Customers.Attach(customer);
                        _db.Entry(customer).State = EntityState.Modified;
                    }).ShowDialog();
                    break;

                case Contract.Product:
                    new FormAddProduct(_db.Products.Find(_getRowId()), product => {
                        _db.Products.Attach(product);
                        _db.Entry(product).State = EntityState.Modified;
                    }).ShowDialog();
                    break;

                case Contract.User:
                    new FormAddUser(_db.Users.Find(_getRowId()), user => {
                        _db.Users.Attach(user);
                        _db.Entry(user).State = EntityState.Modified;
                    }).ShowDialog();
                    break;
            }

            _db.SaveChanges();
            dgv.Refresh();
        }

        private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (_assignData != null) {
                var cells = dgv.Rows[e.RowIndex].Cells;
                _assignData(cells["Id"].Value.ToString(), cells["Name"].Value.ToString());
                Close();
            }
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e) {
            _rowIndex = e.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (!Utility.ConfirmDelete()) {
                return;
            }

            switch (_contract) {
                case Contract.Customer:
                    var dropCustomer = _db.Customers.SingleOrDefault(x => x.Id == _getRowId());
                    if (dropCustomer != null) {
                        _db.Customers.Remove(dropCustomer);
                    }
                    break;

                case Contract.Product:
                    var dropProduct = _db.Products.SingleOrDefault(x => x.Id == _getRowId());
                    if (dropProduct != null) {
                        _db.Products.Remove(dropProduct);
                    }
                    break;

                case Contract.User:
                    var dropUsers = _db.Users.SingleOrDefault(x => x.Id == _getRowId());
                    if (dropUsers != null) {
                        _db.Users.Remove(dropUsers);
                    }
                    break;
            }

            _db.SaveChanges();
        }

        # endregion
    }
}