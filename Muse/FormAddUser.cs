using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Muse.Model;

namespace Muse
{
    public partial class FormAddUser : Form
    {
        private Action<User> _saveModel;

        public FormAddUser(Action<User> saveModel)
        {
            InitializeComponent();
            _saveModel = saveModel;
        }

        private void _clearForm()
        {
            txtName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            txtName.Select();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text;
            var address = txtAddress.Text.Trim();
            var email = txtEmail.Text.Trim();
            var phone = txtPhone.Text.Trim();
            var gender = Gender.Unknown;
            var now = DateTime.Now;

            if (rdoMale.Checked)
            {
                gender = Gender.Male;
            }
            else if (rdoFemale.Checked)
            {
                gender = Gender.Female;
            }

            _saveModel( new User
            {
                Name = name,
                Username = username,
                Password = password,
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
