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
    public partial class FormBillList : Form
    {
        public FormBillList()
        {
            InitializeComponent();
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            var form = new FormAddOrder();
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
