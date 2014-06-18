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
    public partial class FormCustomerList : Form
    {
        public FormCustomerList()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var form = new FormAddCustomer();
            var result = form.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    using (var context = new RestoContext())
                    {
                        customerBindingSource.DataSource = context.Customers.ToList();
                    }
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void FormCustomerList_Load(object sender, EventArgs e)
        {
            using (var context = new RestoContext())
            {
                customerBindingSource.DataSource = context.Customers.ToList();
            }
        }
    }
}
