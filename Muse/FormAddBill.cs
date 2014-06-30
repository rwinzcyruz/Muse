using Muse.Model;
using Muse.ViewModel;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Muse {

    public partial class FormAddBill : Form {
        private Func<Bill, Bill> _saveModel;
        private Bill _billToUpdate;
        private Order _orderToUpdate;
        private Customer _customerToInclude;
        private Product _productToInclude;
        private bool _isNew = true;
        private bool _isUpdateOrder = false;
        private int _rowIndex;

        public FormAddBill(Func<Bill, Bill> saveModel) {
            InitializeComponent();
            _saveModel = saveModel;
            _Init();
            editItem.Enabled = false;
            deleteItem.Enabled = false;
        }

        public FormAddBill(Bill billToUpdate) {
            InitializeComponent();
            _billToUpdate = billToUpdate;
            _isNew = false;
            _fillForm();
            _Init();
            btnBrowseCustomer.Enabled = false;
        }

        private void _fillForm() {
            txtCustomerCode.Text = _billToUpdate.CustomerId.ToString();
            txtCustomerName.Text = _billToUpdate.Customer.Name;
            dgv.AutoGenerateColumns = true;
            _Reload();

            if (bindingSource.Count == 0) {
                editItem.Enabled = false;
                deleteItem.Enabled = false;
            }
        }

        # region Private Method

        private void _Init() {
            txtCustomerName.Enabled = false;
            txtCustomerCode.Enabled = false;
            txtProductName.Enabled = false;
            txtProductCode.Enabled = false;
        }

        private void _ClearForm() {
            txtProductCode.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();
        }

        private void _Reload() {
            bindingSource.DataSource = _billToUpdate.Orders
                .Select(x => new OrderViewModel {
                    ProductId = x.ProductId,
                    ProductName = x.Product.Name,
                    ProductPrice = x.Product.Price,
                    Quantity = x.Quantity,
                    Total = x.Total
                }).ToList();
        }

        # endregion

        # region Event Handler

        private void btnBrowseCustomer_Click(object sender, EventArgs e) {
            new FormListing(Contract.Customer, x => _customerToInclude = x as Customer).ShowDialog();
            if (_customerToInclude != null) {
                txtCustomerCode.Text = _customerToInclude.Id.ToString();
                txtCustomerName.Text = _customerToInclude.Name;
            }
        }

        private void btnBrowseProduct_Click(object sender, EventArgs e) {
            new FormListing(Contract.Product, x => _productToInclude = x as Product).ShowDialog();
            if (_productToInclude != null) {
                txtProductCode.Text = _productToInclude.Id.ToString();
                txtProductName.Text = _productToInclude.Name;
                txtQuantity.Select();
            }
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e) {
            _rowIndex = e.RowIndex;
        }

        private void saveItem_Click(object sender, EventArgs e) {
            if (!Utility.RequiredCheck(errorProvider, txtCustomerCode, txtProductCode, txtQuantity)) {
                return;
            }

            var quantity = int.Parse(txtQuantity.Text);
            var now = DateTime.Now;

            if (_isNew) {
                _billToUpdate = _saveModel(new Bill {
                    CustomerId = _customerToInclude.Id,
                    Customer = _customerToInclude,
                    Paid = false,
                    Tax = 0.1,
                    CreatedAt = now,
                    UpdatedAt = now
                });
                _isNew = false;
                dgv.AutoGenerateColumns = true;
                btnBrowseCustomer.Enabled = false;
                editItem.Enabled = true;
                deleteItem.Enabled = true;
            }

            if (_isUpdateOrder) {
                _orderToUpdate.Quantity = quantity;
                _Reload();
                _isUpdateOrder = false;
                _ClearForm();
            } else {
                var query = _billToUpdate.Orders.SingleOrDefault(x => x.ProductId == _productToInclude.Id);
                if (query == null) {
                    _billToUpdate.Orders.Add(new Order {
                        ProductId = _productToInclude.Id,
                        Product = _productToInclude,
                        Quantity = quantity,
                        CreatedAt = now,
                        UpdatedAt = now
                    });
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
            var orderToUpdate = _billToUpdate.Orders.SingleOrDefault(x => x.ProductId == id);
            txtProductCode.Text = orderToUpdate.ProductId.ToString();
            txtProductName.Text = orderToUpdate.Product.Name;
            txtQuantity.Text = orderToUpdate.Quantity.ToString();

            _orderToUpdate = orderToUpdate;
            _isUpdateOrder = true;
            txtQuantity.Select();
        }

        private void deleteItem_Click(object sender, EventArgs e) {
            if (Utility.ConfirmDelete()) {
                var id = int.Parse(dgv.Rows[_rowIndex].Cells["ProductId"].Value.ToString());
                var orderToDelete = _billToUpdate.Orders.SingleOrDefault(x => x.ProductId == id);
                _billToUpdate.Orders.Remove(orderToDelete);
                _Reload();
            }

            if (dgv.Rows.Count == 0) {
                editItem.Enabled = false;
                deleteItem.Enabled = false;
            }
        }

        private void saveAllItem_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        # endregion
    }
}