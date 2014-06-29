using Muse.Model;
using System;
using System.Windows.Forms;

namespace Muse {

    public partial class FormAddCustomer : Form {
        private Action<Customer> _saveModel;
        private Customer _customer;
        private bool _isNew = true;

        public FormAddCustomer(Action<Customer> saveModel) {
            InitializeComponent();
            _saveModel = saveModel;
        }

        public FormAddCustomer(Customer customer, Action<Customer> saveModel) {
            InitializeComponent();
            _customer = customer;
            _saveModel = saveModel;
            _fillForm();
            _isNew = false;
            txtName.Enabled = false;
        }

        # region Private Method

        private void _fillForm() {
            txtName.Text = _customer.Name;
            txtAddress.Text = _customer.Address;
            txtEmail.Text = _customer.Email;
            txtPhone.Text = _customer.Phone;
            if (_customer.Gender == Gender.Male) {
                rdoMale.Checked = true;
            } else if (_customer.Gender == Gender.Female) {
                rdoFemale.Checked = true;
            }
        }

        private void _clearForm() {
            txtName.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            txtName.Select();
        }

        # endregion

        # region Event Handler

        private void btnSave_Click(object sender, EventArgs e) {
            if (!Utility.RequiredCheck(errorProvider, txtName)) {
                return;
            }

            var name = txtName.Text.Trim();
            var email = txtEmail.Text.Trim();
            var address = txtAddress.Text.Trim();
            var phone = txtPhone.Text.Trim();
            var gender = Gender.Unknown;
            var now = DateTime.Now;

            if (rdoMale.Checked) {
                gender = Gender.Male;
            } else if (rdoFemale.Checked) {
                gender = Gender.Female;
            }

            if (_isNew) {
                _saveModel(new Customer {
                    Name = name,
                    Gender = gender,
                    Address = address,
                    Email = email,
                    Phone = phone,
                    CreatedAt = now,
                    UpdatedAt = now
                });

                _clearForm();
            } else {
                _customer.Name = name;
                _customer.Gender = gender;
                _customer.Address = address;
                _customer.Email = email;
                _customer.Phone = phone;
                _customer.UpdatedAt = now;

                _saveModel(_customer);
                Close();
            }
        }

        # endregion
    }
}