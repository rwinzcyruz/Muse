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
    public partial class FormAddUser : Form
    {
        public FormAddUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text;
            var address = txtAddress.Text.Trim();
            var email = txtEmail.Text.Trim();
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

            using (var db = new RestoContext())
            {
                var user = new User
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
                };

                db.Users.Add(user);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }   
        }
    }
}
