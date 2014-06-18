using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Muse
{
    public partial class FormUserList : Form
    {
        public FormUserList()
        {
            InitializeComponent();
        }

        private void FormUserList_Load(object sender, EventArgs e)
        {
            using (var context = new RestoContext())
            {
                userBindingSource.DataSource = context.Users.ToList();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var form = new FormAddUser();
            var result = form.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    using (var context = new RestoContext())
                    {
                        userBindingSource.DataSource = context.Users.ToList();
                    }
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }
    }
}
