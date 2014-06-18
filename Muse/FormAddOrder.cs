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
    public partial class FormAddOrder : Form
    {
        public FormAddOrder()
        {
            InitializeComponent();
        }

        private void btnBrowseCustomer_Click(object sender, EventArgs e)
        {
            var form = new FormCustomerList();
            var result = form.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void btnBrowseProduct_Click(object sender, EventArgs e)
        {
            var form = new FormProductList();
            var result = form.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }
    }
}
