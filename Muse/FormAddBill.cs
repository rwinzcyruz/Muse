using System;
using System.ComponentModel;
using System.Linq;
using System.Data.Entity;
using System.Windows.Forms;
using Muse.Model;
using System.Reflection;

namespace Muse {

    public partial class FormAddBill : Form {

        private RestoContext _db;
        private Bill _billToUpdate;
        private Order _orderToUpdate;
        private bool _isNew = true;
        private bool _isUpdate = false;
        private int _rowIndex;
        private int _toUpdateId;

        public FormAddBill() {
            InitializeComponent();
            _Init();
            editItem.Enabled = false;
            deleteItem.Enabled = false;
        }

        public FormAddBill(int id) {
            InitializeComponent();
            _toUpdateId = id;
            _isNew = false;
            _Init();
            btnBrowseCustomer.Enabled = false;
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            dgv.AutoGenerateColumns = true;
            _db = new RestoContext();
            //_db.Database.Log = Console.Write;

            if (!_isNew) {
                _billToUpdate = _db.Bills.Find(_toUpdateId);
                _Reload();
                txtCustomerCode.Text = _billToUpdate.CustomerId.ToString();
                txtCustomerName.Text = _billToUpdate.Customer.Name;
            }
        }

        protected override void OnClosing(CancelEventArgs e) {
            base.OnClosing(e);
            this._db.Dispose();
        }

        # region Private Method

        private void _Init() {
            txtCustomerName.Enabled = false;
            txtCustomerCode.Enabled = false;
            txtProductName.Enabled = false;
            txtProductCode.Enabled = false;
        }

        private void assignCustomer(string id, string name) {
            txtCustomerCode.Text = id;
            txtCustomerName.Text = name;
        }

        private void assignProduct(string id, string name) {
            txtProductCode.Text = id;
            txtProductName.Text = name;
        }

        private void _Reload() {
            _db.Bills.Where(x => x.Id == _billToUpdate.Id).Include(x => x.Orders.Select(o => o.Product)).Load();
            bindingSource.DataSource = _db.Orders.Local.Select(x => new { x.ProductId, x.Product.Name, x.Product.Price, x.Quantity, x.Total }).ToList();
        }

        private void _ClearForm() {
            txtProductCode.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();
        }

        # endregion

        # region Event Handler

        private void btnBrowseCustomer_Click(object sender, EventArgs e) {
            new FormListing(Contract.Customer, assignCustomer).ShowDialog();
        }

        private void btnBrowseProduct_Click(object sender, EventArgs e) {
            new FormListing(Contract.Product, assignProduct).ShowDialog();
            txtQuantity.Select();
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e) {
            _rowIndex = e.RowIndex;
        }

        private void saveItem_Click(object sender, EventArgs e) {
            if (!Utility.RequiredCheck(errorProvider, txtCustomerCode, txtProductCode, txtQuantity)) {
                return;
            }

            var customerId = int.Parse(txtCustomerCode.Text);
            var productId = int.Parse(txtProductCode.Text);
            var quantity = int.Parse(txtQuantity.Text);
            var now = DateTime.Now;

            if (_isNew) {
                _billToUpdate = _db.Bills.Add(new Bill {
                    CustomerId = customerId,
                    Paid = false,
                    Tax = 0.1,
                    CreatedAt = now,
                    UpdatedAt = now
                });
                _db.SaveChanges();
                _isNew = false;
                editItem.Enabled = true;
                deleteItem.Enabled = true;
            }

            if (_isUpdate) {
                _orderToUpdate.Quantity = quantity;
                _db.SaveChanges();
                _Reload();
                _isUpdate = false;
                _ClearForm();
            } else {
                var query = _billToUpdate.Orders.Where(x => x.ProductId == productId).SingleOrDefault();
                if (query == null) {
                    _billToUpdate.Orders.Add(new Order {
                        ProductId = productId,
                        Quantity = quantity,
                        CreatedAt = now,
                        UpdatedAt = now
                    });
                    _db.SaveChanges();
                    _Reload();
                } else {
                    MessageBox.Show("Menu makanan telah ditambahkan ke pesanan sebelumnya");
                }
            }

            deleteItem.Enabled = true;
            editItem.Enabled = true;
            btnBrowseProduct.Enabled = true;
            _ClearForm();
        }

        private void editItem_Click(object sender, EventArgs e) {
            editItem.Enabled = false;
            deleteItem.Enabled = false;
            btnBrowseProduct.Enabled = false;

            var id = int.Parse(dgv.Rows[_rowIndex].Cells["ProductId"].Value.ToString());
            var orderToUpdate = _db.Orders.Local.Where(x => x.ProductId == id).Single();
            txtProductCode.Text = orderToUpdate.ProductId.ToString();
            txtProductName.Text = orderToUpdate.Product.Name;
            txtQuantity.Text = orderToUpdate.Quantity.ToString();

            _orderToUpdate = orderToUpdate;
            _isUpdate = true;
            txtQuantity.Select();
        }

        private void deleteItem_Click(object sender, EventArgs e) {
            if (Utility.ConfirmDelete()) {
                var id = int.Parse(dgv.Rows[_rowIndex].Cells["ProductId"].Value.ToString());
                var orderToDelete = _db.Orders.Local.Where(x => x.ProductId == id).Single();
                _db.Orders.Remove(orderToDelete);
                _db.SaveChanges();
                _Reload();
            }

            if (dgv.Rows.Count == 0) {
                editItem.Enabled = false;
                deleteItem.Enabled = false;
            }
        }

        private void saveAllItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        # endregion
    }

}
