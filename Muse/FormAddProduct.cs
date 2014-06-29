using Muse.Model;
using System;
using System.Windows.Forms;

namespace Muse {

    public partial class FormAddProduct : Form {
        private Action<Product> _saveModel;
        private Product _product;
        private bool _isNew = true;

        public FormAddProduct(Action<Product> saveModel) {
            InitializeComponent();
            _saveModel = saveModel;
        }

        public FormAddProduct(Product product, Action<Product> saveModel) {
            InitializeComponent();
            _product = product;
            _saveModel = saveModel;
            _fillForm();
            _isNew = false;
        }

        # region Private Method

        private void _fillForm() {
            txtName.Text = _product.Name;
            txtPrice.Text = _product.Price.ToString();
            txtDesc.Text = _product.Description;
            txtName.Enabled = false;
        }

        private void _clearForm() {
            txtName.Clear();
            txtPrice.Clear();
            txtDesc.Clear();
            txtName.Select();
        }

        # endregion

        # region Event Handler

        private void btnSave_Click(object sender, EventArgs e) {
            if (!Utility.RequiredCheck(errorProvider, txtName, txtPrice)) {
                return;
            }

            var name = txtName.Text.Trim();
            var price = int.Parse(txtPrice.Text);
            var desc = txtName.Text.Trim();
            var now = DateTime.Now;

            if (_isNew) {
                _saveModel(new Product {
                    Name = name,
                    Price = price,
                    Description = desc,
                    CreatedAt = now,
                    UpdatedAt = now
                });

                _clearForm();
            } else {
                _product.Name = name;
                _product.Price = price;
                _product.Description = desc;

                _saveModel(_product);
                Close();
            }
        }

        # endregion
    }
}