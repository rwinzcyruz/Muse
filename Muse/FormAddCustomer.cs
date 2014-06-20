using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muse
{
    public partial class FormAddCustomer : Form
    {
        Action<Customer> _saveModel;

        public FormAddCustomer(Action<Customer> saveModel)
        {
            InitializeComponent();
            _saveModel = saveModel;
        }

        private void _clearForm()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            txtName.Select();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            var email = txtEmail.Text.Trim();
            var address = txtAddress.Text.Trim();
            var phone = txtPhone.Text.Trim();
            Nullable<bool> gender = null;
            var now = DateTime.Now;

            if (rdoMale.Checked) 
            {
                gender = true;
            }
            else if (rdoFemale.Checked) 
            {
                gender = false;
            }

            _saveModel(new Customer
            {
                Name = name,
                Gender = gender,
                Address = address,
                Email = email,
                Phone = phone,
                CreatedAt = now,
                UpdatedAt = now
            });

            _clearForm();
        }
    }
}
