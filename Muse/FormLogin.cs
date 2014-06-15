using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Muse.Model;

namespace Muse
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();
            var confirm = txtConfirm.Text.Trim();

            if (password != confirm)
            {
                MessageBox.Show("masukkan password dan konfirmasi password tidak sama");
                return;
            }

            if (User.Login(username, password))
            {
                var form = new FormBillList();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("username/password yang anda masukkan salah");
            }
        }
    }
}
